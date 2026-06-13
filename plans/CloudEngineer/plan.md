======================================================================
AZURE CLOUD ENGINEER CURRICULUM FOR .NET DEVELOPERS (28-WEEK BLUEPRINT)
======================================================================

A focused, hands-on path that converts 3+ years of .NET backend experience into a
production-ready Azure Cloud Engineer / DevOps Engineer. Five phases, current
Microsoft and HashiCorp certifications, and three escalating projects per phase
(small / medium / ambitious). All technologies verified current as of June 2026.

----------------------------------------------------------------------
PHASE 1: Azure Administration & Core Infrastructure (Weeks 1–8)
----------------------------------------------------------------------
Goal: Stop writing application code in isolation — start operating, securing, and
      networking enterprise-grade Azure infrastructure.

Difficulty: Intermediate

Prerequisites: 3+ years of .NET backend experience; basic familiarity with the
Azure portal, resource groups, and command-line tools (Azure CLI or PowerShell).

Time Commitment: ~10–12 hrs/week

Key Topics:
- Identity: Microsoft Entra ID (formerly Azure AD), Conditional Access, Managed Identities, Privileged Identity Management (PIM).
- RBAC & Governance: Built-in vs custom roles, Azure Policy, Management Groups, Resource Locks, Cost Management with budget alerts.
- Networking: Virtual Networks, Subnets, NSGs, Application Security Groups, Azure Virtual Network Manager (centralized hub-spoke).
- Connectivity: Azure Bastion, Private Endpoints, Private Link, VPN Gateway, VNet peering.
- Storage: Storage Accounts (Blob / Files / Queues / Tables), lifecycle policies, immutability, customer-managed keys via Key Vault.
- Compute: Virtual Machines, VM Scale Sets, Availability Zones, Azure Backup, Azure Site Recovery basics.

Architect Skills:
- Hub-and-spoke vs Virtual WAN trade-off reasoning for enterprise topologies.
- Choosing between Public IP, Private Endpoint, and Service Endpoint for PaaS access.
- Designing tag taxonomies and a management-group hierarchy that scales.

Target Certification:
- Microsoft Certified: Azure Administrator Associate (AZ-104)

Small Project:
- Deploy a hardened Linux/Windows VM accessed only via Azure Bastion, with NSG flow logs streamed to Log Analytics and zero public IP exposure.

Medium Project:
- Build a hub-spoke topology (1 hub + 2 spoke VNets) with Azure Firewall, forced tunnelling, and Private DNS zones for Key Vault and Storage Accounts.

Ambitious Project:
- Deploy a multi-region active-passive workload (Sweden Central + West Europe) with paired GZRS storage, Azure Site Recovery, and a documented DR runbook proven by a real failover exercise.

Resources:
- Microsoft Learn AZ-104 learning path (2026 edition).
- Book: "Exam Ref AZ-104 Microsoft Azure Administrator" (latest edition).
- Microsoft Cloud Adoption Framework — Govern + Secure methodologies.

Notes:
- Use a personal pay-as-you-go subscription with a hard budget alert — the free tier doesn't cover Bastion or Azure Firewall.

----------------------------------------------------------------------
PHASE 2: Cloud Development & Serverless Integration (Weeks 9–14)
----------------------------------------------------------------------
Goal: Connect your .NET 10 skills directly to cloud-native, event-driven Azure
      architectures, using Managed Identity for every secret.

Difficulty: Intermediate

Prerequisites: Phase 1 complete or in progress. Comfortable with ASP.NET Core,
async/await, and dependency injection.

Time Commitment: ~10–12 hrs/week

Key Topics:
- Runtime: .NET 10 LTS (Nov 2025 release), minimal APIs, native AOT for cold-start-sensitive workloads.
- Cloud-native .NET: .NET Aspire 9+ for local orchestration, service discovery, and OpenTelemetry wiring.
- PaaS: Azure App Service (Premium v4), deployment slots, auto-heal, App Service Environment v3.
- Serverless: Azure Functions on the isolated worker model (Flex Consumption plan for elastic concurrency).
- Messaging: Azure Service Bus (topics, sessions, dead-lettering), Event Grid, Event Hubs.
- Data: Cosmos DB (NoSQL + vCore), Azure SQL Hyperscale, Azure Cache for Redis Enterprise.
- Secrets & Config: Key Vault references in App Service / Functions, App Configuration with feature flags, system-assigned and user-assigned Managed Identities.

Architect Skills:
- Selecting between App Service, Azure Container Apps, Functions, and AKS for a given workload's scale + cost shape.
- Designing idempotent message handlers and the outbox pattern for at-least-once delivery.
- Cosmos DB partition-key design and RU/s capacity planning.

Target Certification:
- Microsoft Certified: Azure Developer Associate (AZ-204)

Small Project:
- Build a .NET 10 minimal API on App Service that pulls every connection string from Key Vault via system-assigned Managed Identity — zero secrets in app settings.

Medium Project:
- Implement an Azure Functions + Service Bus + Cosmos DB order-processing pipeline using the outbox pattern, exporting OpenTelemetry traces to Application Insights.

Ambitious Project:
- Ship a multi-tenant SaaS API built with .NET Aspire: App Service deployment slots for blue/green, Cosmos DB with per-tenant partition keys, and Azure Front Door + WAF as the global ingress.

Resources:
- Microsoft Learn AZ-204 learning path (2026 edition).
- .NET Aspire docs + the official eShopOnContainers Aspire reference app.
- Book: "Cloud Native Patterns" (Cornelia Davis).

----------------------------------------------------------------------
PHASE 3: Infrastructure as Code & Automation (Weeks 15–18)
----------------------------------------------------------------------
Goal: Provision and evolve every Azure resource declaratively, with peer review,
      automated validation, and state-locked pipelines — no more portal clicks.

Difficulty: Advanced

Prerequisites: Phases 1–2; comfortable with Git branching strategies.

Time Commitment: ~10 hrs/week

Key Topics:
- Bicep: Modules, loops, conditionals, decorators, `what-if` deployments, Bicep registry.
- Azure Verified Modules (AVM): Microsoft-supported Bicep + Terraform modules — the new enterprise baseline.
- Terraform 1.10+: Providers, remote state in Azure Storage with state locking, workspaces, OpenTofu compatibility.
- IaC pipelines: `terraform fmt/validate/plan/apply` gated on PRs; Bicep linting + what-if in CI.
- Secrets handling in IaC: Federated Workload Identity (OIDC) to GitHub Actions / Azure DevOps — no long-lived service principal secrets.
- Drift detection and remediation patterns (Azure Policy + scheduled `plan` runs).

Architect Skills:
- Selecting between Bicep and Terraform based on team skillset, multi-cloud reach, and module ecosystem.
- Designing a module library with semantic versioning and contract tests.
- Reasoning about state-file blast radius and per-environment isolation.

Target Certification:
- HashiCorp Certified: Terraform Associate (003)

Small Project:
- Convert a single resource group (web app + storage + key vault) from portal-created to a Bicep template deployed via `az deployment group create`.

Medium Project:
- Refactor the Phase 1 hub-spoke topology into a reusable Terraform module pulling from Azure Verified Modules, with a CI pipeline running fmt / validate / tflint / checkov on every PR.

Ambitious Project:
- Build a "platform module library" (Bicep AND Terraform) for landing-zone-grade resources (VNet, AKS, Key Vault, ACR) with semantic-versioned releases, contract tests via Terratest or Pester, and a GitHub Actions workflow publishing to a private registry.

Resources:
- HashiCorp Learn — Terraform Associate (003) study path.
- Microsoft Learn: "Fundamentals of Bicep" + Azure Verified Modules docs.
- Book: "Terraform: Up & Running" 3rd edition (Brikman).

----------------------------------------------------------------------
PHASE 4: Containerization & Modern Cloud Hosting (Weeks 19–24)
----------------------------------------------------------------------
Goal: Run .NET workloads in containers the way modern enterprise platforms do —
      with signed images, managed Kubernetes, and a secured supply chain.

Difficulty: Advanced

Prerequisites: Phases 1–3; comfortable with Linux shell and basic networking
(CIDR, DNS, TLS).

Time Commitment: ~12–15 hrs/week

Key Topics:
- Containers: Docker, multi-stage Dockerfiles for .NET, distroless / chiselled Ubuntu .NET images, SBOM generation.
- Registry: Azure Container Registry (Premium SKU), image signing with Notation/Cosign, vulnerability scanning via Microsoft Defender for Containers.
- Lightweight hosting: Azure Container Apps (KEDA-based autoscaling, Dapr building blocks for pub/sub and state).
- AKS Automatic (GA): Microsoft's recommended managed mode — production-ready defaults, automatic node management, Karpenter-based scaling.
- AKS Standard: Node pools, taints/tolerations, Cluster Autoscaler, Azure CNI Overlay, Cilium dataplane.
- Workload Identity: Federated Entra ID identities for pods (replaces deprecated pod-managed identities).
- Service mesh: Istio add-on for AKS, mTLS, traffic shifting for canary deploys.

Architect Skills:
- Azure Container Apps vs AKS Automatic vs AKS Standard selection criteria (cost, control, scale).
- Designing zero-downtime deployment topologies (canary, blue/green, traffic shadowing).
- Container-image supply-chain hygiene: base-image refresh cadence, SBOM scanning, signed-image admission policies.

Target Certification:
- Certified Kubernetes Administrator (CKA) — Kubernetes v1.32+ exam.

Small Project:
- Containerize a .NET 10 API with a multi-stage chiselled Ubuntu image, push it to ACR, and sign the image with Notation.

Medium Project:
- Deploy a 3-service microservice app to Azure Container Apps using Dapr pub/sub (Service Bus) and Dapr state (Cosmos DB), with KEDA scaling rules driven by queue depth.

Ambitious Project:
- Stand up an AKS Automatic cluster with Workload Identity, Istio mTLS, Karpenter-driven scaling, an NGINX or Istio ingress, and a horizontally-scaling .NET service — all provisioned by the Terraform modules from Phase 3.

Resources:
- Linux Foundation CKA prep course (kubernetes.io official).
- Microsoft Learn: "Introduction to AKS Automatic".
- Book: "Kubernetes Patterns" 2nd edition (Ibryam & Huss).

----------------------------------------------------------------------
PHASE 5: CI/CD, DevOps & Observability (Weeks 25–28)
----------------------------------------------------------------------
Goal: Tie infrastructure, application, and supply-chain together into automated,
      observable, production-grade delivery pipelines.

Difficulty: Advanced

Prerequisites: Phases 1–4 (especially IaC and Kubernetes).

Time Commitment: ~10 hrs/week

Key Topics:
- Pipelines: GitHub Actions (current default) and Azure DevOps Pipelines (still ubiquitous in enterprises).
- Supply-chain security: GitHub Advanced Security for Azure DevOps (GA), CodeQL, Dependabot, secret scanning, SLSA provenance attestations.
- Developer experience: Microsoft Dev Box, GitHub Codespaces, GitHub Copilot for DevOps (PR summaries, workflow generation, failure triage).
- IaC pipelines: `terraform plan` → manual approval → `apply` with OIDC federated workload identity; Bicep what-if gates.
- Application pipelines: `dotnet test`, container build, Cosign signing, push to ACR, deploy to AKS via Helm or Argo Rollouts.
- Observability: OpenTelemetry SDK + Collector, Azure Monitor, Application Insights, Log Analytics, Azure Managed Grafana, Azure Managed Prometheus.
- Reliability practice: SLI/SLO definition, error budgets, runbooks, basic chaos engineering with Azure Chaos Studio.

Architect Skills:
- Choosing a branching + environment promotion strategy (trunk-based vs GitFlow vs release branches) per team maturity.
- Defining SLIs/SLOs that map to real user pain (latency p99, availability, freshness) — not vanity metrics.
- Cost-aware observability: sampling strategies, log tier choices, metric cardinality control.

Target Certification:
- Microsoft Certified: DevOps Engineer Expert (AZ-400)
  (Prerequisite satisfied by your AZ-104 or AZ-204 from earlier phases.)

Small Project:
- Build a GitHub Actions workflow that runs `dotnet test`, builds a container, signs it with Cosign, and pushes to ACR — gated on a passing CodeQL scan.

Medium Project:
- Wire up a full IaC + app pipeline: PRs run `terraform plan` and Bicep what-if; merges to `main` do a canary deploy to AKS via Argo Rollouts with automatic rollback on SLO breach.

Ambitious Project:
- Deliver an end-to-end production-grade platform: blue/green deploys across two AKS regions fronted by Azure Front Door, OpenTelemetry traces and metrics flowing to Managed Prometheus + Grafana SLO dashboards, nightly Chaos Studio fault injections, and a published incident-response runbook with on-call rotation.

Resources:
- Microsoft Learn AZ-400 learning path (2026 edition).
- Book: "Site Reliability Engineering" (Google) + "The SRE Workbook".
- GitHub: "GitHub Well-Architected" guidance.

Notes:
- After AZ-400 you qualify for the "DevOps Engineer Expert" badge — combined with the prior associate certs this is the conventional bar for senior cloud engineering roles. Continue with the AZ-305 (Solutions Architect Expert) path if you want to move from engineer to architect.

======================================================================
