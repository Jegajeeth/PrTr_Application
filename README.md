# Progress Tracker

A local study progress tracking app. Add plan folders under `plans/`, open the UI, and track your progress with checkboxes.

## Structure

```
plans/
  <TaskTitle>/
    plan.md         ← your study plan (required)
    progress.json   ← auto-created when you first check something
```

## How to run

**Terminal 1 — Backend (ASP.NET)**
```bash
cd server
dotnet run --launch-profile http
# Runs on http://localhost:4000
```

**Terminal 2 — Frontend (React)**
```bash
cd client
npm install   # first time only
npm run dev
# Runs on http://localhost:5173
```

Then open **http://localhost:5173** in your browser.

## Adding a new study plan

1. Create a folder under `plans/` with your task name, e.g. `plans/KubernetesDeepDive/`
2. Add a `plan.md` file inside it following the same structure as `CloudEngineer/plan.md`
   - Use `PHASE N: Title (Weeks X-Y)` headers
   - Use `Goal:`, `Key Topics:`, `Target Certification:`, `Capstone Project:` sections
3. Refresh the browser — your new plan appears in the sidebar automatically
