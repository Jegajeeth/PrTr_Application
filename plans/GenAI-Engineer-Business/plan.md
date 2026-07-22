======================================================================
GEN AI PATH (ENGINEER MENTOR) + BUSINESS SCENARIOS (OWNER LENS) (6-MONTH BLUEPRINT)
======================================================================

Two views: **how to build** (skills + system design) and **what to build** (intermediate → advanced business problems).

----------------------------------------------------------------------
PHASE 0: Foundations (Weeks 1–6)
----------------------------------------------------------------------
Goal: Speak the language before shipping.

Difficulty: Beginner

Prerequisites: Comfortable with Python basics and HTTP/API concepts. No prior LLM experience required.

Time Commitment: ~10 hrs/week (4–6 weeks)

Key Topics:
- LLM basics: Tokens, context windows, temperature, top-p, embeddings — Every design decision starts here.
- Prompt engineering: Zero/few-shot, chain-of-thought, structured output (JSON/schema) — Cheap lever before fine-tuning.
- Python + APIs: OpenAI/Anthropic/Azure OpenAI SDK, async HTTP — Most Gen AI stacks are API-first.
- Vector basics: Embeddings, cosine similarity, chunking — RAG backbone.

Topic Projects:
- LLM basics: Experiment with temperature and top-p on the same prompt; log token usage and compare output variance.
- Prompt engineering: Build a few-shot classifier that returns structured JSON for three categories.
- Python + APIs: Async script that batches embedding requests against Azure OpenAI or OpenAI.
- Vector basics: Chunk a PDF three ways (fixed, sentence, semantic) and compare retrieval quality on 10 test questions.

Architect Skills:
- Token and context-window budgeting as a first-class design constraint.
- When prompt engineering is enough vs. when to reach for fine-tuning or RAG.

Target Certification:
- Microsoft Azure AI Fundamentals (AI-900) — optional anchor for Azure OpenAI and AI Search context.

Small Project:
- CLI that answers questions from a PDF using embeddings + a vector store (Chroma, FAISS, or Azure AI Search).

Resources:
- OpenAI / Anthropic / Azure OpenAI official SDK docs and quickstarts.
- "Prompt Engineering Guide" — promptingguide.ai (free).
- LangChain or LlamaIndex getting-started tutorials for embeddings and vector stores.

Notes:
- Phase 0 is the language layer — every later design decision starts here.

----------------------------------------------------------------------
PHASE 1: Core Patterns (Weeks 7–14)
----------------------------------------------------------------------
Goal: Know the 5 patterns that cover ~80% of production Gen AI.

Difficulty: Intermediate

Prerequisites: Phase 0 complete. Comfortable calling LLM APIs and working with embeddings.

Time Commitment: ~10–12 hrs/week (6–8 weeks)

Key Topics:
- RAG (Retrieval-Augmented Generation): Chunking strategies (fixed, semantic, parent-child); hybrid search (keyword + vector); re-ranking (cross-encoder or LLM re-rank); citation / grounding to reduce hallucination.
- Agents & tool use: ReAct, function calling, MCP (Model Context Protocol); when agents help vs. when a simple pipeline is enough.
- Fine-tuning: Domain tone, classification, extraction — when prompt engineering stops being enough.
- Multimodal: Vision, audio, documents — invoices, forms, images.
- Structured outputs: Pydantic / JSON schema enforcement; extraction, classification, entity resolution.
- Evaluation (often skipped — don't): Golden datasets, LLM-as-judge (with human spot-checks); metrics: faithfulness, relevance, latency, cost per query.

```
┌─────────────────────────────────────────────────────────┐
│  1. RAG          — retrieve context, then generate       │
│  2. Agents       — LLM + tools + planning loop           │
│  3. Fine-tuning  — domain tone, classification, extraction│
│  4. Multimodal   — vision, audio, documents              │
│  5. Eval + guardrails — quality, safety, cost control    │
└─────────────────────────────────────────────────────────┘
```

Topic Projects:
- RAG: Build hybrid search (BM25 + vector) over 5 documents; add cross-encoder re-ranking and citation snippets in answers.
- Agents & tool use: ReAct agent that calls a weather API and a SQLite DB; compare vs. a fixed two-step pipeline on latency and correctness.
- Structured outputs: Pydantic-enforced extractor that pulls invoice fields from unstructured text.
- Evaluation: Create a 30-question golden set; score faithfulness and relevance with LLM-as-judge + 10 human spot-checks.

Architect Skills:
- Pattern selection: RAG vs. agent vs. fine-tune for a given business problem.
- Eval-first mindset: define success metrics before shipping features.

Target Certification:
- Microsoft Azure AI Engineer Associate (AI-102) — sit after Phase 2 if pursuing Azure path.

Medium Project:
- Multi-doc RAG with citations, hybrid search, and a small eval suite (20–50 Q&A pairs).

Resources:
- LangGraph / LangChain agent and RAG documentation.
- RAGAS or similar eval framework docs.
- MCP specification and sample servers.

Notes:
- Deep dives for RAG, agents, structured outputs, and evaluation are the core of this phase — do not skip eval.

----------------------------------------------------------------------
PHASE 2: System Design for Gen AI (Weeks 15–24)
----------------------------------------------------------------------
Goal: Design systems that survive real traffic, cost, and failure modes.

Difficulty: Advanced

Prerequisites: Phase 1 complete. Built at least one RAG pipeline and one agent or structured-output flow.

Time Commitment: ~12–15 hrs/week (8–10 weeks)

Key Topics:
- Orchestration: LangGraph, CrewAI, custom state machines — multi-step flows with retries.
- Caching: Semantic cache (similar queries → same answer), prompt cache.
- Model routing: Small model for easy tasks, large for hard; fallback chains.
- Observability: LangSmith, Phoenix, OpenTelemetry — trace every LLM call.
- Guardrails: Input/output filters, PII redaction, jailbreak detection.
- Cost control: Token budgets, streaming, batching, summarization of context.
- Multi-tenancy: Per-tenant indexes, quotas, data isolation.
- Router pattern: Classify intent → route to specialized handler.
- Map-reduce: Chunk large docs, summarize in parallel, merge.
- Human-in-the-loop: Low confidence → queue for review.
- Async job queue: Long tasks (report gen, bulk extraction) off the request path.
- Event-driven: Document uploaded → embed → index (decouple ingest from query).

```
┌──────────────┐     ┌──────────────┐     ┌──────────────┐
│   Client     │────▶│  API Gateway │────▶│  Orchestrator│
│  (Web/Mobile)│     │  + Auth      │     │  (LangGraph, │
└──────────────┘     └──────────────┘     │   custom)    │
                                          └──────┬───────┘
                    ┌────────────────────────────┼────────────────────────────┐
                    ▼                            ▼                            ▼
            ┌──────────────┐            ┌──────────────┐            ┌──────────────┐
            │ Vector DB    │            │ LLM Provider │            │ Tool Layer   │
            │ + Metadata   │            │ (multi-model)│            │ (DB, APIs,   │
            │   filters    │            │              │            │  search)     │
            └──────────────┘            └──────────────┘            └──────────────┘
```

| Concept | What it solves |
|---------|----------------|
| **Orchestration** | LangGraph, CrewAI, custom state machines — multi-step flows with retries |
| **Caching** | Semantic cache (similar queries → same answer), prompt cache |
| **Model routing** | Small model for easy tasks, large for hard; fallback chains |
| **Observability** | LangSmith, Phoenix, OpenTelemetry — trace every LLM call |
| **Guardrails** | Input/output filters, PII redaction, jailbreak detection |
| **Cost control** | Token budgets, streaming, batching, summarization of context |
| **Multi-tenancy** | Per-tenant indexes, quotas, data isolation |

Topic Projects:
- Orchestration: LangGraph flow with retry and fallback on LLM timeout.
- Caching: Semantic cache layer; measure hit rate and cost savings on repeated queries.
- Model routing: Router that sends easy intents to a small model and hard intents to a large model.
- Observability: Full trace of every LLM call with latency and token cost per request.
- Event-driven ingest: Upload webhook → embed job → index update, decoupled from query API.

Architect Skills:
- Router, map-reduce, HITL, async job queue, and event-driven patterns for production Gen AI.
- Cost/latency trade-offs across model tiers, caching, and context summarization.
- Multi-tenant data isolation and quota design.

Target Certification:
- Azure Solutions Architect Expert (AZ-305) or AWS Solutions Architect — optional for full-stack deploy context.

Ambitious Project:
- Production-style app: auth, rate limits, observability, eval dashboard, deploy on Azure/AWS.

Capstone Project:
- Production-style app: auth, rate limits, observability, eval dashboard, deploy on Azure/AWS.

Resources:
- LangGraph, Semantic Kernel documentation.
- OpenTelemetry + LangSmith / Arize Phoenix setup guides.
- Azure Container Apps, AKS, or Azure Functions deploy docs.
- Azure AD / Entra ID (OIDC, MSAL) auth patterns.

Notes:
- Design patterns (interview + production): Router, map-reduce, human-in-the-loop, async job queue, event-driven — master all five.

----------------------------------------------------------------------
PHASE 3: Advanced (Weeks 25+, Ongoing)
----------------------------------------------------------------------
Goal: Stay current on advanced Gen AI capabilities and apply them to domain-specific builds.

Difficulty: Expert

Prerequisites: Phase 2 complete. Shipped at least one production-style Gen AI app.

Time Commitment: Ongoing (~8–10 hrs/week)

Key Topics:
- Fine-tuning / LoRA: Domain jargon, consistent format, cheaper inference at scale — when you need it.
- Multimodal: Invoices, forms, images, video summaries.
- Agentic workflows: Multi-step research, code gen, ops automation.
- RAG 2.0: GraphRAG, agentic RAG, self-correcting retrieval.
- MCP & tool ecosystems: Standardized tool interfaces for agents.
- SLM + edge: On-device, privacy, latency-sensitive.
- Responsible AI: Bias, explainability, audit trails.

| Topic | When you need it |
|-------|------------------|
| **Fine-tuning / LoRA** | Domain jargon, consistent format, cheaper inference at scale |
| **Multimodal** | Invoices, forms, images, video summaries |
| **Agentic workflows** | Multi-step research, code gen, ops automation |
| **RAG 2.0** | GraphRAG, agentic RAG, self-correcting retrieval |
| **MCP & tool ecosystems** | Standardized tool interfaces for agents |
| **SLM + edge** | On-device, privacy, latency-sensitive |
| **Responsible AI** | Bias, explainability, audit trails |

**Stack to know (2025–2026):**

- **Orchestration:** LangGraph, Semantic Kernel, custom FastAPI
- **Vector:** Pinecone, Weaviate, Azure AI Search, pgvector
- **Observability:** LangSmith, Arize Phoenix, Datadog LLM monitoring
- **Deploy:** Azure Container Apps, AKS, serverless (Functions)
- **Auth:** Azure AD / Entra ID (OIDC, MSAL)

Topic Projects:
- Fine-tuning / LoRA: LoRA fine-tune on a small domain dataset; compare inference cost vs. few-shot baseline.
- RAG 2.0: GraphRAG or agentic RAG prototype on a knowledge graph subset.
- MCP: Agent that uses two MCP servers (filesystem + DB) with audit logging.

Architect Skills:
- Selecting advanced patterns (GraphRAG, agentic workflows, edge SLMs) based on compliance, latency, and cost.
- Responsible AI: bias checks, explainability, immutable audit trails.

Small Project:
- Month 5 domain project: Pick one business scenario from Part 2 (below) and rebuild as a portfolio capstone.

Medium Project:
- Month 6 polish: Docs, demo, cost/latency benchmarks for the domain capstone.

Ambitious Project:
- Full portfolio piece: domain capstone + architecture write-up + eval dashboard + deploy on Azure.

Resources:
- LangGraph, Semantic Kernel, MCP specification docs.
- Pinecone, Weaviate, Azure AI Search, pgvector documentation.
- LangSmith, Arize Phoenix, Datadog LLM monitoring guides.

Notes:
- Suggested 6-month roadmap:

| Month | Focus | Deliverable |
|-------|--------|-------------|
| 1 | LLM APIs + embeddings + basic RAG | PDF Q&A bot |
| 2 | RAG depth + eval | RAG with citations + eval suite |
| 3 | Agents + tools | Agent that uses APIs + DB |
| 4 | System design | Auth, caching, observability, deploy |
| 5 | Domain project | Pick one business scenario below |
| 6 | Polish + portfolio | Docs, demo, cost/latency benchmarks |

======================================================================

----------------------------------------------------------------------
PART 2: BUSINESS OWNER — INTERMEDIATE → ADVANCED SCENARIOS
----------------------------------------------------------------------

These map to the engineer path above. **Intermediate** = clear ROI, 3–6 month build. **Advanced** = multi-system, agents, compliance, scale.

### Intermediate scale (single domain, measurable ROI)

#### 1. Intelligent document processing (IDP)

**Problem:** Contracts, invoices, claims, applications — manual review is slow and inconsistent.

**AI approach:** Multimodal extraction + structured output + human review queue.

```
Upload → OCR/Vision → Extract fields → Validate rules → Approve / flag
```

**Business value:** 60–80% faster processing; fewer errors.
**Engineer patterns:** Structured output, validation rules, HITL, audit log.

---

#### 2. Internal knowledge assistant (enterprise RAG)

**Problem:** Policies, SOPs, product docs scattered; support and ops waste time searching.

**AI approach:** RAG over SharePoint/Confluence/docs with citations and access control.

**Business value:** Faster onboarding; fewer "who do I ask?" tickets.
**Engineer patterns:** Hybrid search, metadata filters, per-team indexes, eval on real questions.

---

#### 3. Customer support copilot (not full auto-reply)

**Problem:** Agents repeat answers; quality varies; long handle time.

**AI approach:** Suggest replies from KB + ticket history; agent edits and sends.

**Business value:** Shorter AHT, more consistent tone, easier training.
**Engineer patterns:** RAG + tone control; no auto-send without approval at first.

---

#### 4. Sales enablement — proposal & RFP assistant

**Problem:** RFPs and proposals take days; reuse is ad hoc.

**AI approach:** RAG over past wins + product sheets; draft sections with citations.

**Business value:** Faster turnaround; higher win rate on repeat questions.
**Engineer patterns:** Template + variable slots, citation grounding, version control.

---

#### 5. Code / ops documentation generator

**Problem:** Docs drift from code; incidents lack runbooks.

**AI approach:** Index repos + tickets; generate/update runbooks and API docs.

**Business value:** Less tribal knowledge; faster incident response.
**Engineer patterns:** Scheduled indexing, diff-aware updates, human approval.

---

### Advanced scale (multi-system, agents, compliance, scale)

#### 6. Autonomous research & competitive intelligence

**Problem:** Market, competitor, and regulatory changes need continuous monitoring.

**AI approach:** Agent pipeline: search → scrape/summarize → structured report → alert on deltas.

```
Trigger (schedule/event) → Agent gathers sources → Synthesize → Dashboard + alerts
```

**Business value:** Strategic decisions on fresher data; less analyst grunt work.
**Engineer patterns:** Multi-agent orchestration, source attribution, rate limits, fact-check loops.

---

#### 7. Multi-step workflow automation (agentic ops)

**Problem:** Cross-system workflows (CRM → ERP → email → approval) are manual and error-prone.

**AI approach:** Agent with tools (APIs, DB, email) executes steps with checkpoints and rollback.

**Business value:** End-to-end automation with human gates only where needed.
**Engineer patterns:** Tool use, idempotency, audit trail, Entra-scoped permissions.

---

#### 8. Predictive maintenance + Gen AI explanations

**Problem:** IoT/sensor alerts flood ops; root cause analysis is slow.

**AI approach:** ML for anomaly detection + LLM for natural-language RCA and work orders.

**Business value:** Less downtime; clearer actions for field teams.
**Engineer patterns:** ML + RAG over manuals; streaming alerts; integration with CMMS.

---

#### 9. Regulated industry — compliance & audit assistant

**Problem:** Regulations change; proving compliance across docs and processes is expensive.

**AI approach:** RAG over regulations + internal policies; gap analysis; audit-ready summaries with citations.

**Business value:** Faster audits; lower compliance risk.
**Engineer patterns:** Strict grounding, immutable audit logs, PII handling, role-based access.

---

#### 10. Personalization at scale (content + recommendations)

**Problem:** One-size-fits-all marketing and product experiences underperform.

**AI approach:** Embeddings for user/content; LLM for personalized copy within brand guardrails.

**Business value:** Higher conversion and retention.
**Engineer patterns:** Feature store, A/B tests, guardrails, cost caps per user.

---

#### 11. Software development accelerator (internal platform)

**Problem:** Teams repeat boilerplate, tests, and reviews; quality is uneven.

**AI approach:** RAG over codebase + standards; agents for PR review, test gen, migration hints.

**Business value:** Faster delivery with guardrails.
**Engineer patterns:** Repo indexing, CI integration, no auto-merge without policy.

---

#### 12. Multi-modal customer onboarding (KYC / intake)

**Problem:** Onboarding needs ID, forms, and checks across channels.

**AI approach:** Vision + extraction + policy rules + escalation to human.

**Business value:** Faster onboarding; consistent fraud/risk signals.
**Engineer patterns:** Multimodal, structured validation, HITL, retention policies.

----------------------------------------------------------------------
HOW THE TWO VIEWS CONNECT
----------------------------------------------------------------------

| Business scenario | Engineer skills (from path) |
|-------------------|----------------------------|
| IDP, KYC | Structured output, multimodal, HITL |
| Enterprise RAG, support copilot | RAG, hybrid search, eval, auth |
| RFP / sales assistant | RAG, templates, citations |
| Competitive intelligence | Agents, orchestration, attribution |
| Workflow automation | Tool use, MCP, audit, idempotency |
| Compliance assistant | Grounding, PII, audit logs |
| Personalization | Embeddings, guardrails, A/B testing |

----------------------------------------------------------------------
PRACTICAL NEXT STEPS
----------------------------------------------------------------------

**If you're learning as an engineer:** Start Month 1 (PDF Q&A RAG), then pick **one** business scenario that matches your domain and rebuild it as the capstone.

**If you're choosing as a business owner:** Score scenarios on (1) pain severity, (2) data you already have, (3) regulatory sensitivity, (4) willingness to keep humans in the loop. **IDP**, **enterprise RAG**, and **support copilot** are usually the best first bets.

Want a **detailed architecture** for one scenario (APIs, data model, cost estimate), or a **week-by-week syllabus** for the engineer track? Name the scenario or your stack (e.g. Azure + .NET).

======================================================================
