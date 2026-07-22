======================================================================
DATA STRUCTURES & ALGORITHMS — INTERMEDIATE TO ADVANCED (24-WEEK BLUEPRINT)
======================================================================

A project-driven path from solid intermediate DSA to advanced mastery — every
topic anchored to a real system you already use: Redis-style caches, npm resolvers,
food-delivery routing, git diff engines, fraud scanners, and mini database engines.
Five phases, escalating portfolio projects, and measurable competitive-programming
benchmarks. Python 3.12+ primary; C++ optional for performance-critical modules.
All topics verified current as of July 2026.

----------------------------------------------------------------------
PHASE 1: Intermediate Foundations — Complexity, Advanced Structures & Caching (Weeks 1–4)
----------------------------------------------------------------------
Goal: Analyse algorithms rigorously, implement balanced-tree and hash-table internals
      from scratch, and build production-grade in-memory caches used in real backends.

Difficulty: Intermediate

Prerequisites: Comfortable with arrays, linked lists, stacks, queues, basic recursion,
merge/quicksort, BST traversals, BFS/DFS, and Big-O notation. Able to solve LeetCode
Easy problems without hints.

Time Commitment: ~10–12 hrs/week

Key Topics:
- Complexity Analysis: Big-O, Big-θ, Big-Ω; amortised analysis (dynamic array resize, hash table rehash); Master Theorem for divide-and-conquer recurrences.
- Divide & Conquer: Merge sort, quickselect, Karatsuba multiplication; when recursion depth matters.
- Advanced Sorting: Counting sort, radix sort, bucket sort; stability; external merge sort for data larger than RAM.
- Hashing Deep Dive: Chaining vs open addressing, load factor, polynomial rolling hash, collision resolution (linear probing, Robin Hood).
- Balanced Trees: AVL rotations, Red-Black tree invariants (implement insert only), order-statistic trees (rank / select).
- Heaps & Skips: d-ary heaps, lazy deletion, Fibonacci heap concepts; skip lists as probabilistic balanced structure.
- Doubly-Linked Lists: O(1) eviction patterns for cache design.

Topic Projects:
- Complexity: Profile three duplicate-finder implementations (O(n²), O(n log n), O(n)) on 1M integers; plot runtime and explain crossover points.
- Hashing: Implement open-addressing hash map with linear probing and tombstones; compare against Python `dict` at 100k inserts/deletes.
- Balanced Trees: Build AVL tree with insert + search; verify height stays O(log n) after 10k random inserts.
- Heaps: Implement a "stock price alert" system — notify when price crosses threshold using a min-heap of alert rules sorted by trigger price.
- Skip Lists: Implement insert/search/delete on a skip list; benchmark against BST on 50k random keys.

Architect Skills:
- Documenting when O(n log n) beats O(n) in practice due to cache locality and constant factors.
- Choosing LRU vs LFU vs TTL for a CDN edge cache based on access-pattern assumptions.
- Identifying amortised-cost surprises in production (Java ArrayList resize, Go map growth).

Target Certification:
- No formal cert — benchmark: 80% solve rate on LeetCode Medium (Arrays, Hash Table, Heap, Tree tags; ~30 problems).

Small Project:
- "Leaderboard Engine" — order-statistic tree (or sorted container + augmentation) supporting `add_score(player, delta)`, `rank(player)`, and `top_k(k)` in O(log n). Benchmark vs sorted array at 100k, 500k, 1M players.

Medium Project:
- "Hybrid Cache (Redis-lite)" — LRU + LFU hybrid eviction using hash map + doubly-linked list + min-heap for frequency tracking. Support GET, SET, DEL, EXPIRE(ttl), and `stats()` (hit rate, evictions). CLI with realistic workload trace.

Ambitious Project:
- "In-Memory Key-Value Store" — mini Redis: string values, sorted sets backed by skip list, TTL expiry with a lazy + active cleanup strategy, and pipelined command batching. Profile under 1M mixed read/write ops; document complexity per command.

Resources:
- CLRS — Chapters 3, 4, 6, 7, 11, 13.
- Skiena, "The Algorithm Design Manual" — Chapters 2–4.
- Abdul Bari — Algorithm Playlist (videos 1–38).
- William Fiset — Data Structures playlist (FreeCodeCamp).
- Practice: NeetCode 150 — Arrays & Hashing, Heap, Binary Search sections.

Notes:
- Implement every structure from scratch once before using library versions in later phases.
- Master Theorem is the lens for all divide-and-conquer analysis — do not skip the recurrence drills.

----------------------------------------------------------------------
PHASE 2: Graph Theory & Advanced Trees — Routing, Dependencies & Networks (Weeks 5–10)
----------------------------------------------------------------------
Goal: Model real-world networks as graphs, implement shortest-path and flow
      algorithms, and use segment trees / Fenwick trees for live analytics on graphs.

Difficulty: Intermediate → Advanced

Prerequisites: Phase 1 complete. Comfortable with recursion, priority queues, and hash maps.

Time Commitment: ~12 hrs/week

Key Topics:
- Graph Representations: Adjacency list vs matrix vs edge list; implicit graphs (state-space search).
- Traversals & Ordering: BFS, DFS, topological sort (Kahn's + DFS), cycle detection, bipartite check, 0-1 BFS.
- Shortest Paths: Dijkstra (binary heap), Bellman-Ford (negative edges), Floyd-Warshall (all-pairs), Johnson's algorithm.
- MST & Connectivity: Kruskal (DSU with path compression + union by rank), Prim's; bridge and articulation point detection (Tarjan's).
- Advanced Graph: Strongly connected components (Kosaraju / Tarjan), 2-SAT reduction pattern.
- Network Flow: Ford-Fulkerson, Edmonds-Karp, Dinic's max-flow; min-cut / max-flow theorem.
- Range Query Trees: Segment tree (point update, range query, lazy propagation), Fenwick tree (BIT), sparse table for static RMQ.
- Tree Decompositions: Heavy-Light Decomposition (HLD), LCA via binary lifting.

Topic Projects:
- Shortest Path: Build "Uber ETA Calculator" — Dijkstra on OpenStreetMap road extract; output route polyline and travel time with traffic-weighted edges.
- Topological Sort: "CI/CD Pipeline Validator" — parse a build DAG (jobs + dependencies), detect cycles, output parallelisable stages.
- Network Flow: "Data Centre Bandwidth Allocator" — model server pairs as flow network; compute max throughput with Dinic's when a link fails.
- Segment Tree: "Live Stock Dashboard" — range sum + range max queries on 1M tick updates/sec simulation with lazy propagation.
- DSU: "Social Network Cluster Detector" — union-find for friend connections; report component sizes after each `connect` event.

Architect Skills:
- Graph model selection: explicit vs implicit graph to control memory on large state spaces.
- Dijkstra vs A* for map routing — when heuristic is admissible and worth the complexity.
- HLD vs centroid decomposition trade-off for tree path queries at scale.

Target Certification:
- No formal cert — benchmark: 50% solve rate on LeetCode Hard (Graph, Tree, Advanced Graph tags; ~25 problems).

Small Project:
- "Subway Navigator" — BFS fewest-stops + Dijkstra fastest-route on a real transit graph (MTA / TfL open data). CLI prints route with line changes highlighted.

Medium Project:
- "Package Dependency Resolver" — parse `package.json` / `requirements.txt` manifests, model as DAG, detect circular deps via Tarjan's SCC, output valid topological install order with conflict explanation on failure.

Ambitious Project:
- "Network Traffic Simulator" — weighted directed topology; max-flow (Dinic's) between datacentre pairs; simulate edge failure → re-route; segment tree tracks per-link utilisation over time windows. Export congestion heatmap as JSON.

Resources:
- CLRS — Chapters 22–26.
- cp-algorithms.com — Graph Theory, DSU, Segment Tree, Fenwick, Flow sections.
- William Fiset — Graph Theory playlist.
- MIT OCW 6.006 — Lectures 13–22.
- Practice: Codeforces Div. 2 C graph problems; LeetCode Graph / Advanced Graph study plan.

Notes:
- Build one clean segment-tree template with lazy propagation early — reuse it in Phases 3–5.
- HLD unlocks centroid decomposition intuition in Phase 4.

----------------------------------------------------------------------
PHASE 3: Dynamic Programming — Optimisation in the Real World (Weeks 11–16)
----------------------------------------------------------------------
Goal: Recognise DP patterns in logistics, text processing, and scheduling problems;
      implement bitmask and interval DP; optimise with divide-and-conquer DP tricks.

Difficulty: Advanced

Prerequisites: Phases 1–2 complete. Strong memoisation intuition and recursion comfort.

Time Commitment: ~12 hrs/week

Key Topics:
- DP Foundations: State design, transition validation, top-down vs bottom-up, space optimisation (rolling array).
- Classical Patterns: 0/1 and unbounded knapsack, LCS, LIS (O(n log n) patience sort), matrix chain multiplication, edit distance.
- Interval DP: Optimal BST, burst balloons, stone merge — sub-interval structure.
- Bitmask DP: TSP O(2^n · n), assignment problems, subset enumeration.
- Tree DP: Re-rooting technique, independent set on trees, diameter with DP.
- DP Optimisations: Divide-and-conquer DP (Knuth speedup), convex hull trick / Li Chao tree, digit DP template.
- Greedy ↔ DP: When greedy is optimal; when it fails (counterexamples).

Topic Projects:
- Knapsack: "Airline Cargo Loader" — maximise value within weight/volume limits; compare greedy vs optimal on random manifests.
- Edit Distance: "Spell Checker Suggestions" — rank top-5 corrections for a misspelled word against a 50k dictionary.
- Interval DP: "Warehouse Box Stacking" — given box dimensions and rotatability, maximise stack height (box stacking DP variant).
- Bitmask DP: "Delivery Route Optimiser" — exact TSP for ≤18 stops; compare against nearest-neighbour greedy baseline.
- Tree DP: "Org Chart Bonus Allocator" — tree DP where parent-child bonus constraints apply; compute max total bonus.

Architect Skills:
- DP state space design — minimal state to avoid exponential blowup.
- When Dijkstra is DP on a DAG of states (unifies graph + DP thinking).
- Documenting recurrences for maintainability in production ML / optimisation pipelines.

Target Certification:
- No formal cert — benchmark: 60% solve rate on LeetCode Hard DP; complete LeetCode "Dynamic Programming Patterns" study plan.

Small Project:
- "Git Diff Lite" — LCS / edit-distance DP between two text files; colour-coded terminal diff (added / removed / changed lines) with line numbers.

Medium Project:
- "Meal-Prep Optimiser" — knapsack + constraint satisfaction: select recipes hitting macro targets (protein, carbs, fat) within budget; expose as CLI with JSON meal database.

Ambitious Project:
- "Last-Mile Delivery Planner" — bitmask DP exact tour for ≤20 stops + 2-opt local search heuristic for larger sets; ingest real addresses (geocoded), compare tour cost vs greedy; visualise route on a static map export.

Resources:
- CLRS — Chapters 15–16.
- cp-algorithms.com — Dynamic Programming section (all articles).
- LeetCode Discuss — "Dynamic Programming Patterns" (aatalyk).
- Tushar Roy — DP Playlist; Abdul Bari videos 46–60.
- MIT OCW 6.006 Lectures 19–22; 6.046 for advanced DP.
- Practice: USACO DP training problems; LeetCode 1-D / 2-D / Interval DP tags.

Notes:
- Master bitmask DP before contest problems with exponential-looking state — huge unlock.
- Derive convex hull trick once to know when monotonicity condition holds.

----------------------------------------------------------------------
PHASE 4: String Algorithms, Geometry & Number Theory — Search, Fraud & Maps (Weeks 17–20)
----------------------------------------------------------------------
Goal: Apply advanced string matching to log analysis and plagiarism detection,
      use computational geometry for GIS problems, and wield modular arithmetic
      for hashing and cryptographic primitives.

Difficulty: Advanced → Expert

Prerequisites: Phases 1–3 complete. Proof-by-induction comfort; solid C++/Python choice for performance modules.

Time Commitment: ~12 hrs/week

Key Topics:
- String Matching: KMP (prefix function), Z-algorithm, Rabin-Karp rolling hash, Aho-Corasick multi-pattern, suffix array (prefix doubling), Manacher's palindrome.
- Advanced Trees: Centroid decomposition; HLD + segment tree for path queries.
- Number Theory: Fast modexp, sieve / linear sieve, Euler's totient, modular inverse, CRT, Miller-Rabin primality.
- Combinatorics: Binomial coefficients mod prime, Catalan numbers, inclusion-exclusion, Burnside's lemma.
- Bit Manipulation: Submask enumeration, Brian Kernighan, two's-complement tricks.
- FFT / NTT: Polynomial multiplication via NTT (integer-safe); convolution applications.
- Computational Geometry: Convex hull (Andrew's monotone chain), segment intersection, closest pair (divide & conquer).

Topic Projects:
- KMP: "DNA Pattern Finder" — locate gene motif occurrences in a genome string; report all start indices.
- Aho-Corasick: "Security Log Scanner" — simultaneous multi-keyword search across 1 GB log file in single pass.
- Rolling Hash: "Document Fingerprinting" — k-gram Rabin-Karp sliding window for near-duplicate paragraph detection.
- Convex Hull: "Drone No-Fly Zone Builder" — compute convex hull of restricted airspace coordinates; test if flight path intersects.
- Number Theory: "Distributed Shard Key Generator" — CRT-based ID assignment across nodes without collision.

Architect Skills:
- KMP vs Aho-Corasick vs suffix array for log-ingest pipelines — throughput / memory trade-offs.
- NTT over FFT when working modulo prime — avoid floating-point precision bugs.
- Exact geometry vs floating-point approximation in GIS — when error bounds matter.

Target Certification:
- No formal cert — benchmark: Codeforces Div. 2 D/E solve rate ≥40%; target rating 1800+ by phase end.

Small Project:
- "Compliance Keyword Scanner" — Aho-Corasick CLI: dictionary of N policy keywords, scan documents, report line/column of every match in O(text + matches).

Medium Project:
- "Plagiarism Detector" — rolling-hash k-gram index across two essays; report shared passages with similarity score and highlighted offsets; handle paraphrase via shingle size tuning.

Ambitious Project:
- "City Parcel Analyser (GIS)" — ingest GeoJSON building footprints; convex hull per district, closest-pair between district hulls, overlap detection via sweep-line; export analysis report for urban planning scenario.

Resources:
- CLRS — Chapters 31–33.
- cp-algorithms.com — Strings, Algebra, Geometry, Combinatorics.
- MIT OCW 6.006 — FFT lecture; Algorithms Live! (YouTube).
- Practice: Codeforces Div. 2 D/E; SPOJ SUBSTR, NHAY.

Notes:
- Centroid decomposition: study two reference implementations before writing your own.
- For plagiarism tool, never ship without discussing false-positive / false-negative trade-offs in README.

----------------------------------------------------------------------
PHASE 5: System-Level Algorithms & Portfolio Capstone (Weeks 21–24)
----------------------------------------------------------------------
Goal: Synthesise all phases into portfolio-grade systems — probabilistic structures,
      external-memory indexes, and a unified capstone toolkit ready for senior
      interviews or competitive programming contests.

Difficulty: Expert

Prerequisites: Phases 1–4 complete.

Time Commitment: ~15 hrs/week

Key Topics:
- Algorithm Engineering: Cache-oblivious layouts, branch prediction, memory pools, SIMD-friendly structures.
- Probabilistic Structures: Bloom filter, Count-Min Sketch, HyperLogLog — exact vs approximate at scale.
- Randomised Algorithms: Treaps, skip lists (review), reservoir sampling, randomised quickselect.
- External Memory: B-trees / B+ trees, LSM-tree concepts, external merge sort.
- Parallel Concepts: Map-reduce paradigm, parallel prefix scan, work-span model.
- Contest Synthesis: Multi-concept problems (DP + graph + segment tree); time management under pressure.

Topic Projects:
- Bloom Filter: "URL Crawler Dedup" — process 5M URLs; measure false-positive rate vs memory budget.
- Count-Min Sketch: "Trending Hashtag Estimator" — approximate frequency in streaming social feed.
- B+ Tree: "Disk-Backed Index" — implement page-based B+ tree with insert/search/range-scan on a binary file.
- Reservoir Sampling: "Reservoir Audit Sampler" — uniform random sample of 1k records from 100M-row stream.
- Contest Drill: Solve one Codeforces Div. 1 B combining graph + DP under 90-minute timer.

Architect Skills:
- Bloom filter vs exact set for dedup pipelines — memory / accuracy / delete-support trade-offs.
- Why PostgreSQL / SQLite use B+ trees — range scan + disk block alignment.
- System design mapping: consistent hashing, LSM trees, vector clocks — algorithm knowledge → distributed systems.

Target Certification:
- No formal cert — benchmark: 70%+ solve rate on LeetCode Hard across all tags; optional Codeforces Div. 1 participation or Google Kick Start.

Small Project:
- "Streaming Dedup Pipeline" — Bloom filter + Count-Min Sketch; CLI processes large URL / event log without loading full file into RAM; report estimated unique count vs exact (on sample).

Medium Project:
- "In-Memory Search Engine" — inverted index (hash map + posting lists), Boolean AND/OR queries, TF-IDF ranking; benchmark query latency on 10k-document corpus.

Ambitious Project:
- "Mini Database Engine" — SQL-like DSL (SELECT, FROM, WHERE, ORDER BY, LIMIT); B+ tree index vs hash scan baseline; naive query cost estimator; benchmark on 1M-row synthetic dataset.

Capstone Project:
- "Algorithm Toolkit — Real World Edition" — unified CLI wiring together: (1) Hybrid Cache from Phase 1, (2) Dependency Resolver from Phase 2, (3) Delivery Route Optimiser from Phase 3, (4) Plagiarism Detector from Phase 4, (5) Search Engine from Phase 5. Each module documents algorithm, complexity proof, and benchmark. Publish as GitHub portfolio with architecture diagram mapping features → data structures.

Resources:
- Kleinberg & Tardos, "Algorithm Design" — Chapters 10–13.
- Kleppmann, "Designing Data-Intensive Applications" — B-tree and LSM-tree chapters.
- MIT OCW 6.851 (Demaine) — cache-oblivious structures.
- Stanford CS166 — lecture notes.
- Practice: Codeforces Div. 1 A/B/C; LeetCode weekly contest simulations.

Notes:
- Phase 5 is synthesis-heavy — theory done; focus on polish, benchmarks, and clear README storytelling.
- For senior SWE interviews, Medium + Ambitious projects map directly to coding + system design rounds.
- Capstone README must map each feature to its DSA structure — same discipline as beginner track, advanced depth.

======================================================================
