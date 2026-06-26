// const BASE = "/api";

const BASE =
  import.meta.env.MODE == "development"
    ? "/api"
    : import.meta.env.VITE_BACKEND_API_URL + "/api";

const header = import.meta.env.VITE_FUNCTION_KEY;

export async function fetchPlans() {
  const res = await fetch(`${BASE}/plans`, {
    headers: { "x-functions-key": header },
  });
  if (!res.ok) throw new Error("Failed to fetch plans");
  return res.json();
}

export async function fetchPlan(planId) {
  const res = await fetch(`${BASE}/plan/${planId}`, {
    headers: { "x-functions-key": header },
  });
  if (!res.ok) throw new Error(`Failed to fetch plan: ${planId}`);
  return res.json();
}

export async function fetchProgress(planId) {
  const res = await fetch(`${BASE}/plan/${planId}/progress`, {
    headers: { "x-functions-key": header },
  });
  if (!res.ok) throw new Error(`Failed to fetch progress for: ${planId}`);
  return res.json();
}

export async function saveProgress(planId, progress) {
  const res = await fetch(`${BASE}/plan/${planId}/progress`, {
    method: "POST",
    headers: { "Content-Type": "application/json", "x-functions-key": header },
    body: JSON.stringify(progress),
  });
  if (!res.ok) throw new Error(`Failed to save progress for: ${planId}`);
  return res.json();
}
