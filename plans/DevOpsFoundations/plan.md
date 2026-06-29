======================================================================
DEVOPS FOUNDATIONS: LINUX, DOCKER & CORE TOOLING (20-WEEK BLUEPRINT)
======================================================================

The prerequisite curriculum every aspiring cloud engineer, SRE, or platform
engineer needs before tackling Kubernetes or cloud-architecture tracks. Covers
Linux administration, shell + scripting, networking, Git, Docker / Compose, and
the core open-source DevOps toolchain (Make, Ansible, Vault, CI/CD, monitoring
basics). All technologies verified current as of June 2026.

----------------------------------------------------------------------
PHASE 1: Linux Administration Fundamentals (Weeks 1–4)
----------------------------------------------------------------------
Goal: Be fluent on a Linux server — filesystem, permissions, processes,
      packages, systemd, and basic troubleshooting — without reaching for a GUI.

Difficulty: Beginner

Prerequisites: Comfortable opening a terminal; no prior Linux experience required.
Windows users should install WSL 2 (Ubuntu 24.04 LTS) and use it as a daily
driver for this phase.

Time Commitment: ~8–10 hrs/week

Key Topics:
- Distributions: Ubuntu 24.04 LTS (default for cloud), RHEL 9 / Rocky / Alma (enterprise), Debian.
- Filesystem hierarchy: /etc, /var, /usr, /home, /opt — and what belongs where.
- Permissions: chmod / chown, octal vs symbolic, umask, setuid / setgid / sticky, ACLs, attr flags.
- Process management: ps, top, htop, btop, kill / killall, nice / renice, foreground / background jobs.
- Package management: apt, dnf, snap, flatpak — and when to use each (or none).
- Service management: systemd units, journalctl, timers (cron replacement), socket activation.
- Users, groups, sudoers, SSH key-based auth, ssh-agent, ~/.ssh/config.
- Disk + filesystem: lsblk, df / du, mount, fstab, LVM basics, ext4 vs xfs.
- Logging: journalctl, /var/log, log rotation with logrotate.

Topic Projects:
- (Distributions) Install Ubuntu 24.04 LTS in WSL 2 and on a cloud VM; compare package availability across `apt` vs `dnf`; document which distribution is appropriate for a web server, database server, and container host.
- (Filesystem hierarchy) Write a script that audits a system for configuration files placed in non-standard FHS locations and outputs a remediation report.
- (Permissions) Set up a web server directory with correct ownership, the setgid bit, and ACLs for a 3-person development team; verify with `getfacl` and a second-user write test.
- (Process management) Use htop and btop to diagnose a simulated runaway CPU process; document the detection-to-termination steps and a post-mortem analysis.
- (Package management) Install the same tool via apt, snap, and flatpak; compare installed paths, isolation level, and auto-update behaviour; document when to prefer each.
- (Service management) Convert a manually-started shell script into a proper systemd unit with dependency ordering, restart-on-failure, and journald logging; verify it survives a reboot.
- (Users, groups, sudoers, SSH) Harden a fresh VM: create a non-root sudo user, disable password authentication, configure SSH key-only login on a non-default port, and install fail2ban.
- (Disk + filesystem) Add a 10 GB virtual disk to a running VM using LVM; create a PV, VG, and LV; format as ext4; add to fstab; verify automatic remounting after reboot.
- (Logging) Configure centralised log forwarding from a VM using Promtail to Loki; run a structured query with journalctl filters for a specific systemd unit over the past 24 hours.

Architect Skills:
- Reading man pages and `--help` output fluently — refusing to copy-paste blindly from Stack Overflow.
- Reasoning about idempotency and side-effects in admin operations.
- Diagnosing "the disk is full" vs "the inodes are full".

Target Certification:
- Linux Foundation Certified IT Associate (LFCA) — entry-level.
- Stretch goal: Linux Foundation Certified System Administrator (LFCS).

Small Project:
- Provision a fresh Ubuntu 24.04 VM (Multipass, Hyper-V, or a $5 cloud droplet), harden SSH (key-only, non-default port, fail2ban), create a non-root sudo user, and document every change in a `setup.md`.

Medium Project:
- Install and run a self-hosted web service (e.g. Gitea or Nextcloud) under a dedicated system user, behind an nginx reverse proxy with Let's Encrypt TLS via certbot — managed entirely by systemd units.

Ambitious Project:
- Build a 3-VM mini-datacenter (1 NGINX gateway + 2 app servers) on a single hypervisor: shared NFS storage, centralised journald log forwarding, systemd-timer-based backups to S3-compatible storage (MinIO or Backblaze), and a one-page runbook for "what to do when each VM dies".

Resources:
- "The Linux Command Line" (William Shotts) — free PDF, the canonical primer.
- Linux Journey (linuxjourney.com) — interactive lessons.
- man-pages-en + `tldr` CLI for quick lookups.

----------------------------------------------------------------------
PHASE 2: Shell Scripting, Networking & Text Processing (Weeks 5–8)
----------------------------------------------------------------------
Goal: Automate routine work with shell scripts and diagnose networking problems
      from the command line confidently.

Difficulty: Intermediate

Prerequisites: Phase 1.

Time Commitment: ~8–10 hrs/week

Key Topics:
- Bash scripting: variables, quoting rules, `set -euo pipefail`, exit codes, traps, here-docs.
- Text processing: grep / egrep / ripgrep, sed, awk, cut, sort, uniq, jq (JSON), yq (YAML), xargs.
- Pipelines and process substitution; subshells vs source vs exec.
- ShellCheck for linting; `bats-core` for testing bash scripts.
- Networking: OSI quick refresher, IP / CIDR, TCP vs UDP, DNS resolution path (resolv.conf, systemd-resolved).
- Diagnostic tools: ping, traceroute / mtr, dig / nslookup, ss / netstat, tcpdump, iptables / nftables basics, curl with timing flags.
- TLS: openssl s_client, certificate chains, SNI, mTLS basics.
- HTTP debugging: curl, httpie, basic understanding of HTTP/2 and HTTP/3 (QUIC).

Topic Projects:
- (Bash scripting) Write a deployment script (`set -euo pipefail`) that copies a binary to a server, runs a health check endpoint, and rolls back automatically on failure; validate it with ShellCheck.
- (Text processing) Write a one-liner using grep, awk, sort, and uniq to extract the top-10 most frequent IP addresses from an nginx access log file with a million entries.
- (Pipelines and process substitution) Parallelise 5 independent download tasks using background jobs and `wait`; compare wall-clock time vs. the sequential version.
- (Networking) Use `ip`, `ss`, `dig`, and `mtr` to diagnose a simulated "service unreachable" scenario (wrong DNS, firewall block, or port mismatch); document the diagnostic decision tree.
- (Diagnostic tools) Capture a tcpdump trace of a full HTTPS handshake; identify the ClientHello, ServerHello, and certificate exchange packets in the capture.
- (TLS) Use `openssl s_client` to verify the certificate chain, expiry date, and cipher suite of 3 different HTTPS endpoints; document any configuration issues found.
- (HTTP debugging) Benchmark an HTTP endpoint using curl's timing breakdown flags (DNS, connect, TLS, TTFB, transfer); identify and document the slowest phase for 3 different servers.

Architect Skills:
- Knowing when bash is the right tool vs reaching for Python / Go.
- Defensive scripting (`set -euo pipefail`, IFS, explicit `--`).
- Reading a tcpdump capture well enough to identify "who hung up first".

Target Certification:
- No single cert. Recommended micro-credentials:
  - Linux Foundation "Intro to Bash Scripting" course completion.
  - Optional: CompTIA Network+ if you have zero networking background.

Small Project:
- Write a bash script that backs up a directory, rotates 7 daily archives, and pushes a daily summary to a webhook (Slack / Teams / Discord) — passing ShellCheck cleanly.

Medium Project:
- Write a `health-check.sh` script that probes a list of HTTPS endpoints in parallel using `xargs -P`, validates TLS expiry, status code, and response time, and outputs JSON consumable by `jq`. Cover it with `bats-core` tests.

Ambitious Project:
- Build `netdoctor` — a single bash + jq script that takes a hostname and produces a one-page diagnostic: DNS resolution chain, traceroute, TLS cert details, HTTP timing breakdown (DNS / connect / TLS / TTFB / download), and an opinionated verdict ("DNS slow", "TLS handshake slow", etc.). Package it as a `.deb` installable on Ubuntu.

Resources:
- "The Bash Hackers Wiki" (wiki.bash-hackers.org).
- Book: "Effective Shell" (Dave Kerr) — modern, free online.
- "Unix and Linux System Administration Handbook" 5th edition (Nemeth et al.) — chapters on networking.

----------------------------------------------------------------------
PHASE 3: Git, GitHub Workflows & Collaboration (Weeks 9–11)
----------------------------------------------------------------------
Goal: Use Git with confidence beyond the happy path — rebase, bisect, recover
      from disasters — and run a healthy code-review workflow on GitHub.

Difficulty: Intermediate

Prerequisites: Phases 1–2.

Time Commitment: ~6–8 hrs/week

Key Topics:
- Git internals: the object model (blob / tree / commit / tag), refs, reflog, the index.
- Daily workflow: branch / commit / push / pull / merge / rebase, fast-forward vs three-way merge.
- Advanced: interactive rebase, cherry-pick, bisect, worktrees, sparse checkout, submodules vs subtrees.
- Recovery: reflog, `git reset` (soft / mixed / hard), `git restore`, `git revert` vs reset, recovering "lost" commits.
- Hooks: pre-commit framework, conventional commits, commit signing with GPG / SSH / Sigstore.
- GitHub: pull requests, code review, branch protection, required checks, CODEOWNERS, GitHub Actions intro.
- Trunk-based development vs GitFlow vs release branches.
- Open source contribution etiquette: fork, PR description, DCO, semantic versioning, changelogs.

Topic Projects:
- (Git internals) Use `git cat-file` and `git ls-tree` to inspect the object store of a repository; draw the full object graph for a 3-commit history showing blobs, trees, and commits.
- (Daily workflow) Practise a rebase-based workflow: create a feature branch with 3 commits, rebase interactively onto an updated main, squash into 1 clean commit, and push with `--force-with-lease`.
- (Advanced Git) Use `git bisect run` to automatically find the commit that introduced a test failure in a 50-commit test repository; document the bisect session steps.
- (Recovery) Simulate and recover from three disaster scenarios: accidental `git reset --hard`, a deleted branch, and a force-pushed remote — using only `git reflog` and `git fsck`.
- (Hooks) Set up the pre-commit framework on a repository with hooks for ShellCheck, markdownlint, and conventional-commit title validation; verify each hook triggers on a matching violation.
- (GitHub) Configure branch protection on a repository requiring 2 approvals, passing CI, and signed commits; demonstrate a PR being blocked by each rule individually.
- (Trunk-based development) Convert an existing project with a long-lived feature branch to trunk-based development with feature flags; document the migration process and the safest merge cadence.
- (Open source contribution) Submit a pull request to a real open-source project; document the process from fork through merge including how you addressed reviewer feedback.

Architect Skills:
- Designing a branching + release strategy that matches team size and release cadence.
- Writing commit messages and PR descriptions that future-you can read in two years.
- Recovering a screwed-up repo without losing work.

Target Certification:
- GitHub Certifications: GitHub Foundations and GitHub Actions (both current, vendor-recognised).

Small Project:
- Take an existing personal project, rewrite its history into clean conventional commits using interactive rebase, sign all commits, and publish to GitHub with branch protection + required CI checks.

Medium Project:
- Contribute one merged pull request to a real open-source project (typo fix, doc improvement, or small bug fix counts) — following their CONTRIBUTING.md from fork to merge.

Ambitious Project:
- Build and publish a reusable GitHub Action (in TypeScript or composite YAML) that performs a useful task (e.g. validates conventional-commit titles + auto-labels PRs by size), with full README, automated tests via GitHub Actions, semantic-version tags, and a published listing on the GitHub Marketplace.

Resources:
- "Pro Git" book (git-scm.com/book) — free, the definitive reference.
- "Oh My Git!" interactive game for branching/merging practice.
- GitHub Skills (skills.github.com) — official interactive courses.

----------------------------------------------------------------------
PHASE 4: Docker & Docker Compose (Weeks 12–15)
----------------------------------------------------------------------
Goal: Build optimized, secure container images and orchestrate multi-service
      local development environments with Docker Compose v2.

Difficulty: Intermediate

Prerequisites: Phases 1–3.

Time Commitment: ~10 hrs/week

Key Topics:
- Container concepts: namespaces, cgroups, OCI image + runtime spec, layers, the union filesystem.
- Docker Engine + Docker Desktop; rootless Docker; Podman as a daemonless alternative.
- Dockerfiles: layer ordering, build cache hits, ARG vs ENV, multi-stage builds, distroless / chiselled base images, non-root USER.
- BuildKit features: cache mounts, secrets at build time, multi-platform builds (linux/amd64 + linux/arm64) via buildx.
- Image hygiene: dive (layer inspection), Trivy / Grype (CVE scanning), Syft (SBOM), Cosign signing.
- Runtime: networks (bridge / host / overlay), volumes vs bind mounts, healthchecks, resource limits (--cpus, --memory), logging drivers.
- Docker Compose v2 (compose.yaml): services, depends_on with conditions, profiles, networks, secrets, watch mode for dev.
- Compose for development environments: hot-reload, debugger attachment, test execution.
- Registry: Docker Hub, GitHub Container Registry (ghcr.io), self-hosted (Harbor, distribution/registry).

Topic Projects:
- (Container concepts) Use `nsenter` and the `/sys/fs/cgroup` filesystem to inspect a running container's namespace isolation and resource limits directly on the host without entering the container.
- (Docker Engine) Run the same application in rootless Docker and standard Docker; compare network behaviour, file ownership inside the container, and the resulting security posture.
- (Dockerfiles) Optimise an existing Dockerfile by reordering layers to maximise BuildKit cache hits on a CI runner; measure and document the build time improvement.
- (BuildKit features) Build a multi-platform image (`linux/amd64` + `linux/arm64`) from a single Dockerfile using `docker buildx`; verify both platforms produce the correct output.
- (Image hygiene) Scan a chosen base image with Trivy; patch all HIGH/CRITICAL CVEs by upgrading the base image or pinning affected packages; re-scan and confirm a clean result.
- (Runtime) Apply CPU and memory limits to a running container; use `docker stats` to confirm enforcement under an artificial load generator (`stress-ng`).
- (Docker Compose v2) Add `watch` mode configuration to a Compose stack so that source-code changes in the API service trigger a live container update without a full restart.
- (Compose for development) Create a `make dev` target that spins up the full stack, seeds a Postgres database, and attaches a debugger to the backend service.
- (Registry) Set up a self-hosted Harbor registry; push an image; scan it with Harbor's built-in Trivy integration; configure a policy to block images with CRITICAL CVEs from being pulled.

Architect Skills:
- Choosing between Docker, Podman, and nerdctl based on platform and security posture.
- Designing slim, single-process, non-root container images that pass a security scan.
- Reasoning about build cache invalidation to make CI builds fast.

Target Certification:
- Docker Certified Associate (DCA) — still the canonical container cert (renewed 2025).
- Stretch: Sigstore / SLSA practitioner-style courses (no exam, but well-respected portfolio items).

Small Project:
- Containerize an existing personal app (any language) with a multi-stage Dockerfile that produces a sub-50 MB image running as non-root, scanned clean by Trivy.

Medium Project:
- Build a `compose.yaml` for a 4-service local dev stack: web frontend, backend API, Postgres, and Redis — with healthchecks, volume persistence, Compose `watch` mode for live reload, and a `make dev` / `make test` / `make down` developer workflow.

Ambitious Project:
- Ship a production-grade multi-arch container pipeline: `docker buildx` building linux/amd64 + linux/arm64 from a single Dockerfile, SBOM attached via Syft, image signed with Cosign keyless (OIDC), pushed to ghcr.io with automatic CVE scanning on every PR, and a documented "image promotion" flow (dev → prod tags).

Resources:
- Docker official docs (docs.docker.com) — the build / compose / engine sections.
- Book: "Docker Deep Dive" (Nigel Poulton, latest edition).
- "Container Security" by Liz Rice (O'Reilly) — short, dense, excellent.

----------------------------------------------------------------------
PHASE 5: Core DevOps Toolchain & CI/CD Basics (Weeks 16–20)
----------------------------------------------------------------------
Goal: Wire Git, build tools, configuration management, secrets, and monitoring
      into a coherent automated delivery pipeline you can defend in a review.

Difficulty: Advanced

Prerequisites: Phases 1–4.

Time Commitment: ~10 hrs/week

Key Topics:
- Build orchestration: Make (still ubiquitous), Just (modern Make alternative), Task (YAML-based).
- Configuration management: Ansible (current default for VM-era config), idempotent playbooks, roles, Ansible Vault, Molecule for role testing.
- Secrets management: HashiCorp Vault (open source) — KV engine, dynamic database creds, AppRole + JWT auth methods.
- CI/CD platforms: GitHub Actions (default for new projects), GitLab CI, Jenkins (only for legacy maintenance).
- Pipeline design: matrix builds, reusable workflows, composite actions, OIDC to cloud providers (no static cloud secrets in CI).
- Artefact + registry management: ghcr.io, Artifactory, container image signing in the pipeline.
- Quality gates: linting (ShellCheck, hadolint, markdownlint), unit tests, mutation tests, dependency scanning (Dependabot, Renovate), CodeQL static analysis.
- Monitoring & observability basics: Prometheus + Grafana on a VM, node_exporter, blackbox_exporter, Loki for logs, Alertmanager rules.
- Logging stacks: Loki+Promtail vs Elastic+Filebeat vs OpenSearch — the trade-offs.
- Infrastructure cost awareness: tagging, budget alerts, FinOps basics (carries forward to cloud phases).

Topic Projects:
- (Build orchestration) Write a `Makefile` with phased targets (lint, test, build, deploy) where each stage caches its output and only re-runs when its inputs change.
- (Configuration management) Write an Ansible role that installs and configures nginx with TLS on Ubuntu 24.04; test it with Molecule against a Docker container and verify idempotency on re-run.
- (Secrets management) Deploy HashiCorp Vault in dev mode; store a database credential in the KV engine; retrieve it from a shell script using AppRole authentication via the Vault CLI.
- (CI/CD platforms) Migrate a Jenkins pipeline to an equivalent GitHub Actions workflow; document capability gaps and improvements observed during the migration.
- (Pipeline design) Implement OIDC-based GitHub Actions authentication to Azure without any static service principal secrets; verify by deploying a resource and checking the Azure audit log.
- (Artefact management) Configure Renovate to automatically open PRs for out-of-date dependencies in a repository; triage and merge the first 5 automated dependency update PRs.
- (Quality gates) Add a mutation testing step (Stryker for .NET or mutmut for Python) to a CI pipeline; set a minimum mutation score threshold that fails the build if not met.
- (Monitoring & observability basics) Deploy Prometheus, Grafana, and node_exporter on a VM; create a dashboard showing node CPU, memory, and disk with an alert that fires on >80% disk usage.
- (Logging stacks) Deploy Loki + Promtail + Grafana; compare structured log query latency vs. an Elasticsearch + Filebeat stack on the same 10 GB log dataset; document the operational trade-offs.
- (Infrastructure cost awareness) Tag all resources in an Azure subscription by team and environment; create a Cost Management budget alert; produce a weekly cost-by-tag summary report.

Architect Skills:
- Designing a release pipeline that fails fast and gives engineers clear feedback within 10 minutes.
- Picking between Ansible, cloud-init, and immutable images for VM provisioning.
- Building dashboards that map directly to SLOs, not vanity metrics.

Target Certification:
- HashiCorp Certified: Vault Associate (002).
- Red Hat Certified Specialist in Ansible Automation (EX467) — optional, enterprise-flavoured.
- GitHub Actions certification (also listed in Phase 3 — earn it here if not done already).

Small Project:
- Write an Ansible playbook that takes a fresh Ubuntu 24.04 VM and turns it into the hardened Docker host from Phase 4 (Docker installed, non-root user added to docker group, ufw firewall configured, journald log shipping enabled) — idempotently.

Medium Project:
- Build a complete GitHub Actions pipeline for a real .NET / Go / Python app: matrix tests across OS + version, container build with BuildKit cache, Trivy scan, Cosign sign, push to ghcr.io, deploy to a remote Docker host via SSH + compose `up`, smoke test, and rollback on failure.

Ambitious Project:
- Stand up a "homelab platform": 3 Ubuntu VMs provisioned by Ansible, Docker Swarm OR a single-node k3s cluster, Vault for secrets, Prometheus + Grafana + Loki monitoring stack with SLO dashboards for 2 self-hosted services, Renovate auto-updating dependencies, and a GitHub Actions pipeline that deploys configuration changes via Ansible — all reproducible from a single `make bootstrap` command.

Resources:
- Book: "The DevOps Handbook" 2nd edition (Kim, Humble, Debois, Willis).
- Book: "Ansible for DevOps" (Jeff Geerling) — current edition.
- HashiCorp Learn — Vault Associate study path.
- Prometheus + Grafana official tutorials (prometheus.io / grafana.com).

Notes:
- This phase is the natural launchpad into the **Kubernetes** plan (Phase 1 of which assumes you already know Docker, Linux, and Git fluently), or into the **CloudEngineer** plan (Phase 1: Azure Administration, where Linux + SSH + IaC habits are assumed).

======================================================================
