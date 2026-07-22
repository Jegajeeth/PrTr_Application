======================================================================
FORWARD DEPLOYED ENGINEER — BEGINNER CURRICULUM (28-WEEK BLUEPRINT)
======================================================================

A hands-on path for beginners who want to become Forward Deployed Engineers —
technical problem-solvers who embed with customers, translate business needs into
working software, and ship solutions in fast, ambiguous environments. Covers
programming, cloud, data, AI integration, and the non-technical skills (communication,
stakeholder management, discovery) that separate a good engineer from a great FDE.
Five phases, escalating projects, and recognised certifications. All technologies
verified current as of July 2026.

----------------------------------------------------------------------
PHASE 1: Foundations — Programming, Problem-Solving & Professional Communication (Weeks 1–6)
----------------------------------------------------------------------
Goal: Write clean Python scripts to automate real tasks, break ambiguous problems
      into steps, and communicate technical ideas clearly in writing and conversation.

Difficulty: Beginner

Prerequisites: Comfortable using a computer and browser. No prior programming
experience required. Install VS Code, Git, and Python 3.12+ before Week 1.

Time Commitment: ~10 hrs/week

Key Topics:
- Programming (Technical): Python 3.12+ — variables, types, control flow, functions, modules, virtual environments (venv / uv), error handling, reading stack traces.
- Data Structures (Technical): Lists, dicts, sets, tuples; JSON read/write; basic file I/O (CSV, text).
- Version Control (Technical): Git fundamentals — clone, commit, branch, merge, pull request workflow; `.gitignore`; conventional commit messages.
- Command Line (Technical): Terminal basics on Windows (PowerShell) and Linux (WSL 2 / Ubuntu 24.04); navigating directories, piping, environment variables.
- Problem Decomposition (Non-Technical): Breaking a vague request into inputs, outputs, constraints, and acceptance criteria; writing a one-page problem statement.
- Written Communication (Non-Technical): Structured emails and Slack messages — context, ask, deadline; summarising a technical issue for a non-technical reader.
- Active Listening (Non-Technical): Paraphrasing a stakeholder's request back to them; asking clarifying questions without jumping to solutions.
- Time & Task Management (Non-Technical): Daily stand-up style updates; using a simple task board (GitHub Projects, Trello, or Notion).

Topic Projects:
- Programming: Write a script that reads a CSV of expenses and outputs a summary report (totals by category, top 5 spenders).
- Version Control: Fork a public repo, fix a README typo, open a PR with a clear description.
- Problem Decomposition: Given "our team wastes time on manual status reports," produce a one-page brief with problem, users, constraints, and success metrics.
- Written Communication: Draft a 150-word status update explaining a blocked task to a project manager who is not technical.

Architect Skills:
- Distinguishing "must have" vs "nice to have" when scoping a first version.
- Documenting assumptions explicitly so misunderstandings surface early.
- Choosing the simplest tool that solves the problem (script vs app vs spreadsheet).

Target Certification:
- GitHub Foundations (GH-100) — validates Git, GitHub workflow, and collaboration basics.

Small Project:
- Build a CLI tool that ingests a folder of JSON log files and prints error counts grouped by severity and date.

Medium Project:
- Create a "customer onboarding checklist" web app (Flask or FastAPI) that stores checklist items in SQLite, with a README explaining setup, API endpoints, and how to run tests.

Ambitious Project:
- Automate a real personal workflow end-to-end (e.g. fetch RSS feeds → summarise with an LLM API → email a daily digest) with Git history, a `setup.md`, and a 2-minute demo video.

Resources:
- "Automate the Boring Stuff with Python" (Al Sweigart) — free online; Chapters 1–11.
- Microsoft Learn: "GitHub Foundations" learning path.
- "Crucial Conversations" (Patterson et al.) — Chapters on listening and stating your path; audiobook OK for commute.
- freeCodeCamp: "Scientific Computing with Python" certification course.

Notes:
- FDE work is 50% code and 50% communication from day one. Treat the non-technical exercises as seriously as the coding drills.
- Pick one primary language (Python recommended for breadth) and stay with it through Phase 3 before adding a second.

----------------------------------------------------------------------
PHASE 2: Full-Stack Delivery — APIs, Databases & Customer Discovery (Weeks 7–12)
----------------------------------------------------------------------
Goal: Design and deploy a small full-stack application backed by a database, expose
      REST APIs, and run a structured discovery session to capture real user requirements.

Difficulty: Beginner

Prerequisites: Phase 1 complete. Comfortable writing Python functions and using Git.

Time Commitment: ~10–12 hrs/week

Key Topics:
- Web Fundamentals (Technical): HTTP methods, status codes, headers, JSON request/response bodies; REST conventions; OpenAPI / Swagger basics.
- Backend (Technical): FastAPI or Flask — routing, request validation (Pydantic), dependency injection, middleware, structured logging (no PII in logs).
- Frontend (Technical): HTML, CSS, JavaScript basics; React or Vue fundamentals — components, state, fetching data from an API.
- Databases (Technical): SQL fundamentals — SELECT, JOIN, INSERT, UPDATE; PostgreSQL or SQLite; migrations with Alembic or similar; indexing basics.
- Authentication (Technical): OAuth 2.0 / OIDC concepts; Microsoft Entra ID (Azure AD) app registration; MSAL for client auth; never hand-roll session/token logic.
- Testing (Technical): Unit tests (pytest), API integration tests (httpx / TestClient), test-driven development for one feature.
- Requirements Discovery (Non-Technical): User interviews — open vs closed questions, the "5 Whys," affinity mapping of pain points.
- Stakeholder Mapping (Non-Technical): Identifying decision-makers, influencers, blockers, and end users; RACI-lite for a small project.
- Demo Skills (Non-Technical): Running a 10-minute live demo — happy path first, narrate what you are doing, handle a failure gracefully.
- Documentation (Non-Technical): Writing a README, a quick-start guide, and an architecture diagram (boxes-and-arrows is fine).

Topic Projects:
- APIs: Build a CRUD API for a "ticket" resource with input validation and OpenAPI docs auto-generated.
- Databases: Model a simple CRM schema (contacts, companies, interactions) and write 5 analytical SQL queries.
- Discovery: Conduct a mock discovery interview with a friend playing "customer"; record notes and produce a requirements doc.
- Demo Skills: Record a 5-minute Loom walkthrough of any app you built, narrating value before features.

Architect Skills:
- Choosing between monolith, modular monolith, and microservices for a v1 customer pilot.
- Data modelling trade-offs: normalisation vs denormalisation for read-heavy dashboards.
- Security-by-default: auth on every endpoint, input validation, least-privilege DB accounts.

Target Certification:
- Microsoft Certified: Azure Fundamentals (AZ-900) — cloud vocabulary and core services.

Small Project:
- Deploy a FastAPI + SQLite app locally with Docker Compose; include health-check endpoint and a pytest suite with ≥80% coverage on business logic.

Medium Project:
- Build a "customer health dashboard" — React frontend, FastAPI backend, PostgreSQL — showing mock customer metrics (uptime, open tickets, last contact date). Add Entra ID login.

Ambitious Project:
- Run a full mini-engagement: interview 3 people about a real workflow pain point, write a proposal, build an MVP in 2 weeks, demo it, and collect structured feedback (what worked, what didn't, what's next).

Resources:
- FastAPI official tutorial (fastapi.tiangolo.com).
- "The Mom Test" (Rob Fitzpatrick) — how to talk to customers without leading them.
- Microsoft Learn: AZ-900 learning path + "Microsoft identity platform" docs.
- PostgreSQL Tutorial (postgresqltutorial.com) — through JOINs and indexes.

Notes:
- Resist feature creep during the ambitious project. An FDE ships value, not a perfect product.
- Practice saying "I don't know, but I'll find out by <date>" — credibility beats bluffing.

----------------------------------------------------------------------
PHASE 3: Cloud, DevOps & Production Readiness (Weeks 13–18)
----------------------------------------------------------------------
Goal: Deploy and operate applications on Azure with CI/CD, observability, and
      infrastructure-as-code — the operational backbone every embedded engineer needs.

Difficulty: Intermediate

Prerequisites: Phases 1–2. Comfortable with APIs, databases, and basic auth concepts.

Time Commitment: ~10–12 hrs/week

Key Topics:
- Cloud Platform (Technical): Azure core services — Resource Groups, App Service, Azure Container Apps, Azure SQL / Cosmos DB, Blob Storage, Key Vault, Application Insights.
- Containers (Technical): Docker — images, layers, multi-stage builds; Docker Compose for local dev; container registries (ACR).
- CI/CD (Technical): GitHub Actions or Azure DevOps pipelines — lint, test, build, deploy; environment promotion (dev → staging → prod).
- Infrastructure as Code (Technical): Bicep or Terraform basics — provision App Service + DB + Key Vault declaratively; `what-if` / `plan` before apply.
- Observability (Technical): Structured logging, metrics, distributed tracing (OpenTelemetry); Application Insights dashboards and alert rules; defining SLOs (availability, latency).
- Networking & Security (Technical): VNets, Private Endpoints, NSGs; Managed Identities; secrets from Key Vault — zero hardcoded credentials.
- Incident Response (Technical): Reading logs and traces to diagnose production issues; writing a post-incident summary (timeline, root cause, action items).
- Working Under Pressure (Non-Technical): Triage during an outage — communicate status every 15–30 min, focus on restore before root-cause.
- Cross-Functional Collaboration (Non-Technical): Partnering with security, legal, and IT teams; navigating procurement and access-request delays.
- Remote & On-Site Presence (Non-Technical): Setting up effectively at a customer site; building rapport in the first 48 hours; managing time zones.

Topic Projects:
- Containers: Containerise the Phase 2 dashboard app; image < 200 MB; run locally with Compose including Postgres.
- CI/CD: Add a pipeline that runs tests on every PR and auto-deploys `main` to a staging slot.
- Observability: Instrument an API with OpenTelemetry; create an App Insights dashboard showing request rate, error rate, and p95 latency.
- Incident Response: Given a scripted outage scenario (bad deploy + DB connection exhaustion), write a timeline and customer-facing status update.

Architect Skills:
- App Service vs Container Apps vs AKS — selecting compute for a customer pilot based on team skill, scale, and cost.
- Designing a deployment strategy (blue/green, canary) for a customer who cannot tolerate downtime.
- Cost estimation: monthly Azure spend for a 3-service architecture with budget alerts.

Target Certification:
- Microsoft Certified: Azure Developer Associate (AZ-204).

Small Project:
- Deploy a containerised API to Azure Container Apps with a managed identity pulling secrets from Key Vault; enable Application Insights with a latency alert.

Medium Project:
- Build a full CI/CD pipeline (GitHub Actions + Bicep) that provisions infrastructure, runs tests, deploys to staging, and requires manual approval for production.

Ambitious Project:
- Simulate a "customer go-live weekend": deploy to a fresh Azure subscription, run a load test (k6 or Locust), trigger and resolve a deliberate misconfiguration, and deliver a go-live checklist + runbook.

Resources:
- Microsoft Learn: AZ-204 learning path (2026 edition).
- "The Phoenix Project" (Kim et al.) — narrative intro to DevOps culture; audiobook-friendly.
- Docker docs: "Get started" + "Best practices for writing Dockerfiles."
- OpenTelemetry Python docs + Azure Monitor exporter guide.

Notes:
- Use a personal Azure subscription with a hard budget alert ($50/month cap). Tear down resources after each exercise.
- FDEs often inherit messy customer environments — practice deploying into a "messy" subscription with overlapping resource groups and unclear naming.

----------------------------------------------------------------------
PHASE 4: Data, Integration & AI-Powered Solutions (Weeks 19–24)
----------------------------------------------------------------------
Goal: Integrate disparate customer data sources, build pipelines and search
      solutions, and deliver AI-assisted features responsibly in a customer context.

Difficulty: Intermediate

Prerequisites: Phases 1–3. Comfortable deploying to Azure and writing production-grade APIs.

Time Commitment: ~10–12 hrs/week

Key Topics:
- Data Integration (Technical): ETL / ELT patterns; batch vs streaming; Azure Data Factory or Fabric pipelines; connecting to SQL, REST APIs, files (CSV, Parquet).
- Data Modelling (Technical): Star schema basics; slowly changing dimensions; data quality checks (null rates, duplicates, freshness).
- Search & Retrieval (Technical): Azure AI Search — indexes, skillsets, hybrid (keyword + vector) search; chunking strategies for documents.
- AI / LLM Integration (Technical): Azure OpenAI or Foundry — chat completions, embeddings, function calling; prompt engineering; RAG architecture (retrieve → augment → generate).
- API Integration (Technical): Consuming third-party REST / GraphQL APIs; handling rate limits, retries, pagination; webhook receivers.
- Data Privacy & Compliance (Technical): PII detection and redaction; data residency; logging policies that never capture borrower/customer data in plain text.
- Solution Scoping (Non-Technical): Estimating effort for a customer POC — scope, risks, dependencies, and a 2-week delivery plan.
- Managing Expectations (Non-Technical): Saying no with alternatives; explaining AI limitations (hallucination, latency, cost) to executives.
- Change Management (Non-Technical): Helping customer teams adopt a new tool — training sessions, office hours, champion identification.
- Storytelling with Data (Non-Technical): Presenting insights as a narrative — situation, complication, resolution; one chart per slide.

Topic Projects:
- Data Integration: Build a pipeline that ingests CSV + API data into a staging table, runs quality checks, and loads a star-schema warehouse.
- Search: Index 50+ PDF documents in Azure AI Search; implement hybrid search with a simple "ask your docs" UI.
- AI Integration: Add a RAG-powered Q&A endpoint to the search UI; log query volume and latency, not query content.
- Solution Scoping: Write a 1-page POC proposal for "automate invoice processing" including scope, out-of-scope, timeline, and risks.

Architect Skills:
- Batch vs streaming vs event-driven — choosing a data architecture for a customer's freshness requirements.
- RAG vs fine-tuning vs prompt-only — decision framework based on data volume, update frequency, and compliance.
- Total cost of ownership for an AI feature (model tokens, search units, storage, compute).

Target Certification:
- Microsoft Certified: Azure Data Fundamentals (DP-900) — baseline data vocabulary.
- Stretch goal: Microsoft Certified: Azure AI Engineer Associate (AI-102).

Small Project:
- Deploy a document-ingestion pipeline (Blob Storage → AI Search) with a FastAPI endpoint that returns top-3 relevant passages for a user question.

Medium Project:
- Build an "integration hub" that syncs data from a mock CRM API and a SQL database into a unified PostgreSQL schema, with a data-quality report endpoint.

Ambitious Project:
- Deliver an end-to-end "customer knowledge assistant" — ingest docs, hybrid search, RAG Q&A with citations, Entra ID auth, deployed on Azure with CI/CD, cost dashboard, and a 10-slide executive summary deck.

Resources:
- Microsoft Learn: DP-900 + AI-102 learning paths.
- "Designing Data-Intensive Applications" (Martin Kleppmann) — Chapters 1–3, 10–11 for foundations.
- Azure AI Search + Azure OpenAI RAG quickstart (Microsoft Learn).
- "Storytelling with Data" (Cole Nussbaumer Knaflic) — Chapters 1–5.

Notes:
- Never demo AI on real customer PII in a learning environment — use synthetic or public datasets only.
- Practice explaining a RAG pipeline to a CFO in 60 seconds: "It finds the right document, then answers using only that document."

----------------------------------------------------------------------
PHASE 5: The FDE Craft — Engagement, Delivery & Portfolio (Weeks 25–28)
----------------------------------------------------------------------
Goal: Run a simulated customer engagement from kickoff to handoff, synthesising
      all technical and non-technical skills into a portfolio-ready capstone.

Difficulty: Advanced

Prerequisites: Phases 1–4 complete.

Time Commitment: ~12–15 hrs/week

Key Topics:
- Engagement Lifecycle (Non-Technical): Kickoff → discovery → design → build → demo → iterate → handoff → retrospective; Statement of Work (SOW) basics.
- Political Navigation (Non-Technical): Identifying hidden agendas; building alliances with customer champions; escalating blockers without burning bridges.
- Consulting Frameworks (Non-Technical): MECE problem structuring; hypothesis-driven development; pre-mortems and risk registers.
- Technical Leadership (Technical): Leading a 2-person "pod" — task breakdown, code review, pair debugging; making reversible vs irreversible decisions fast.
- Security & Compliance Reviews (Technical): Preparing for customer security questionnaires; threat modelling a simple architecture (STRIDE lite).
- Handoff & Sustainability (Technical): Runbooks, on-call playbooks, knowledge-transfer sessions; designing for the customer team to maintain without you.
- Personal Brand (Non-Technical): Portfolio site, LinkedIn narrative, writing one technical blog post about a problem you solved.
- Resilience & Adaptability (Non-Technical): Working in ambiguity; travel readiness; maintaining energy across long engagements; seeking feedback aggressively.

Topic Projects:
- Engagement Lifecycle: Write a kickoff deck (10 slides) for a fictional customer "Acme Logistics" wanting a shipment-tracking dashboard.
- Political Navigation: Role-play a scenario where IT blocks your cloud deployment; draft an escalation email to your sponsor with options.
- Consulting Frameworks: Produce a MECE issue tree for "reduce customer onboarding time from 6 weeks to 2."
- Handoff: Create a runbook with deployment steps, rollback procedure, monitoring links, and FAQ for a handoff to a junior customer engineer.

Architect Skills:
- Building a phased delivery roadmap — MVP in 2 weeks, v1 in 6 weeks, v2 based on feedback — with explicit go/no-go gates.
- Writing an Architecture Decision Record (ADR) for a key choice (e.g. "Why we chose Cosmos DB over PostgreSQL for this pilot").
- Measuring engagement success: adoption metrics, time-to-value, customer satisfaction (NPS or simple survey).

Target Certification:
- No new certification required — focus on portfolio. Optional: Microsoft Certified: DevOps Engineer Expert (AZ-400) for pipeline maturity signal.

Small Project:
- Write 3 ADRs for architectural decisions made in earlier phases; publish them in a `/docs/adr` folder in your portfolio repo.

Medium Project:
- Conduct a 1-week "simulated engagement" with a volunteer playing customer: discovery call → daily stand-ups → mid-week demo → feedback → adjusted delivery.

Ambitious Project:
- Capstone: End-to-end simulated FDE engagement — (1) discovery + proposal, (2) build a customer-facing solution (dashboard, integration, or AI assistant — your choice), (3) deploy to Azure with CI/CD and monitoring, (4) deliver executive demo + technical handoff docs, (5) publish portfolio case study with architecture diagram, lessons learned, and metrics.

Resources:
- "The Trusted Advisor" (Maister et al.) — building credibility and trust with clients.
- "Team Topologies" (Skelton & Pais) — how FDE pods interact with platform and stream-aligned teams.
- Architecture Decision Records (adr.github.io) — template and examples.
- Palantir blog + Databricks "Field Engineering" career pages — real-world FDE role descriptions for calibration.

Notes:
- The capstone is your interview artifact. Optimise for a clear story: customer problem → your approach → what you shipped → measurable outcome.
- Ask 2–3 practitioners (FDE, solutions architect, or consultant) for a 30-minute portfolio review before job applications.

======================================================================
