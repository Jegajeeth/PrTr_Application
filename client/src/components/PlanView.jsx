import { useEffect, useState, useCallback, useRef } from "react";
import { fetchPlan, fetchProgress, saveProgress } from "../api";
import { getCache, setCache, PROGRESS_TTL } from "../hooks/useSessionCache";
import PhaseCard from "./PhaseCard";

export default function PlanView({ planId }) {
  const [plan, setPlan] = useState(null);
  const [progress, setProgress] = useState({ phases: {} });
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState(null);
  const [saveStatus, setSaveStatus] = useState("");
  const saveTimerRef = useRef(null);

  // Clear any pending debounced save on unmount
  useEffect(() => () => clearTimeout(saveTimerRef.current), []);

  useEffect(() => {
    if (!planId) return;
    setLoading(true);
    setError(null);

    const cachedPlan = getCache(`plan_${planId}`);
    const cachedProgress = getCache(`progress_${planId}`, PROGRESS_TTL);

    if (cachedPlan && cachedProgress) {
      setPlan(cachedPlan);
      setProgress(cachedProgress);
      setLoading(false);
      return;
    }

    const planFetch = cachedPlan
      ? Promise.resolve(cachedPlan)
      : fetchPlan(planId);
    const progressFetch = cachedProgress
      ? Promise.resolve(cachedProgress)
      : fetchProgress(planId);

    Promise.all([planFetch, progressFetch])
      .then(([planData, progressData]) => {
        if (!cachedPlan) setCache(`plan_${planId}`, planData);
        if (!cachedProgress) setCache(`progress_${planId}`, progressData);
        setPlan(planData);
        setProgress(progressData || { phases: {} });
        setLoading(false);
      })
      .catch((err) => {
        setError(err.message);
        setLoading(false);
      });
  }, [planId]);

  const handlePhaseChange = useCallback(
    (phaseId, phaseProgress) => {
      const updated = {
        ...progress,
        phases: { ...progress.phases, [phaseId]: phaseProgress },
      };
      setProgress(updated);
      setSaveStatus("Saving…");

      clearTimeout(saveTimerRef.current);
      saveTimerRef.current = setTimeout(async () => {
        try {
          await saveProgress(planId, updated);
          setCache(`progress_${planId}`, updated);
          setSaveStatus("Saved ✓");
          setTimeout(() => setSaveStatus(""), 2000);
        } catch {
          setSaveStatus("Save failed ✗");
        }
      }, 1500);
    },
    [planId, progress],
  );

  if (!planId) {
    return (
      <main className="plan-view plan-empty">
        <p>← Select a study plan from the sidebar</p>
      </main>
    );
  }

  if (loading) return <main className="plan-view plan-loading">Loading…</main>;
  if (error)
    return <main className="plan-view plan-error">Error: {error}</main>;
  if (!plan) return null;

  // Compute overall progress
  const totalTopics = plan.phases.reduce((sum, p) => sum + p.topics.length, 0);
  const completedTopics = plan.phases.reduce((sum, p) => {
    const pp = progress.phases?.[p.id];
    return (
      sum +
      (pp?.completedTopics?.length ?? (pp?.phaseComplete ? p.topics.length : 0))
    );
  }, 0);
  const overallPct =
    totalTopics > 0 ? Math.round((completedTopics / totalTopics) * 100) : 0;

  return (
    <main className="plan-view">
      <div className="plan-header">
        <h1 className="plan-title">{planId}</h1>
        {saveStatus && <span className="save-status">{saveStatus}</span>}
      </div>

      <div className="overall-progress">
        <div className="overall-progress-labels">
          <span>Overall Progress</span>
          <span>
            {completedTopics} / {totalTopics} topics — {overallPct}%
          </span>
        </div>
        <div className="progress-bar-track">
          <div
            className="progress-bar-fill"
            style={{ width: `${overallPct}%` }}
          />
        </div>
      </div>

      <div className="phases">
        {plan.phases.map((phase) => (
          <PhaseCard
            key={phase.id}
            phase={phase}
            phaseProgress={progress.phases?.[phase.id]}
            onChange={handlePhaseChange}
          />
        ))}
      </div>
    </main>
  );
}
