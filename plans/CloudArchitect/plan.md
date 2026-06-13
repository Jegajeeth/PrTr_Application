======================================================================
AZURE CLOUD ARCHITECT CURRICULUM FOR .NET ENGINEERS (44-WEEK BLUEPRINT)
======================================================================

A nine-phase, beginner-to-expert roadmap that lifts a mid-level .NET backend engineer
into a Microsoft Azure Cloud Architect role. Each phase pairs a current Microsoft (or
HashiCorp / Linux Foundation) certification with three escalating hands-on projects
(small, medium, ambitious) and the architect-level competencies needed to design,
defend, and operate cloud solutions at scale. All technologies verified current as of
June 2026.

----------------------------------------------------------------------
PHASE 1: Azure Administration & Core Infrastructure (Weeks 1–6)
----------------------------------------------------------------------
Goal: Operate enterprise-grade Azure infrastructure — identity, networking, storage,
      and compute — from both the portal and the CLI with confidence.

Difficulty: Intermediate

Prerequisites: 3+ years of backend engineering; basic familiarity with the Azure
portal and resource groups. (AZ-900 fundamentals optional but recommended.)

Time Commitment: ~10–12 hrs/week

Key Topics:
- Identity: Microsoft Entra ID (formerly Azure AD), Conditional Access, Privileged Identity Management (PIM), Managed Identities.
- RBAC & Governance: Built-in vs custom roles, Azure Policy, Management Groups, Resource Locks, Cost Management + FinOps basics.
- Networking: Virtual Networks, Subnets, NSGs, Application Security Groups, Azure Virtual Network Manager (centralized hub-spoke).
- Connectivity: Azure Bastion, Private Endpoints, Private Link, VPN Gateway, ExpressRoute, VNet peering.
- Storage: Storage Accounts (Blob, Files, Queues, Tables), lifecycle policies, immutability, customer-managed keys.
- Compute: VMs, VM Scale Sets, Availability Zones, Azure Backup, Azure Site Recovery.

Architect Skills:
- Hub-and-spoke vs Virtual WAN trade-off reasoning.
- Choosing between Public IP, Private Endpoint, and Service Endpoint for PaaS access.
- Designing tag taxonomies and management-group hierarchies for governance.

Target Certification:
- Microsoft Certified: Azure Administrator Associate (AZ-104)

Small Project:
- Build a hardened Linux/Windows VM behind Azure Bastion with NSG flow logs streamed to Log Analytics — no public IP exposure anywhere.

Medium Project:
- Construct a fully private hub-spoke topology (1 hub VNet, 2 spoke VNets) with Azure Firewall, forced tunnelling, and Private DNS zones for Key Vault and Storage.

Ambitious Project:
- Deploy a multi-region (e.g. Sweden Central + West Europe) high-availability workload with paired Storage Accounts (GZRS), Azure Site Recovery, and a documented DR runbook tested with a real failover.

Resources:
- Microsoft Learn AZ-104 learning path (current 2026 edition).
- Book: "Exam Ref AZ-104 Microsoft Azure Administrator" (latest edition).
- Microsoft Cloud Adoption Framework — Govern methodology.

Notes:
- Use a personal pay-as-you-go subscription (with a hard budget alert) — the free tier doesn't include Bastion or Azure Firewall.

----------------------------------------------------------------------
PHASE 2: Azure Development & Application Architecture (Weeks 7–12)
----------------------------------------------------------------------
Goal: Translate your .NET 10 skills into idiomatic, secure, cloud-native Azure
      applications spanning PaaS, serverless, and event-driven patterns.

Difficulty: Intermediate

Prerequisites: Phase 1 (AZ-104) complete or in progress; comfortable with ASP.NET
Core, dependency injection, and async/await.

Time Commitment: ~10–12 hrs/week

Key Topics:
- Runtime: .NET 10 LTS (released Nov 2025), minimal APIs, native AOT for cold-start-sensitive workloads.
- Cloud-native .NET: .NET Aspire 9+ for local orchestration, service discovery, and OpenTelemetry wiring.
- PaaS: Azure App Service (Premium v4), deployment slots, auto-heal, App Service Environment v3.
- Serverless: Azure Functions on the isolated worker model (Flex Consumption plan).
- Messaging: Azure Service Bus (topics, sessions, dead-lettering), Event Grid, Event Hubs.
- Data: Cosmos DB (NoSQL + vCore for MongoDB), Azure SQL Hyperscale, Azure Cache for Redis Enterprise.
- Secrets & Config: Key Vault references, App Configuration with feature flags, Managed Identity for everything.

Architect Skills:
- Choosing between App Service, Container Apps, Functions, and AKS for a given workload.
- Designing idempotent message handlers and outbox patterns for at-least-once delivery.
- Cosmos DB partition-key design and RU/s capacity planning.

Target Certification:
- Microsoft Certified: Azure Developer Associate (AZ-204)

Small Project:
- Build a .NET 10 minimal API on App Service that pulls connection strings exclusively from Key Vault via system-assigned Managed Identity (zero secrets in app settings).

Medium Project:
- Implement an Azure Functions + Service Bus + Cosmos DB order-processing pipeline using the outbox pattern, exposing OpenTelemetry traces to Application Insights.

Ambitious Project:
- Architect and ship a multi-tenant SaaS API using .NET Aspire, App Service deployment slots for blue/green, Cosmos DB with per-tenant partition keys, and Azure Front Door with WAF for global ingress.

Resources:
- Microsoft Learn AZ-204 learning path (2026 edition).
- "Cloud Native Patterns" by Cornelia Davis (still the canonical primer).
- .NET Aspire docs + the official eShopOnContainers Aspire reference app.

----------------------------------------------------------------------
PHASE 3: Infrastructure as Code & Automation (Weeks 13–17)
----------------------------------------------------------------------
Goal: Provision and evolve every Azure resource declaratively, with peer-reviewed
      code, automated validation, and state-locked pipelines.

Difficulty: Advanced

Prerequisites: Phases 1–2; comfortable with Git branching strategies.

Time Commitment: ~10 hrs/week

Key Topics:
- Bicep: Modules, loops, conditionals, decorators, what-if deployments; Bicep registry.
- Azure Verified Modules (AVM): Microsoft-supported Bicep + Terraform modules — the new enterprise baseline.
- Terraform 1.10+: Providers, backends (AzureRM remote state in Storage with state locking), workspaces, OpenTofu compatibility.
- Pipelines as code: terraform fmt/validate/plan/apply gated on PRs; Bicep linting + what-if in CI.
- Secrets handling in IaC: Federated Workload Identity for OIDC (no long-lived service principals).
- Drift detection and remediation strategies.

Architect Skills:
- Selecting between Bicep, Terraform, and Pulumi based on team skillset, multi-cloud reach, and module ecosystem.
- Designing a module library with semantic versioning and contract tests.
- Reasoning about state file blast radius and per-environment isolation.

Target Certification:
- HashiCorp Certified: Terraform Associate (003)

Small Project:
- Convert a single resource group (web app + storage + key vault) from portal-created to a Bicep template consumed by `az deployment group create`.

Medium Project:
- Refactor the Phase 1 hub-spoke topology into a reusable Terraform module pulling from Azure Verified Modules, with a CI pipeline running fmt/validate/tflint/checkov on every PR.

Ambitious Project:
- Build an internal "platform module library" (in Bicep AND Terraform) for landing-zone-grade resources (VNet, AKS, Key Vault, ACR) with versioned releases, contract tests via Terratest or Pester, and a GitHub Actions workflow that publishes to a private registry.

Resources:
- HashiCorp Learn — Terraform Associate (003) study path.
- Microsoft Learn: "Fundamentals of Bicep" + "Azure Verified Modules" docs.
- Book: "Terraform: Up & Running" 3rd edition (Brikman).

----------------------------------------------------------------------
PHASE 4: Containers, Kubernetes & Microservices (Weeks 18–23)
----------------------------------------------------------------------
Goal: Design and operate production-grade container platforms on Azure, choosing
      the right hosting tier per workload and securing the supply chain.

Difficulty: Advanced

Prerequisites: Phases 1–3; comfortable with Linux shell and basic networking
(CIDR, DNS, TLS).

Time Commitment: ~12–15 hrs/week

Key Topics:
- Containers: Docker, multi-stage Dockerfiles for .NET, distroless / chiselled .NET images, SBOM generation.
- Registry: Azure Container Registry (Premium SKU), content trust, image signing with Notation/Cosign, vulnerability scanning via Microsoft Defender for Containers.
- Lightweight hosting: Azure Container Apps (KEDA-based autoscaling, Dapr building blocks).
- AKS Automatic (GA): Microsoft's recommended managed mode with production-ready defaults, automatic node management, Karpenter-based scaling.
- AKS Standard: Node pools, taints/tolerations, Cluster Autoscaler, Azure CNI Overlay, Cilium dataplane.
- AI on Kubernetes: KAITO (Kubernetes AI Toolchain Operator) for hosting open-source LLMs.
- Service mesh: Istio add-on for AKS, mTLS, traffic shifting.

Architect Skills:
- ACA vs AKS Automatic vs AKS Standard selection criteria (cost, control, scale).
- Pod identity strategies: workload identity federation with Entra ID.
- Designing zero-downtime deployment topologies (canary, blue/green, traffic shadowing).

Target Certification:
- Certified Kubernetes Administrator (CKA) — Kubernetes v1.32+ exam.

Small Project:
- Containerize a .NET 10 API with a multi-stage chiselled Ubuntu image, push it to ACR, and sign the image with Notation.

Medium Project:
- Deploy a 3-service microservice app to Azure Container Apps using Dapr pub/sub (Service Bus) and Dapr state (Cosmos DB), with KEDA scaling rules driven by queue depth.

Ambitious Project:
- Stand up an AKS Automatic cluster with Workload Identity, Istio mTLS, Karpenter scaling a GPU node pool, and KAITO hosting a Phi-3 model — exposed via a private ingress and consumed by a .NET 10 client.

Resources:
- Linux Foundation CKA prep course (kubernetes.io official).
- Microsoft Learn: "Introduction to AKS Automatic".
- Book: "Kubernetes Patterns" 2nd ed. (Ibryam & Huss).

----------------------------------------------------------------------
PHASE 5: DevOps, CI/CD & Site Reliability Engineering (Weeks 24–28)
----------------------------------------------------------------------
Goal: Build and operate end-to-end automated delivery pipelines and the
      observability + reliability practices that keep them safe.

Difficulty: Advanced

Prerequisites: Phases 1–4 (especially IaC and Kubernetes).

Time Commitment: ~10 hrs/week

Key Topics:
- Pipelines: GitHub Actions (current default), Azure DevOps Pipelines (still ubiquitous in enterprises).
- Supply-chain security: GitHub Advanced Security for Azure DevOps (GA), CodeQL, Dependabot, secret scanning, SLSA provenance.
- Developer experience: Microsoft Dev Box, GitHub Codespaces, GitHub Copilot for DevOps (PR summaries, workflow generation).
- IaC pipelines: terraform plan → manual approval → apply with OIDC federation; Bicep what-if gates.
- Observability: OpenTelemetry SDK + Collector, Azure Monitor, Application Insights, Log Analytics, Managed Grafana, Managed Prometheus.
- SRE practices: SLI/SLO/error budgets, runbooks, chaos engineering with Azure Chaos Studio, incident retrospectives.

Architect Skills:
- Designing branching + environment promotion strategies (trunk-based vs GitFlow vs release branches).
- Defining SLIs/SLOs that map to actual user pain (latency p99, availability, freshness).
- Cost-aware observability: sampling, log tier choices, cardinality control.

Target Certification:
- Microsoft Certified: DevOps Engineer Expert (AZ-400)
  (Prerequisite satisfied by your AZ-104 or AZ-204.)

Small Project:
- Build a GitHub Actions workflow that runs `dotnet test`, builds a container, signs it with Cosign, and pushes to ACR — gated on a passing CodeQL scan.

Medium Project:
- Wire up a full IaC + app pipeline: PR runs `terraform plan` + Bicep what-if; merge to main does a canary deploy to AKS via Argo Rollouts with automatic rollback on SLO breach.

Ambitious Project:
- Implement a production-grade platform: blue/green deploys across two AKS regions with Front Door traffic shifting, OpenTelemetry → Managed Prometheus + Grafana SLO dashboards, Chaos Studio fault injections in a nightly job, and a published incident-response runbook.

Resources:
- Microsoft Learn AZ-400 learning path (2026 edition).
- Book: "Site Reliability Engineering" (Google) + "The SRE Workbook".
- GitHub: "GitHub Well-Architected" guidance.

----------------------------------------------------------------------
PHASE 6: Cloud Security Engineering & Zero Trust (Weeks 29–32)
----------------------------------------------------------------------
Goal: Embed Zero Trust principles into every layer of an Azure solution, from
      identity to data to workload runtime.

Difficulty: Advanced

Prerequisites: Phases 1–5.

Time Commitment: ~10 hrs/week

Key Topics:
- Identity hardening: Entra ID Conditional Access, PIM, Entra ID Governance (access reviews, entitlement management), passwordless / phishing-resistant MFA.
- Platform security: Microsoft Defender for Cloud (CNAPP — covers CSPM + CWPP + DSPM), Azure Policy + Defender regulatory compliance packs.
- SIEM/SOAR: Microsoft Sentinel — KQL, analytics rules, playbooks via Logic Apps, UEBA.
- Network security: Azure Firewall Premium with IDPS + TLS inspection, Azure DDoS Protection, Front Door + WAF.
- Data security: Always Encrypted, customer-managed keys via Key Vault Managed HSM, Microsoft Purview for classification + DLP.
- Confidential computing: Azure Confidential VMs (AMD SEV-SNP, Intel TDX), confidential containers on AKS.

Architect Skills:
- Threat modelling (STRIDE / MITRE ATT&CK for Cloud) applied to Azure reference architectures.
- Designing secrets-rotation lifecycles using Key Vault events + Functions.
- Choosing between platform-managed keys, customer-managed keys, and HSM-protected keys based on regulatory drivers.

Target Certification:
- Microsoft Certified: Azure Security Engineer Associate (AZ-500)

Small Project:
- Enable Microsoft Defender for Cloud on a subscription, remediate the top-10 secure-score recommendations, and document each fix in an architectural decision record (ADR).

Medium Project:
- Build a Microsoft Sentinel detection: ingest AKS audit logs + Entra sign-in logs, write a KQL analytics rule that catches a privilege-escalation pattern, and trigger an auto-isolation playbook.

Ambitious Project:
- Deliver a regulated-workload reference architecture (HIPAA-style) on Azure: Confidential VMs, Always Encrypted SQL, Purview classification, private-only networking, Defender CSPM enforced policies, and a Sentinel workspace with a custom workbook for compliance posture.

Resources:
- Microsoft Learn AZ-500 learning path (2026 edition).
- Microsoft Zero Trust Guidance Center.
- "Threat Modeling: Designing for Security" (Adam Shostack).

----------------------------------------------------------------------
PHASE 7: Data Platform & AI Workloads (Weeks 33–37)
----------------------------------------------------------------------
Goal: Architect modern unified-data and generative-AI solutions on Azure, using
      Microsoft Fabric and Azure AI Foundry as your primary platforms.

Difficulty: Advanced

Prerequisites: Phases 1–6; comfortable with SQL and basic Python.

Time Commitment: ~12 hrs/week

Key Topics:
- Microsoft Fabric: OneLake (single logical data lake), Lakehouse + Warehouse, Data Factory pipelines, Real-Time Intelligence (KQL DB / Eventstream), Direct Lake mode for Power BI.
- Medallion architecture (bronze/silver/gold) implemented in Fabric.
- Azure Databricks (still relevant for advanced Spark + Delta Live Tables workloads).
- Azure AI Foundry (the renamed/expanded successor to Azure AI Studio, 2025+): model catalog, model deployments, evaluations, content safety.
- Azure OpenAI Service: GPT-4o / GPT-4.1 / o-series models, fine-tuning, batch inference, provisioned throughput.
- Azure AI Agent Service: stateful agents with tool calling, RAG, and orchestration.
- RAG patterns: Azure AI Search (vector + hybrid + semantic ranking), chunking strategies, embedding model selection.

Architect Skills:
- Choosing between Fabric, Synapse (legacy), and Databricks for analytical workloads.
- Designing data contracts and data-mesh ownership boundaries.
- Cost + latency trade-offs for generative-AI inference (pay-as-you-go vs PTU vs on-prem GPU).
- Responsible-AI checklist: groundedness, content filters, prompt injection defences.

Target Certification:
- Microsoft Certified: Fabric Data Engineer Associate (DP-700) — replaces the retired DP-203.
- Stretch goal: Microsoft Certified: Azure AI Engineer Associate (AI-102).

Small Project:
- Ingest a public CSV dataset into a Fabric Lakehouse, build bronze/silver/gold layers via notebooks, and surface a Power BI report in Direct Lake mode.

Medium Project:
- Build a RAG-based document Q&A app in .NET 10 using Azure AI Search (vector + hybrid) over a corporate-docs corpus, with Azure OpenAI for generation and an Application Insights dashboard tracking groundedness scores.

Ambitious Project:
- Architect an end-to-end "Insight Platform": Fabric Eventstream ingesting clickstream → KQL real-time analytics → Fabric Lakehouse for historical → Azure AI Foundry agent that answers exec questions using both, deployed behind APIM with content-safety filters.

Resources:
- Microsoft Learn DP-700 learning path.
- Microsoft Learn AI-102 learning path.
- "Designing Data-Intensive Applications" (Kleppmann) — still the bible for data architecture.

----------------------------------------------------------------------
PHASE 8: Azure Solutions Architect Expert (Weeks 38–41)
----------------------------------------------------------------------
Goal: Translate ambiguous business requirements into defensible Azure designs that
      honour the Well-Architected pillars and Cloud Adoption Framework guidance.

Difficulty: Expert

Prerequisites: Phases 1–7. AZ-104 cert required to claim AZ-305 Expert badge.

Time Commitment: ~12 hrs/week

Key Topics:
- Azure Well-Architected Framework: Reliability, Security, Cost Optimization, Operational Excellence, Performance Efficiency — and how to run a WAF Review.
- Cloud Adoption Framework (CAF): Strategy, Plan, Ready, Adopt, Govern, Manage, Secure methodologies.
- Azure Landing Zones (ALZ): platform vs application landing zones, ALZ Bicep / Terraform accelerators.
- Identity at scale: multi-tenant Entra ID, B2C → External ID migration, cross-tenant collaboration.
- Hybrid + multi-cloud: Azure Arc (servers, Kubernetes, data services), Azure Stack HCI.
- Resilient designs: paired regions, Availability Zones, Front Door + Traffic Manager, active-active vs active-passive.
- Business continuity: RPO/RTO, ASR orchestration, multi-region Cosmos DB, geo-restore.
- Migration: Azure Migrate assessments, lift-and-shift vs refactor vs rebuild decision matrices.

Architect Skills:
- Producing C4-style architecture diagrams and ADRs.
- Cost optimization: reservations vs savings plans vs spot vs on-demand; right-sizing playbooks.
- Defending a design in a review — explaining trade-offs against each WAF pillar.

Target Certification:
- Microsoft Certified: Azure Solutions Architect Expert (AZ-305) — refreshed 17-Apr-2026.

Small Project:
- Take any project from Phases 1–7 and produce a one-page Well-Architected Review scoring it against all five pillars with prioritized remediation actions.

Medium Project:
- Deploy the official Azure Landing Zones (ALZ) Bicep accelerator into a sandbox tenant, then add a custom "application landing zone" for a .NET microservice workload.

Ambitious Project:
- Take a realistic case study (e.g. "migrate a 200-VM on-prem ERP to Azure with 99.95% SLA and 30% cost reduction") and deliver a full architecture package: requirements doc, options analysis, chosen architecture with diagrams, IaC scaffolding, cost model, and a 12-month migration roadmap.

Resources:
- Microsoft Learn AZ-305 learning path (April 2026 refresh).
- Azure Well-Architected Framework docs + WAF Review tool.
- Azure Architecture Center reference architectures.
- Book: "Designing Distributed Systems" (Brendan Burns) — short and high-signal.

----------------------------------------------------------------------
PHASE 9: Enterprise Architecture & Continuous Mastery (Weeks 42–44+)
----------------------------------------------------------------------
Goal: Operate as a senior/principal architect — leading platform strategy,
      governance, FinOps, sustainability, and architectural community at an
      organization level.

Difficulty: Expert

Prerequisites: Phases 1–8 + at least one real-world architecture engagement.

Time Commitment: Ongoing (~6–8 hrs/week of deliberate practice + reading).

Key Topics:
- Enterprise Architecture frameworks: TOGAF 10 (2022 release, still current), basics of Zachman and ArchiMate notation.
- Multi-cloud governance: AWS and GCP equivalents to core Azure services (mental mapping), abstraction layers (Crossplane, Pulumi).
- FinOps: FinOps Framework 2025 (FinOps Foundation), unit economics, showback/chargeback models, Azure Cost Management + Anomaly Detection.
- Sustainability: Microsoft Cloud for Sustainability, Azure Carbon Optimization, Well-Architected Sustainability pillar.
- Platform engineering: Internal Developer Platforms (IDPs), Backstage on Azure, golden paths, paved roads.
- Leadership: writing RFCs, running architecture review boards (ARBs), mentoring engineers, communicating with executives.

Architect Skills:
- Constructing reference architectures and pattern libraries for an organization.
- Building a Cloud Centre of Excellence (CCoE) operating model.
- Articulating cloud value in business terms (TCO, time-to-market, optionality).
- Continuous-learning discipline: monthly Microsoft Build / Ignite recap; quarterly WAF reviews of owned systems.

Target Certification:
- TOGAF 10 Foundation (and optionally TOGAF 10 Practitioner).
- Microsoft Applied Skills: "Configure secure access to your workloads using Azure networking" + "Develop generative AI solutions with Azure OpenAI Service" (rapid micro-credentials to stay current).
- Annual renewal assessments for AZ-104, AZ-305, AZ-400, AZ-500 (Microsoft certs expire yearly — free renewal on Microsoft Learn).

Small Project:
- Publish an internal "Architecture Decision Record" template and write three real ADRs against decisions you've made in Phases 1–8.

Medium Project:
- Run a FinOps exercise on a real Azure subscription: collect 90 days of cost data, identify the top 5 waste sources, implement tagging + budgets + autoscaling fixes, and publish a before/after savings report.

Ambitious Project:
- Design and pitch a 12-month Cloud Centre of Excellence (CCoE) roadmap for a fictional 500-engineer organization: operating model, landing-zone strategy, golden paths via a Backstage portal, FinOps + security guardrails, training plan, and KPIs.

Resources:
- TOGAF 10 Foundation study guide (The Open Group).
- FinOps Foundation — FinOps Framework (free, current 2025 release).
- Microsoft Learn: Cloud Adoption Framework + Well-Architected Framework (re-read annually).
- Book: "Fundamentals of Software Architecture" (Richards & Ford).
- Podcasts: "Azure Friday", "The Azure Podcast", "Cloud Engineering Archives".

Notes:
- After Phase 9, growth is non-linear and driven by real engagements. Aim to lead at least one greenfield landing-zone build and one major migration in your first 18 months as an architect.
- Re-validate this curriculum every 6 months — Azure ships at high velocity (AKS releases ~quarterly, Fabric and AI Foundry monthly).

======================================================================
