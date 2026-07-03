======================================================================
LOW LEVEL SYSTEM DESIGN & HIGH LEVEL SYSTEM DESIGN (20-WEEK BLUEPRINT)
======================================================================

A seven-phase, beginner-to-expert roadmap that takes a software engineer from
OOP fundamentals and design patterns (LLD) through distributed-systems theory
and full-scale production system design (HLD), ready for FAANG/MAANG-style
design interviews and real-world architectural decisions. All technologies and
resources verified current as of July 2026.

----------------------------------------------------------------------
PHASE 1: OOP Fundamentals & Design Principles (Weeks 1–3)
----------------------------------------------------------------------
Goal: Model real-world problems confidently using OOP and document designs
      with UML diagrams.

Difficulty: Beginner

Prerequisites: Working knowledge of at least one OOP language (Java, Python, C#, C++, or Go).

Time Commitment: ~8 hrs/week

Key Topics:
- OOP Pillars: Classes, Objects, Enums, Interfaces, Encapsulation, Abstraction, Inheritance, Polymorphism.
- Class Relationships: Association, Aggregation, Composition, Dependency — when to use each and the differences.
- Design Principles: SOLID (Single Responsibility, Open/Closed, Liskov Substitution, Interface Segregation, Dependency Inversion), plus DRY, KISS, and YAGNI.
- UML Diagrams: Class diagrams, Use Case diagrams, Sequence diagrams, Activity diagrams, State Machine diagrams.

Topic Projects:
- (OOP Pillars) Model a university system with Student, Course, and Professor classes that demonstrates all four OOP pillars; draw the class diagram.
- (Class Relationships) Redesign the university model distinguishing Composition (Course owns Lecture) from Aggregation (Department aggregates Professor); document the reasoning.
- (Design Principles) Take a violating God-class User and refactor it to satisfy all five SOLID principles; write a before/after comparison.
- (UML) Draw a Sequence diagram for a customer placing an order in an e-commerce system, including payment-gateway interaction.

Architect Skills:
- Reading and drawing UML class and sequence diagrams for design review.
- Identifying SOLID violations in existing codebases and articulating the refactoring justification.

Small Project:
- Design and implement a Library Management System (books, members, loans) using all four OOP pillars and a UML class diagram.

Medium Project:
- Model a Task Management System (Jira-lite) with projects, epics, stories, users, and role-based permissions; include full UML and a concise ADR explaining key relationship choices.

Ambitious Project:
- Design a Plugin Framework where host applications can dynamically load and invoke plugins using Interfaces and Dependency Inversion to keep the host decoupled from plugin implementations.

Resources:
- "Head First Design Patterns" (Freeman & Robson) — Chapters 1–2 for OOP review.
- AlgoMaster LLD Course: OOP Fundamentals module (algomaster.io/learn/lld).
- Coursera: "Object-Oriented Design" by University of Alberta.
- UML tooling: draw.io or PlantUML for diagramming.

Notes:
- Practice in the language you interview in; Java, Python, C#, C++, and Go are all common in LLD interviews.

----------------------------------------------------------------------
PHASE 2: Design Patterns — Creational, Structural & Behavioral (Weeks 4–6)
----------------------------------------------------------------------
Goal: Recognise and apply all 23 GoF design patterns and know which pattern
      solves which class of problem.

Difficulty: Intermediate

Prerequisites: Phase 1 complete.

Time Commitment: ~10 hrs/week

Key Topics:
- Creational Patterns: Singleton, Factory Method, Abstract Factory, Builder, Prototype — controlling object creation and lifecycle.
- Structural Patterns: Adapter, Bridge, Composite, Decorator, Facade, Flyweight, Proxy — composing classes and objects.
- Behavioral Patterns: Observer, Strategy, Command, State, Template Method, Iterator, Visitor, Mediator, Memento, Chain of Responsibility — object interaction and algorithm encapsulation.
- Pattern Trade-offs: When NOT to apply a pattern; over-engineering vs under-engineering; recognising anti-patterns (God Object, Spaghetti Code, Golden Hammer).

Topic Projects:
- (Creational) Implement a cross-platform UI component factory using Abstract Factory; swap between Windows and macOS themes without changing client code.
- (Structural) Add logging to an existing class hierarchy without modifying source using Decorator; compare with the Proxy alternative.
- (Behavioral) Build a text editor undo/redo system using Command + Memento patterns.

Architect Skills:
- Pattern selection rationale: documenting why a pattern was chosen over alternatives in an ADR.
- Mapping anti-patterns to their pattern remedies during code review.

Small Project:
- Implement a Logging Framework (Log4j-lite) using Singleton, Chain of Responsibility, and Strategy patterns.

Medium Project:
- Build a Coffee Vending Machine that supports multiple drink configurations using Builder, State, and Strategy; include a full UML class diagram and walkthrough.

Ambitious Project:
- Design a Notification System (email, SMS, push) with pluggable providers using Abstract Factory + Observer; support dynamic subscription/unsubscription and delivery guarantees.

Resources:
- "Head First Design Patterns" (Freeman & Robson) — full book.
- "Design Patterns: Elements of Reusable Object-Oriented Software" (Gamma, Helm, Johnson, Vlissides) — reference.
- GitHub: ashishps1/awesome-low-level-design — design-patterns folder with Java/Python/C# examples.
- Refactoring.Guru — interactive pattern catalog with diagrams and code samples.

----------------------------------------------------------------------
PHASE 3: Low Level Design — Machine Coding & Core Problems (Weeks 7–9)
----------------------------------------------------------------------
Goal: Solve any easy-to-medium LLD interview problem end-to-end in 45 minutes,
      producing working code and a UML diagram.

Difficulty: Intermediate

Prerequisites: Phase 1 and Phase 2 complete.

Time Commitment: ~10 hrs/week

Key Topics:
- LLD Interview Methodology: Requirements clarification → entities & relationships → UML class diagram → implementation → thread-safety considerations.
- Core Interview Problems (Easy): Parking Lot, Vending Machine, Stack Overflow clone, Traffic Signal System, Task Management System.
- Core Interview Problems (Medium): LRU Cache, ATM, Elevator System, Hotel Management System, Library Management System, Pub-Sub System, LinkedIn-like social network.
- API Design: Designing clean, minimal, and extensible public APIs for your classes; avoiding leaky abstractions.

Topic Projects:
- (Easy LLD) Design a Parking Lot supporting multiple vehicle types, floors, and spot categories; handle spot allocation, ticketing, and payment calculation.
- (Medium LLD) Design an LRU Cache with O(1) get/put using HashMap + DoublyLinkedList; extend with TTL-based eviction.
- (Medium LLD) Design an Elevator System for an N-floor building with M elevators using the SCAN/LOOK scheduling algorithm.

Architect Skills:
- Estimating the number of classes, interfaces, and pattern touchpoints before writing code.
- Trade-off documentation: explaining why Composition was chosen over Inheritance for a specific relationship.

Small Project:
- Implement a fully working Parking Lot system with unit tests covering edge cases (full lot, invalid ticket, multi-vehicle types).

Medium Project:
- Design and implement an Online Auction System (eBay-lite) supporting bidding, bid history, auction expiry, and winner notification via the Observer pattern.

Ambitious Project:
- Design a Ride-Sharing Service (Uber-lite) at the class level: Driver, Rider, Trip, Matching Engine, Pricing, and Rating subsystems with full UML and working code.

Resources:
- GitHub: ashishps1/awesome-low-level-design — problems/ folder with solutions in Java/Python/C#/C++/Go.
- AlgoMaster.io LLD Interview course.
- Blog: "How to Answer a LLD Interview Problem" — blog.algomaster.io.
- "Clean Code" (Robert C. Martin) — API and class design best practices.

----------------------------------------------------------------------
PHASE 4: Concurrency, Multi-threading & Advanced LLD (Weeks 10–12)
----------------------------------------------------------------------
Goal: Design and implement thread-safe systems, reason about concurrency
      hazards, and solve hard LLD problems under interview conditions.

Difficulty: Advanced

Prerequisites: Phase 3 complete; basic familiarity with threads in your chosen language.

Time Commitment: ~10–12 hrs/week

Key Topics:
- Concurrency Fundamentals: Concurrency vs Parallelism, Processes vs Threads, Thread Lifecycle and States, Race Conditions, Critical Sections.
- Synchronisation Primitives: Mutex, Semaphores, Condition Variables, Reentrant Locks, Compare-and-Swap (CAS), Try-Lock and Timed Locking, Coarse-grained vs Fine-grained Locking.
- Concurrency Hazards: Deadlock (Coffman conditions, prevention strategies), Livelock, Starvation.
- Concurrency Patterns: Thread Pool, Producer-Consumer, Reader-Writer, Signalling Pattern.
- Advanced LLD Problems (Hard): Splitwise (expense sharing, simplify debt algorithm), Chess Game, Snake and Ladder, Movie Ticket Booking, Online Shopping System (Amazon-lite), Online Stock Brokerage, Music Streaming Service (Spotify-lite).

Topic Projects:
- (Concurrency) Implement a thread-safe Blocking Queue from scratch using Mutex + Condition Variables; verify correctness under concurrent producer-consumer load.
- (Concurrency) Implement a Thread Pool that accepts Runnable tasks and limits concurrent execution to N worker threads with graceful shutdown.
- (Advanced LLD) Design Splitwise: model debts, payments, simplify-debt algorithm, and group expense splitting with full UML.

Architect Skills:
- Analysing a given design for deadlock potential using the four Coffman conditions.
- Choosing between coarse-grained and fine-grained locking strategies based on throughput vs. contention trade-offs.

Small Project:
- Implement a Thread-Safe Cache with TTL eviction supporting concurrent reads without blocking and serialised writes.

Medium Project:
- Design a fully thread-safe in-memory Pub-Sub message broker with topics, at-least-once delivery, concurrent publish/subscribe, and subscriber lag monitoring.

Ambitious Project:
- Design an Online Food Delivery Service (Swiggy/DoorDash-lite) at the class level: Restaurant, Menu, Order, Rider Assignment Engine, Payment, and real-time tracking — including full concurrency analysis and deadlock prevention rationale.

Resources:
- AlgoMaster.io: "Master Concurrency Interviews" course.
- "Java Concurrency in Practice" (Goetz et al.) — concepts are language-agnostic; implementations in Java.
- GitHub: ashishps1/awesome-low-level-design — concurrency problems folder.
- Coursera: "Design Patterns" by University of Alberta (UofA specialisation).

----------------------------------------------------------------------
PHASE 5: HLD Foundations — Scalability & Core Building Blocks (Weeks 13–15)
----------------------------------------------------------------------
Goal: Articulate the core distributed-systems trade-offs and assemble any
      system from its fundamental building blocks.

Difficulty: Intermediate

Prerequisites: Phases 1–4 complete or strong OOP background; familiarity with HTTP/REST.

Time Commitment: ~10–12 hrs/week

Key Topics:
- Distributed Systems Theory: CAP Theorem (CP vs AP), consistency models (weak, eventual, strong), availability patterns (fail-over active-passive/active-active, master-slave/master-master replication).
- Performance Fundamentals: Performance vs Scalability, Latency vs Throughput, back-of-the-envelope calculations, availability SLOs (three 9s vs four 9s, in-sequence vs in-parallel).
- Core HLD Building Blocks: DNS (NS, A, CNAME, MX records, TTL), CDN (push vs pull), Load Balancers (L4 vs L7, algorithms: round-robin, least-loaded, session-sticky), Reverse Proxy, API Gateway.
- Database Deep Dive: SQL vs NoSQL selection criteria, RDBMS scaling (master-slave, master-master, federation, sharding, consistent hashing, denormalization, SQL tuning), NoSQL types (key-value, document, wide-column, graph), ACID vs BASE.
- Caching Strategies: Cache-aside, write-through, write-behind (write-back), refresh-ahead; Redis vs Memcached; cache invalidation; CDN, web-server, database, application cache layers.
- Communication Protocols: HTTP verbs and idempotency, TCP vs UDP trade-offs, REST vs RPC (gRPC/Protobuf/Thrift), WebSocket, GraphQL.

Topic Projects:
- (CAP & DB) For a social feed vs a banking transaction system, choose a database and justify using CAP theorem and consistency requirements.
- (Caching) Sketch the full caching strategy for a high-traffic product listing page: which tier (CDN, Redis, DB query cache), which eviction policy, and how to handle stale data on price updates.
- (Load Balancing) Compare L4 vs L7 load balancing for a video streaming service vs an e-commerce checkout; document the trade-offs in an ADR.

Architect Skills:
- Back-of-the-envelope estimation: given QPS, storage, and bandwidth requirements, size servers, storage, and cache layers.
- Choosing the right database type and sharding strategy given schema, access patterns, and scale targets.

Small Project:
- Design a URL Shortener (TinyURL) end-to-end: encoding scheme (Base62 vs MD5), read/write path, Redis caching, SQL vs NoSQL trade-off, CDN for redirects; capacity estimate for 100M URLs.

Medium Project:
- Design a Key-Value Store (Redis-lite): client-server protocol, master-slave replication, consistent hashing for horizontal sharding, and TTL eviction policy.

Ambitious Project:
- Design a globally distributed Content Delivery Network: origin pull vs edge push, cache invalidation propagation, anycast routing, PoP selection, and failover; size storage and bandwidth for 10 PB of content at 1M req/s.

Resources:
- GitHub: donnemartin/system-design-primer — complete reference (356k+ stars).
- roadmap.sh/system-design — visual topic roadmap.
- Educative: "Grokking Modern System Design Interview" — Building Blocks section.
- Book: "Designing Data-Intensive Applications" (Martin Kleppmann) — Chapters 1–6.
- YouTube: Harvard CS75 Scalability Lecture (David Malan).

Notes:
- Keep a latency cheat sheet handy: L1 cache ~0.5 ns, main memory ~100 ns, SSD random read ~150 µs, datacenter RTT ~500 µs, cross-continent ~150 ms.

----------------------------------------------------------------------
PHASE 6: HLD Building Blocks — Distributed Services & Patterns (Weeks 16–17)
----------------------------------------------------------------------
Goal: Design the individual distributed services (queues, search, logging,
      rate limiters) that compose production-grade systems.

Difficulty: Advanced

Prerequisites: Phase 5 complete.

Time Commitment: ~12 hrs/week

Key Topics:
- Asynchronous Architecture: Message Queues (Kafka — durable, replay, high-throughput; RabbitMQ — low-latency, complex routing; Amazon SQS — hosted), Task Queues (Celery), Pub-Sub systems, back-pressure handling with exponential backoff.
- Microservices & Service Mesh: Service discovery (Consul, etcd, Zookeeper), circuit breakers, bulkhead pattern, sidecar proxies, API gateways.
- Distributed Services Deep Dive: Rate Limiter (token bucket vs sliding window log vs sliding window counter), Distributed Cache design, Blob Store (S3-like object storage), Distributed Search (Elasticsearch-like — inverted index, sharding, replication), Distributed Logging, Distributed Task Scheduler (at-least-once vs exactly-once delivery), Sharded Counters.
- Observability: Distributed tracing (Dapper/Jaeger/Zipkin), metrics collection (Prometheus/Grafana), structured logging, SLI/SLO/SLA definitions, alerting.
- Security Patterns at Scale: OAuth 2.0 and JWT for authentication, mTLS between microservices, secrets management, API rate limiting as a security control, OWASP Top 10 for distributed systems.

Topic Projects:
- (Messaging) Compare Kafka vs RabbitMQ for an order-processing pipeline; sketch the topic/queue topology, partition strategy, and consumer group design.
- (Rate Limiting) Implement a distributed rate limiter using Redis with a sliding-window log; handle the thundering-herd problem and Redis failure gracefully.
- (Observability) Design the observability stack for a 50-microservice application: trace correlation IDs, RED metrics (Rate, Errors, Duration), and incident runbook.

Architect Skills:
- Event-driven vs request-response architecture trade-offs for specific business domains (e.g. payments, notifications, analytics).
- Designing for failure: chaos engineering principles (kill random instances, inject latency), graceful degradation, and fallback strategies.

Small Project:
- Design a Rate Limiter API supporting per-user and per-IP limits at 10K req/s using Redis + Lua atomic scripts; handle distributed deployment across multiple gateway nodes.

Medium Project:
- Design a Distributed Task Scheduler (cron-as-a-service): job submission API, at-least-once scheduling with idempotency, worker pool autoscaling, dead-letter queue, and job history retention.

Ambitious Project:
- Design a Distributed Search Engine (Elasticsearch-lite): inverted index construction, document sharding strategy, replica failover, query routing and aggregation, and ranking pipeline; estimate index storage for 1B documents averaging 10 KB each.

Resources:
- Educative: "Grokking Modern System Design Interview" — Modules 17–25 (Messaging Queue, Pub-Sub, Rate Limiter, Blob Store, Distributed Search, Logging, Task Scheduler, Sharded Counters).
- Book: "Designing Data-Intensive Applications" (Kleppmann) — Chapters 7–12.
- High Scalability blog (highscalability.com) — real-world architecture case studies.
- Google Dapper paper (research.google.com); Netflix Chaos Engineering blog.
- Kafka documentation and Confluent Engineering blog.

----------------------------------------------------------------------
PHASE 7: HLD Real-World System Design & Interview Mastery (Weeks 18–20)
----------------------------------------------------------------------
Goal: Design any FAANG/MAANG-scale system end-to-end in 45 minutes using a
      structured framework, and defend trade-off decisions under pressure.

Difficulty: Expert

Prerequisites: Phases 5 and 6 complete.

Time Commitment: ~12–15 hrs/week

Key Topics:
- HLD Interview Framework (RESHADED): Requirements → Estimation → Storage → High-Level Design → APIs → Detailed Design → Evaluation → Distinctive Component.
- Classic System Designs: YouTube/TikTok (video upload, async transcoding pipeline, CDN delivery, recommendation feed), Twitter/X (feed generation — fanout on write vs fanout on read vs hybrid, timeline at scale), WhatsApp (real-time messaging, WebSocket presence, E2E encryption), Uber (geospatial indexing with geohash/quadtree, driver-rider matching, surge pricing), Google Maps (graph shortest-path, ETA computation, live traffic), Typeahead/Search Autocomplete (Trie vs ternary search, distributed prefix tree updates).
- Modern AI/ML System Designs: ChatGPT-like LLM service (token streaming via SSE/WebSocket, session-context store, vector search for RAG, abuse detection), AI-powered code assistant, LLM-powered customer support bot, ML feature store and training pipeline, data infrastructure for AI/ML systems.
- Failure & Resilience Case Studies: Facebook/Meta outage Oct 2021 (BGP misconfiguration + cascading DNS failure), AWS us-east-1 cascading failures, Twitter DDoS — root-cause analysis and architectural remediations.

Topic Projects:
- (Classic) Design YouTube end-to-end: upload flow, async transcoding (Kafka + FFmpeg workers), metadata DB (Cassandra), CDN distribution, recommendation feed (offline ML pipeline), and capacity estimate for 500 hours of video uploaded per minute.
- (Modern AI) Design a ChatGPT-like system: LLM inference layer behind a load balancer, session context in Redis, token streaming via WebSocket, rate limiting per user tier, vector DB (Pinecone/Weaviate) for RAG, and content moderation pipeline.
- (Failure Analysis) Analyse the 2021 Facebook outage (BGP + Whatsapp/Instagram cascade); propose multi-provider DNS and control-plane isolation remediations.

Architect Skills:
- Structuring a 45-minute HLD answer: requirements → estimation → high-level diagram → component deep-dive → trade-offs.
- Adapting the design under interviewer pivots: "what if traffic 10×?", "what if the primary DB goes down?", "how would you add real-time notifications?".
- Cost modelling: estimating monthly cloud spend (compute, storage, egress, CDN) for a designed system at stated scale.

Small Project:
- Design TinyURL with full capacity planning (100M URLs, 10:1 read/write ratio, 5-year storage), API design, Redis caching layer, and DB schema; present as a mock 30-minute whiteboard session.

Medium Project:
- Design Twitter/X feed: focus on the fanout trade-off (fanout-on-write for low-follower accounts vs fanout-on-read for celebrities vs hybrid with a follower-count threshold); include timeline cache (Redis sorted set), storage schema, and API design.

Ambitious Project:
- Design Uber end-to-end: geospatial driver indexing (geohash + quadtree), rider-driver matching algorithm (supply-demand proximity scoring), ETA computation (Dijkstra + traffic weights), surge pricing model, payment flow, and real-time trip tracking at 10M concurrent trips.

Resources:
- Educative: "Grokking Modern System Design Interview" — all case studies (YouTube, WhatsApp, Uber, Twitter, Google Maps, ChatGPT, AI infrastructure, Newsfeed).
- Book: "System Design Interview – An Insider's Guide Vol 1 & 2" (Alex Xu).
- GitHub: donnemartin/system-design-primer — Company architectures and real-world architectures sections.
- YouTube: ByteByteGo channel (Alex Xu) — short illustrated HLD breakdowns, updated 2025/2026.
- Engineering blogs: Netflix Tech Blog, Uber Engineering, LinkedIn Engineering, Meta Engineering, Stripe Engineering Blog.

Notes:
- Practice timed mock interviews: set a 45-minute timer, whiteboard (or paper-sketch) the design, then compare to reference solutions.
- Use the RESHADED checklist as a scorecard after every mock to identify weak areas.
- The LLD (Phases 1–4) and HLD (Phases 5–7) tracks can run in parallel after Phase 2 if you already have strong OOP foundations.

======================================================================

----------------------------------------------------------------------
RECOGNISED SECTION LABELS (kept in sync with server/PlanParser.cs)
----------------------------------------------------------------------
The ProgressTracker parser recognises ONLY these section headers (case-insensitive,
trailing colon required). Anything else is appended to the previous section:

  Goal:                  (single paragraph)
  Difficulty:            (single line)
  Prerequisites:         (single paragraph)
  Time Commitment:       (single line)
  Key Topics:            (bullet list — each "- " becomes a checkable topic)
  Topic Projects:        (bullet list — each "- " becomes a checkable topic)
  Architect Skills:      (bullet list)
  Target Certification:  (single paragraph)
  Small Project:         (single paragraph)
  Medium Project:        (single paragraph)
  Ambitious Project:     (single paragraph)
  Capstone Project:      (single paragraph — legacy, optional)
  Resources:             (bullet list)
  Notes:                 (single paragraph)

Sections may appear in any order and any may be omitted. To add new sections,
update the `known` array in `server/PlanParser.cs` AND render them in
`client/src/components/PhaseCard.jsx`.
----------------------------------------------------------------------
