import { useState } from 'react';
import Sidebar from './components/Sidebar';
import PlanView from './components/PlanView';
import './App.css';

export default function App() {
  const [selectedPlan, setSelectedPlan] = useState(null);

  return (
    <div className="app-layout">
      <Sidebar selectedPlan={selectedPlan} onSelect={setSelectedPlan} />
      <PlanView planId={selectedPlan} />
    </div>
  );
}
