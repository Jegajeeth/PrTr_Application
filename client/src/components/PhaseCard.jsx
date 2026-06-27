import { useState } from "react";

export default function PhaseCard({ phase, phaseProgress = {}, onChange }) {
  const [expanded, setExpanded] = useState(false);

  const completedTopics = phaseProgress.completedTopics ?? [];
  const phaseComplete = phaseProgress.phaseComplete ?? false;

  function handlePhaseCheck(e) {
    const checked = e.target.checked;
    // Mark all topics and topic projects complete when phase is checked
    const newCompleted = checked
      ? [
          ...phase.topics.map((t) => t.id),
          ...(phase.topicProjects?.map((t) => t.id) ?? []),
        ]
      : [];
    onChange(phase.id, {
      phaseComplete: checked,
      completedTopics: newCompleted,
    });
  }

  function handleTopicCheck(topicId, checked) {
    const next = checked
      ? [...new Set([...completedTopics, topicId])]
      : completedTopics.filter((id) => id !== topicId);
    const total = phase.topics.length + (phase.topicProjects?.length ?? 0);
    const allDone = next.length === total;
    onChange(phase.id, { phaseComplete: allDone, completedTopics: next });
  }

  const progressPct =
    phase.topics.length + (phase.topicProjects?.length ?? 0) > 0
      ? Math.round(
          (completedTopics.length /
            (phase.topics.length + (phase.topicProjects?.length ?? 0))) *
            100
        )
      : phaseComplete
        ? 100
        : 0;

  return (
    <div className={`phase-card ${phaseComplete ? "phase-complete" : ""}`}>
      <div className="phase-header" onClick={() => setExpanded((v) => !v)}>
        <label
          className="phase-checkbox-label"
          onClick={(e) => e.stopPropagation()}
        >
          <input
            type="checkbox"
            checked={phaseComplete}
            onChange={handlePhaseCheck}
          />
        </label>
        <div className="phase-header-text">
          <span className="phase-title">
            {expanded ? "▾" : "▸"} Phase {phase.id.replace("phase-", "")}:{" "}
            {phase.title}
          </span>
          <span className="phase-weeks">{phase.weeks}</span>
        </div>
        <span className="phase-pct">{progressPct}%</span>
      </div>

      {expanded && (
        <div className="phase-body">
          {phase.goal && (
            <div className="phase-section">
              <span className="section-label">🎯 Goal</span>
              <p>{phase.goal}</p>
            </div>
          )}

          {phase.topics.length > 0 && (
            <div className="phase-section">
              <span className="section-label">📋 Key Topics</span>
              <ul className="topic-list">
                {phase.topics.map((topic) => {
                  const checked = completedTopics.includes(topic.id);
                  return (
                    <li
                      key={topic.id}
                      className={`topic-item ${checked ? "done" : ""}`}
                    >
                      <label>
                        <input
                          type="checkbox"
                          checked={checked}
                          onChange={(e) =>
                            handleTopicCheck(topic.id, e.target.checked)
                          }
                        />
                        {topic.text}
                      </label>
                    </li>
                  );
                })}
              </ul>
            </div>
          )}

          {phase.topicProjects && phase.topicProjects.length > 0 && (
            <div className="phase-section">
              <span className="section-label">🛠️ Topic Projects</span>
              <ul className="topic-list">
                {phase.topicProjects.map((tp) => {
                  const checked = completedTopics.includes(tp.id);
                  return (
                    <li
                      key={tp.id}
                      className={`topic-item ${checked ? "done" : ""}`}
                    >
                      <label>
                        <input
                          type="checkbox"
                          checked={checked}
                          onChange={(e) =>
                            handleTopicCheck(tp.id, e.target.checked)
                          }
                        />
                        {tp.text}
                      </label>
                    </li>
                  );
                })}
              </ul>
            </div>
          )}

          {phase.certification && (
            <div className="phase-section">
              <span className="section-label">🏆 Target Certification</span>
              <p>{phase.certification}</p>
            </div>
          )}

          {phase.difficulty && (
            <div className="phase-section">
              <span className="section-label">📈 Difficulty</span>
              <p>{phase.difficulty}</p>
            </div>
          )}

          {phase.prerequisites && (
            <div className="phase-section">
              <span className="section-label">🔗 Prerequisites</span>
              <p>{phase.prerequisites}</p>
            </div>
          )}

          {phase.timeCommitment && (
            <div className="phase-section">
              <span className="section-label">⏱️ Time Commitment</span>
              <p>{phase.timeCommitment}</p>
            </div>
          )}

          {phase.architectSkills && phase.architectSkills.length > 0 && (
            <div className="phase-section">
              <span className="section-label">🧠 Architect Skills</span>
              <ul className="topic-list">
                {phase.architectSkills.map((skill, idx) => (
                  <li key={`as-${idx}`} className="topic-item">
                    {skill}
                  </li>
                ))}
              </ul>
            </div>
          )}

          {(phase.smallProject ||
            phase.mediumProject ||
            phase.ambitiousProject) && (
            <div className="phase-section">
              <span className="section-label">💡 Project Ideas</span>
              {phase.smallProject && (
                <p>
                  <strong>Small:</strong> {phase.smallProject}
                </p>
              )}
              {phase.mediumProject && (
                <p>
                  <strong>Medium:</strong> {phase.mediumProject}
                </p>
              )}
              {phase.ambitiousProject && (
                <p>
                  <strong>Ambitious:</strong> {phase.ambitiousProject}
                </p>
              )}
            </div>
          )}

          {phase.capstone && (
            <div className="phase-section">
              <span className="section-label">🚀 Capstone Project</span>
              <p>{phase.capstone}</p>
            </div>
          )}

          {phase.resources && phase.resources.length > 0 && (
            <div className="phase-section">
              <span className="section-label">📚 Resources</span>
              <ul className="topic-list">
                {phase.resources.map((r, idx) => (
                  <li key={`res-${idx}`} className="topic-item">
                    {r}
                  </li>
                ))}
              </ul>
            </div>
          )}

          {phase.notes && (
            <div className="phase-section phase-notes">
              <span className="section-label">📝 Notes</span>
              <p>{phase.notes}</p>
            </div>
          )}
        </div>
      )}
    </div>
  );
}
