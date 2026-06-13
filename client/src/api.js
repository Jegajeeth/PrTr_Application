const BASE = '/api';

export async function fetchPlans() {
  const res = await fetch(`${BASE}/plans`);
  if (!res.ok) throw new Error('Failed to fetch plans');
  return res.json();
}

export async function fetchPlan(planId) {
  const res = await fetch(`${BASE}/plans/${planId}`);
  if (!res.ok) throw new Error(`Failed to fetch plan: ${planId}`);
  return res.json();
}

export async function fetchProgress(planId) {
  const res = await fetch(`${BASE}/plans/${planId}/progress`);
  if (!res.ok) throw new Error(`Failed to fetch progress for: ${planId}`);
  return res.json();
}

export async function saveProgress(planId, progress) {
  const res = await fetch(`${BASE}/plans/${planId}/progress`, {
    method: 'POST',
    headers: { 'Content-Type': 'application/json' },
    body: JSON.stringify(progress),
  });
  if (!res.ok) throw new Error(`Failed to save progress for: ${planId}`);
  return res.json();
}
