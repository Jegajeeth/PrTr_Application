import { useEffect, useState } from "react";

import { fetchPlans } from "../api";
import { getCache, setCache } from "../hooks/useSessionCache";

export default function Sidebar({ selectedPlan, onSelect }) {
  const [plans, setPlans] = useState([]);
  const [error, setError] = useState(null);

  useEffect(() => {
    const cached = getCache("plans_list");
    if (cached) {
      setPlans(cached);
      return;
    }
    fetchPlans()
      .then((data) => {
        setCache("plans_list", data);
        setPlans(data);
      })
      .catch(() => setError("Could not load plans. Is the server running?"));
  }, []);

  if (error) return <div className="sidebar-error">{error}</div>;

  return (
    <aside className="sidebar">
      <h2 className="sidebar-title">📚 Study Plans</h2>
      <ul className="sidebar-list">
        {plans.map((plan) => (
          <li
            key={plan}
            className={`sidebar-item ${selectedPlan === plan ? "active" : ""}`}
            onClick={() => onSelect(plan)}
          >
            {plan}
          </li>
        ))}
      </ul>
    </aside>
  );
}
