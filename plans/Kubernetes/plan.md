======================================================================
KUBERNETES MASTERY CURRICULUM (24-WEEK BLUEPRINT)
======================================================================

A focused, vendor-neutral Kubernetes curriculum that takes a backend engineer
from "what is a pod?" to running secure, observable, production-grade clusters
and platforms. Five phases cover the full Linux Foundation cert ladder
(KCNA → CKAD → CKA → CKS) plus a final platform-engineering phase. All
technologies verified current as of June 2026 (Kubernetes v1.32+).

----------------------------------------------------------------------
PHASE 1: Kubernetes Fundamentals & Core Objects (Weeks 1–4)
----------------------------------------------------------------------
Goal: Understand the Kubernetes architecture, install a local cluster, and be
      fluent with the core workload + networking + storage objects.

Difficulty: Beginner

Prerequisites: Comfortable with Linux shell, Docker basics, YAML, and one
backend language (Go, Python, Java, or .NET).

Time Commitment: ~8–10 hrs/week

Key Topics:
- Architecture: control plane (kube-apiserver, etcd, scheduler, controller-manager) vs node components (kubelet, kube-proxy, container runtime).
- Container runtime: containerd (current default), CRI, OCI image spec.
- Local clusters: kind, minikube, k3d, Docker Desktop Kubernetes.
- Core objects: Pod, Deployment, ReplicaSet, StatefulSet, DaemonSet, Job, CronJob.
- Networking basics: ClusterIP / NodePort / LoadBalancer Services, kube-dns / CoreDNS, NetworkPolicy intro.
- Storage basics: Volumes, PersistentVolume, PersistentVolumeClaim, StorageClass.
- Configuration: ConfigMap, Secret (and why secrets are NOT really secret without encryption-at-rest).
- kubectl proficiency: imperative vs declarative, `kubectl explain`, `-o yaml --dry-run=client`, contexts.

Architect Skills:
- Pod-design trade-offs: sidecar vs ambient vs separate Deployment.
- StatefulSet vs Deployment decision tree.
- Reading the Kubernetes API reference and CRD specs without panic.

Target Certification:
- Kubernetes and Cloud Native Associate (KCNA) — Linux Foundation entry-level cert.

Small Project:
- Stand up a 3-node `kind` cluster locally, deploy NGINX as a Deployment + Service, and curl it from your host.

Medium Project:
- Build a multi-tier app on `kind`: a stateless API Deployment, a Redis StatefulSet with persistent storage, ConfigMap-driven configuration, and Secret-driven credentials — all written declaratively in YAML and version-controlled.

Ambitious Project:
- Replicate a small production-like workload locally: 3 microservices (Go or .NET), a Postgres StatefulSet, NGINX Ingress Controller, cert-manager with a self-signed issuer, and a `Makefile` that brings the whole thing up on `kind` in one command.

Resources:
- kubernetes.io official "Concepts" + "Tutorials" docs.
- KCNA study guide (Linux Foundation).
- Book: "Kubernetes Up & Running" 3rd edition (Burns, Beda, Hightower, Villalba).
- YouTube: TechWorld with Nana — Kubernetes crash course.

Notes:
- Resist the temptation to start on a managed cloud cluster. Local `kind` clusters teach you the API and let you break/fix things safely.

----------------------------------------------------------------------
PHASE 2: Application Development on Kubernetes (Weeks 5–9)
----------------------------------------------------------------------
Goal: Package, deploy, observe, and troubleshoot real applications on Kubernetes
      the way an application developer is expected to.

Difficulty: Intermediate

Prerequisites: Phase 1 complete. Comfortable writing Dockerfiles and reading
container logs.

Time Commitment: ~10 hrs/week

Key Topics:
- Pod design patterns: sidecar, ambassador, adapter, init containers.
- Probes: liveness, readiness, startup — and how they interact with rolling updates.
- Resource management: requests, limits, QoS classes, LimitRange, ResourceQuota.
- Configuration & secrets injection: env, volume mounts, projected volumes, External Secrets Operator (ESO).
- Multi-container patterns and the new (1.29+) sidecar containers (restartable init containers).
- Application networking: Services in depth, headless Services, EndpointSlices, Ingress, the Gateway API (GA in 1.32+).
- Persistent storage from an app perspective: dynamic provisioning, ReadWriteOncePod access mode.
- Packaging: Helm 3 (current), Kustomize overlays, Helm vs Kustomize trade-offs.
- Troubleshooting: `kubectl describe`, `kubectl logs --previous`, `kubectl debug` ephemeral containers, common CrashLoopBackOff causes.

Architect Skills:
- Choosing between Helm, Kustomize, and raw YAML for a given org maturity.
- Designing 12-Factor-compliant containerized apps.
- Reasoning about pod-disruption budgets (PDBs) for safe rolling deploys.

Target Certification:
- Certified Kubernetes Application Developer (CKAD) — Kubernetes v1.32+ exam.

Small Project:
- Write a Helm chart for a simple .NET / Go web API with configurable replicas, env vars, image tag, and a values file per environment (dev/prod).

Medium Project:
- Build a Kustomize-based GitOps repo for a 3-service microservice app with base + dev + staging + prod overlays, sealed-secrets for credentials, and a PR template enforcing chart-lint + `kubeval` checks.

Ambitious Project:
- Ship a production-realistic .NET 10 microservice (HTTP + background worker) with: proper readiness/liveness probes, PodDisruptionBudget, HorizontalPodAutoscaler driven by custom metrics (CPU + request-rate), Gateway API route, External Secrets Operator pulling from Azure Key Vault or HashiCorp Vault, and a structured-logging pipeline to Loki or OpenSearch.

Resources:
- CKAD study guide — killer.sh practice exams (included with cert).
- Book: "Kubernetes Patterns" 2nd edition (Ibryam & Huss).
- helm.sh docs + Bitnami chart library for reference.

----------------------------------------------------------------------
PHASE 3: Cluster Administration & Operations (Weeks 10–15)
----------------------------------------------------------------------
Goal: Install, upgrade, scale, troubleshoot, and recover real Kubernetes
      clusters — both managed (AKS / EKS / GKE) and self-managed.

Difficulty: Advanced

Prerequisites: Phases 1–2; comfortable with systemd, certificates (x509), and
basic networking (CIDR, iptables, DNS).

Time Commitment: ~12 hrs/week

Key Topics:
- Cluster bootstrap: kubeadm install on Linux VMs, certificate rotation, etcd backup + restore.
- Managed offerings: AKS Automatic (GA, recommended), AKS Standard, EKS, GKE Autopilot — what each abstracts and what it doesn't.
- Cluster upgrades: control plane and node-pool upgrade strategies, version skew policy, surge nodes.
- Networking deep dive: CNI plugins (Calico, Cilium with eBPF dataplane), IP-per-pod model, NetworkPolicy, Cilium ClusterMesh.
- Storage at scale: CSI drivers, snapshotting, volume expansion, topology-aware scheduling.
- Scheduling: node selectors, affinity/anti-affinity, taints/tolerations, topology spread constraints, Karpenter (cloud-native autoscaler) vs cluster-autoscaler.
- Observability for cluster operators: Metrics Server, Prometheus + Grafana stack, OpenTelemetry Collector, Loki for logs.
- Backup/DR: Velero, etcd snapshots, cross-region cluster recovery.

Architect Skills:
- Selecting between fully-managed (AKS Automatic, GKE Autopilot) and "give me the nodes" managed Kubernetes.
- Designing multi-AZ + multi-region cluster topologies for stated RPO/RTO.
- Capacity planning: pod density, kubelet limits, node-size trade-offs.

Target Certification:
- Certified Kubernetes Administrator (CKA) — Kubernetes v1.32+ exam.

Small Project:
- Use `kubeadm` to bootstrap a 1 control-plane + 2 worker-node cluster on three local VMs (Multipass / Vagrant / Hyper-V), then perform a control-plane upgrade by one minor version.

Medium Project:
- Stand up an AKS Automatic cluster via Terraform, install Cilium as the CNI with NetworkPolicy + Hubble observability, configure Karpenter for spot-instance scaling, and demonstrate a node-pool upgrade with zero downtime.

Ambitious Project:
- Build a multi-region active-active platform: two AKS clusters (different regions), Cilium ClusterMesh for cross-cluster service discovery, Velero scheduled backups to geo-redundant storage, a documented disaster-recovery runbook, and a chaos test (kill an entire cluster) that proves the runbook works.

Resources:
- Linux Foundation CKA prep course (kubernetes.io official).
- killer.sh CKA simulator (included with cert).
- Book: "Kubernetes the Hard Way" by Kelsey Hightower (free, GitHub) — do it once, by hand.
- Cilium docs + the "Cilium book" (free online).

----------------------------------------------------------------------
PHASE 4: Kubernetes Security (Weeks 16–20)
----------------------------------------------------------------------
Goal: Harden clusters, workloads, and the container supply chain against
      realistic attack scenarios.

Difficulty: Advanced

Prerequisites: Phases 1–3.

Time Commitment: ~10 hrs/week

Key Topics:
- Authentication & authorization: RBAC (Roles, ClusterRoles, bindings), ServiceAccounts, OIDC integration with Entra ID / Okta / Google, Workload Identity federation.
- Pod Security Standards (PSS): Privileged / Baseline / Restricted profiles; Pod Security Admission (replaces the deprecated PodSecurityPolicy).
- Policy as code: Kyverno (current go-to), OPA Gatekeeper, ValidatingAdmissionPolicy (built-in, GA in 1.30+).
- Runtime security: Falco for syscall-level detection, eBPF-based tooling (Tetragon).
- Supply chain: image signing with Cosign / Notation, SBOM generation (Syft), vulnerability scanning (Trivy, Grype), admission control for signed-only images.
- Network security: NetworkPolicy (Cilium L7-aware), service-mesh mTLS (Istio ambient mode, Linkerd).
- Secrets at rest: KMS-backed etcd encryption, External Secrets Operator with cloud KMS backends, Sealed Secrets, SOPS.
- Confidential computing: confidential containers (CoCo project), AKS confidential nodes, GKE Confidential GKE Nodes.

Architect Skills:
- Threat-modelling a Kubernetes cluster (STRIDE / MITRE ATT&CK for Containers).
- Designing a multi-tenant cluster boundary (namespaces + NetworkPolicy + Kyverno + ResourceQuota).
- Picking between OPA Gatekeeper, Kyverno, and built-in ValidatingAdmissionPolicy based on team Go fluency.

Target Certification:
- Certified Kubernetes Security Specialist (CKS) — Kubernetes v1.32+ exam.
  (Requires an active CKA certification.)

Small Project:
- Lock down a namespace with a baseline-restricted Pod Security Admission label, a default-deny NetworkPolicy, and a Kyverno policy that blocks any image not signed by a specific Cosign key.

Medium Project:
- Build a hardened multi-tenant cluster: per-tenant namespace with RBAC + ResourceQuota + LimitRange + Kyverno guardrails, Falco runtime detection alerting on suspicious syscalls, and Trivy scanning every image at admission time.

Ambitious Project:
- Stand up a "secure-by-default" platform: Istio ambient-mode mTLS, External Secrets Operator pulling from Azure Key Vault via Workload Identity, encrypted etcd (KMS-backed), Cosign-signed images enforced by Kyverno, Tetragon eBPF runtime monitoring exporting to a SIEM, and a documented threat model with mitigated/accepted-risk decisions.

Resources:
- CKS curriculum (Linux Foundation) + killer.sh simulator.
- Book: "Kubernetes Security and Observability" (Vohra & Patel, O'Reilly).
- NSA / CISA Kubernetes Hardening Guidance (latest revision).
- The "Kubernetes Goat" intentionally-vulnerable cluster for practice.

----------------------------------------------------------------------
PHASE 5: Production Operations, GitOps & Platform Engineering (Weeks 21–24+)
----------------------------------------------------------------------
Goal: Operate Kubernetes as a platform product — with GitOps delivery, SLO-driven
      reliability, cost discipline, and self-service developer experience.

Difficulty: Expert

Prerequisites: Phases 1–4.

Time Commitment: Ongoing (~8–10 hrs/week of deliberate practice + reading).

Key Topics:
- GitOps: Argo CD (most popular) and Flux v2 — apps-of-apps, ApplicationSets, multi-cluster fan-out, drift detection.
- Progressive delivery: Argo Rollouts, Flagger, canary + blue/green + experiment analysis tied to Prometheus metrics.
- Service mesh in depth: Istio (sidecar + ambient mode), Linkerd, mTLS, traffic shifting, fault injection.
- Observability stack: Prometheus + Thanos / Mimir for long-term metrics, Grafana, Loki, Tempo, OpenTelemetry as the convergence point.
- SRE practices: SLI / SLO / error-budget policy, burn-rate alerting, incident response, postmortem culture.
- Multi-tenancy patterns: vCluster (virtual clusters), Capsule, hierarchical namespaces.
- AI workloads on Kubernetes: KAITO (Azure), NVIDIA GPU Operator, Kueue for batch/AI job scheduling, KServe for model serving.
- Platform engineering: Internal Developer Platforms (IDPs), Backstage on Kubernetes, Crossplane / Cluster API for self-service infra, golden paths.
- FinOps for Kubernetes: OpenCost, KubeCost, right-sizing recommendations, spot-instance strategies.

Architect Skills:
- Defining the "platform contract" — what the platform team owns vs what app teams own.
- Designing GitOps repo topology (mono-repo vs poly-repo, env branching, promotion model).
- Building a measurable golden path (lead-time, deploy-frequency, MTTR, change-failure rate — DORA metrics).
- Articulating Kubernetes cost in business terms (cost per request, cost per tenant).

Target Certification:
- No single Linux Foundation cert for this phase. Recommended micro-credentials:
  - Certified Argo Project Associate (when GA) — currently in beta.
  - CNCF "Kubernetes and Cloud Native Security Associate" (KCSA) as a complement to CKS.
  - Vendor-specific: CKAD/CKA/CKS renewals every 2 years.

Small Project:
- Bootstrap an Argo CD installation that manages itself + one demo app from a Git repo, demonstrating drift detection by manually editing a Deployment and watching Argo revert it.

Medium Project:
- Build a GitOps platform: Argo CD ApplicationSets fanning out a single app to dev/staging/prod clusters, Argo Rollouts canary with Prometheus-based analysis, and a published runbook for promoting a release.

Ambitious Project:
- Deliver a full Internal Developer Platform: Backstage portal with software templates that generate a Git repo + Helm chart + Argo CD Application + Crossplane-provisioned cloud resources, Prometheus + Grafana SLO dashboards per service, OpenCost showback per namespace, and at least one self-service "deploy a new microservice" golden path that an app team can use end-to-end without platform-team involvement.

Resources:
- Argo CD docs + the "Argo CD in Practice" book (Manning).
- Book: "Platform Engineering on Kubernetes" (Mauricio Salatino, Manning).
- CNCF Landscape — re-read quarterly to track what's graduating / being deprecated.
- DORA "State of DevOps" annual report.
- Podcasts: Kubernetes Podcast from Google, PodCTL.

Notes:
- Beyond this phase, growth is driven by real production scars. Aim to be on-call for a non-trivial Kubernetes platform for at least 6 months before claiming "expert".
- Re-validate this curriculum every 6 months — Kubernetes ships three minor releases per year and the ecosystem moves even faster.

======================================================================
