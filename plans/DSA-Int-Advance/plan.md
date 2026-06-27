======================================================================
DATA STRUCTURES & ADVANCED ALGORITHMS (24-WEEK BLUEPRINT)
======================================================================

This plan takes you from a solid intermediate DSA foundation to advanced-level mastery, covering advanced data structures, algorithm design paradigms, graph theory, dynamic programming, and string algorithms — tailored for competitive programming, FAANG-level interviews, and real-world system design.

----------------------------------------------------------------------
PHASE 1: Reinforcing Intermediate Foundations (Weeks 1–4)
----------------------------------------------------------------------
Goal: Solidify time/space complexity analysis, recursion mastery, and core data structures before tackling advanced topics.

Difficulty: Intermediate

Prerequisites: Familiarity with arrays, linked lists, stacks, queues, basic sorting (merge sort, quicksort), and basic recursion.

Time Commitment: ~10 hrs/week

Key Topics:
- Complexity Analysis: Rigorous Big-O, Big-θ, Big-Ω; amortised analysis; Master Theorem for recurrences.
- Recursion & Divide and Conquer: Tail recursion, tree recursion, divide-and-conquer patterns (merge sort, binary search, Karatsuba multiplication).
- Advanced Sorting: Counting sort, radix sort, bucket sort, external merge sort; choosing sort algorithms by context.
- Hashing Deep Dive: Open addressing vs. chaining, load factor, polynomial rolling hash, Robin Hood hashing.
- Binary Trees & BSTs: AVL trees, Red-Black trees, order-statistic trees, augmented BSTs.
- Heaps & Priority Queues: Min/max heaps, heap sort, d-ary heaps, lazy deletion; Fibonacci heap concepts.

Architect Skills:
- Trade-off documentation: when O(n log n) beats O(n) in practice due to cache locality.
- Identifying amortised cost surprises in production (e.g., ArrayList resizing).

Target Certification:
- No specific certification for this phase — use LeetCode Medium problems as a measurable benchmark (target 80% solve rate on tagged topics).

Small Project:
- Implement a generic order-statistic tree from scratch (supporting rank and select queries) and benchmark it against a sorted array for 10k, 100k, and 1M elements.

Medium Project:
- Build an in-memory LRU + LFU hybrid cache that uses a hash map, doubly-linked list, and a min-heap for frequency tracking. Expose it via a simple CLI.

Ambitious Project:
- Implement a fully-featured in-memory key-value store (like a mini Redis): supports GET, SET, DEL, EXPIRE, and sorted sets backed by a skip list. Profile with realistic workloads.

Resources:
- Book: Introduction to Algorithms (CLRS) — Chapters 3, 4, 6, 7, 11, 13.
- Book: The Algorithm Design Manual (Skiena) — Chapters 2–4.
- Video: Abdul Bari's Algorithm Playlist (videos 1–38) — YouTube.
- Video: William Fiset's Data Structures playlist — YouTube / FreeCodeCamp.
- Practice: LeetCode — Arrays & Hashing, Two Pointers, Binary Search, Stack tags (aim for 30 medium problems).

Notes:
- Do not skip the Master Theorem — it will be the lens through which you analyse every divide-and-conquer algorithm in later phases.
- Implement every data structure from scratch at least once; using library versions comes after you understand internals.

----------------------------------------------------------------------
PHASE 2: Graph Theory & Advanced Tree Structures (Weeks 5–10)
----------------------------------------------------------------------
Goal: Design and implement solutions for complex graph and tree problems using BFS/DFS variants, shortest-path algorithms, MSTs, and advanced tree decompositions.

Difficulty: Intermediate → Advanced

Prerequisites: Phase 1 complete; comfort with recursion and hash maps.

Time Commitment: ~12 hrs/week

Key Topics:
- Graph Representations: Adjacency list vs. matrix; edge list; implicit graphs.
- Graph Traversals: BFS, DFS, topological sort (Kahn's + DFS), cycle detection, bipartite check.
- Shortest Paths: Dijkstra (binary heap + Fibonacci heap), Bellman-Ford, 0-1 BFS, Floyd-Warshall, Johnson's algorithm.
- Minimum Spanning Trees: Kruskal's with Disjoint Set Union (path compression + union by rank), Prim's with priority queue.
- Advanced Graph Algorithms: Bridges and articulation points (Tarjan's), strongly connected components (Kosaraju's + Tarjan's), 2-SAT.
- Network Flow: Ford-Fulkerson, Edmonds-Karp (BFS-based max flow), Dinic's algorithm; min-cut/max-flow theorem.
- Advanced Trees: Segment trees (point update + range query + lazy propagation), Fenwick trees (BIT), Sparse Tables for RMQ, Heavy-Light Decomposition (HLD), Lowest Common Ancestor (binary lifting).
- Disjoint Set Union: Offline LCA with Tarjan, online union-find with rollback.

Architect Skills:
- Graph model selection: when to use implicit vs. explicit graphs to control memory footprint.
- Capacity planning for flow networks; real-world analogy to load balancers and bandwidth allocation.
- Trade-off analysis: Dijkstra vs. A* for game/map pathfinding; HLD vs. centroid decomposition.

Target Certification:
- No formal cert — target LeetCode Hard graph problems (aim for 50% solve rate on Graphs and Tree tags before moving on).

Small Project:
- Implement Dijkstra + BFS shortest-path visualiser on a city road graph (use any open dataset like OpenStreetMap's small extract). Output the path and cost.

Medium Project:
- Build a dependency resolver (like npm/pip): parse a package manifest, model dependencies as a DAG, detect circular dependencies using Tarjan's SCC, and output a valid install order via topological sort.

Ambitious Project:
- Implement a simplified network traffic simulator: model a network topology as a weighted directed graph, compute max-flow (Dinic's) between source/sink pairs, and simulate re-routing when an edge goes down (dynamic graph update).

Resources:
- Book: CLRS — Chapters 22–26.
- Site: cp-algorithms.com — Graph Theory and Data Structures sections (Segment Tree, Fenwick, DSU, Dijkstra, SCC, Flow).
- Video: William Fiset's Graph Theory playlist — YouTube.
- Video: MIT OCW 6.006 — Lectures 13–22.
- Practice: LeetCode — Graphs, Trees, Advanced Graph tags; Codeforces Div. 2 C/D problems.

Notes:
- Segment trees with lazy propagation are notoriously tricky — implement a clean template early and reuse it rather than rewriting from scratch each time.
- HLD is a prerequisite for understanding centroid decomposition in Phase 4.

----------------------------------------------------------------------
PHASE 3: Dynamic Programming — Patterns to Mastery (Weeks 11–16)
----------------------------------------------------------------------
Goal: Recognise and implement the full spectrum of DP patterns — from classical 1D/2D DP to bitmask DP, interval DP, and DP on trees — and optimise solutions using divide-and-conquer DP and convex hull trick.

Difficulty: Advanced

Prerequisites: Phase 1 and Phase 2 complete; strong recursion and memoisation intuition.

Time Commitment: ~12 hrs/week

Key Topics:
- DP Foundations: Top-down (memoisation) vs. bottom-up (tabulation); state design; transition validation.
- Classical Patterns: Knapsack (0/1, unbounded, fractional), Longest Common Subsequence / Longest Increasing Subsequence (patience sort O(n log n)), Matrix Chain Multiplication, Edit Distance.
- Interval DP: Optimal BST, Burst Balloons, Stone Merge — characterising the sub-interval structure.
- Bitmask DP: Travelling Salesman Problem (TSP) O(2^n · n), assignment problems, subset enumeration tricks.
- DP on Trees: Tree DP (re-rooting technique), independent set on tree, diameter with DP.
- DP Optimisations: Divide and Conquer DP (Knuth-Yao speedup O(n² → n log n)), Convex Hull Trick / Li Chao Tree for linear DP, Knuth's Optimisation.
- Profile DP: Broken-profile DP for tiling problems.
- Digit DP: Counting integers in [L, R] satisfying constraints — template-based approach.

Architect Skills:
- DP state space design: identifying minimal state to avoid exponential blowup.
- Analysing when a greedy approach is a degenerate DP (Dijkstra = DP on a DAG of states).
- Documenting DP recurrences clearly for maintainability — essential for production ML pipelines.

Target Certification:
- No formal cert — complete the LeetCode "Dynamic Programming Patterns" study plan and target 60% solve rate on Hard DP problems.

Small Project:
- Solve the full 0/1 Knapsack, LCS, and Edit Distance with three implementations each: naive recursion, top-down memo, and bottom-up table — benchmark and compare memory profiles.

Medium Project:
- Build a text diff tool (like a simplified `git diff`): use LCS/Edit Distance DP to highlight added, removed, and changed lines. Accept two text files and output a colour-coded diff to the terminal.

Ambitious Project:
- Implement a route optimisation engine: given a set of delivery locations (small enough for TSP via bitmask DP, e.g. ≤20 nodes), find the optimal tour. Add a "nearest-neighbour" greedy baseline and compare quality vs. exact solution.

Resources:
- Book: CLRS — Chapters 15, 16 (DP and Greedy).
- Site: cp-algorithms.com — Dynamic Programming section (all articles).
- Post: "Dynamic Programming Patterns" by aatalyk on LeetCode Discuss.
- Video: Tushar Roy's DP Playlist — YouTube.
- Video: Abdul Bari's Algorithm Playlist — videos 46–60.
- Video: MIT OCW 6.006 — Lectures 19–22 (DP); MIT OCW 6.046 for advanced DP.
- Practice: LeetCode — 1-D DP, 2-D DP, Intervals tags; USACO training DP problems.

Notes:
- Master bitmask DP before attempting competitive programming problems involving exponential states — it unlocks a whole category of "impossible-looking" problems.
- The Convex Hull Trick is algebraic; derive it yourself at least once to understand when the monotonicity condition holds.

----------------------------------------------------------------------
PHASE 4: Advanced Algorithms — Strings, Geometry & Combinatorics (Weeks 17–20)
----------------------------------------------------------------------
Goal: Apply advanced string algorithms, computational geometry primitives, number theory, and combinatorics to solve non-trivial problems across competitive programming and real-world applications.

Difficulty: Advanced → Expert

Prerequisites: Phases 1–3 complete; strong algorithmic thinking and proof-by-induction comfort.

Time Commitment: ~12 hrs/week

Key Topics:
- String Algorithms: KMP (prefix function), Z-algorithm, Rabin-Karp rolling hash, Aho-Corasick multi-pattern matching, Suffix Array (SA-IS / prefix doubling), Suffix Automaton, Manacher's palindrome algorithm.
- Advanced Trees Revisited: Centroid decomposition, heavy path queries combined with segment tree.
- Number Theory: Fast modular exponentiation, Sieve of Eratosthenes / linear sieve, Euler's totient, Modular inverse (Fermat's little theorem + Extended Euclidean), CRT (Chinese Remainder Theorem), Miller-Rabin primality.
- Combinatorics: Binomial coefficients modulo prime, Catalan numbers, inclusion-exclusion principle, Burnside's lemma / Pólya enumeration, generating functions basics.
- Bit Manipulation: Brian Kernighan tricks, submask enumeration O(3^n), two-complement arithmetic for competitive problems.
- Fast Fourier Transform (FFT): DFT/IDFT, NTT (Number Theoretic Transform) for polynomial multiplication; convolution applications.
- Computational Geometry (Basics): Convex hull (Graham scan / Andrew's monotone chain), line-segment intersection, closest pair of points (divide and conquer O(n log n)).

Architect Skills:
- String algorithm selection: KMP vs. Aho-Corasick vs. suffix array for log-ingest pipeline pattern matching — cost/memory trade-offs at scale.
- FFT-based convolution for signal processing and big-integer arithmetic — real-world relevance in cryptography and DSP.
- Primer on when exact geometry algorithms are needed vs. floating-point approximations.

Target Certification:
- No formal cert — target Codeforces Div. 1 C-level problems or equivalent; aim for a Codeforces rating of 1800+ by end of this phase.

Small Project:
- Implement Aho-Corasick and build a keyword-scanner CLI: given a dictionary of N keywords and a text file, find all occurrences of all keywords simultaneously in O(text + matches) time.

Medium Project:
- Build a plagiarism detection tool: use rolling hash (Rabin-Karp) with a sliding window of k-grams to detect shared passages between two documents; report matching sections with similarity scores.

Ambitious Project:
- Implement a polygon map analyser using computational geometry: given a set of GPS coordinates forming polygons (e.g., building footprints), compute convex hulls, find the closest pair of polygons, and detect overlapping regions using sweep-line.

Resources:
- Book: CLRS — Chapters 31 (Number Theory), 32 (String Matching), 33 (Computational Geometry).
- Site: cp-algorithms.com — Strings, Algebra, Geometry, and Combinatorics sections.
- Video: MIT OCW 6.006 — Lecture on FFT.
- Video: Algorithms Live! (YouTube) — advanced string and number theory episodes.
- Practice: Codeforces (aim for Div. 2 D/E and Div. 1 B/C); SPOJ SUBSTR, NHAY for string problems.

Notes:
- NTT is preferred over FFT when working with integer polynomials modulo a prime — avoid floating-point precision issues.
- Centroid decomposition is conceptually simple but tricky to implement cleanly; study two reference implementations before writing your own.

----------------------------------------------------------------------
PHASE 5: System-Level Algorithm Design & Capstone Projects (Weeks 21–24)
----------------------------------------------------------------------
Goal: Synthesise all phases into portfolio-quality projects, apply algorithms to real-world system design scenarios, and prepare for advanced technical interviews or competitive programming contests.

Difficulty: Expert

Prerequisites: Phases 1–4 complete.

Time Commitment: ~15 hrs/week

Key Topics:
- Algorithm Engineering: Cache-oblivious algorithms, SIMD-friendly data layouts, branch prediction awareness, memory pool allocators.
- Probabilistic Data Structures: Bloom filters, Count-Min Sketch, HyperLogLog — when approximation beats exactness.
- Randomised Algorithms: Las Vegas vs. Monte Carlo; randomised QuickSelect, treaps, skip lists, reservoir sampling.
- External Memory Algorithms: B-trees and B+ trees for disk-backed storage; merge-sort for datasets exceeding RAM.
- Parallel Algorithm Concepts: Map-Reduce paradigm, parallel prefix (scan), work-span model; lock-free data structures.
- Competitive Programming Synthesis: Solving multi-concept problems combining DP + graph + segment tree; contest strategy and time management.

Architect Skills:
- Choosing between exact and approximate algorithms at scale: Bloom filter for deduplication pipelines, HyperLogLog for cardinality estimation in analytics.
- Designing B-tree-backed indexes and understanding why PostgreSQL / SQLite use B+ trees.
- System design interview application: translating algorithm knowledge to scalable distributed systems (consistent hashing, LSM trees, vector clocks).

Target Certification:
- LeetCode: Maintain a 70%+ solve rate on Hard problems across all tags. Optionally, pursue Google Kick Start or Codeforces Div. 1 participation as a benchmark.

Small Project:
- Implement a Bloom filter and a Count-Min Sketch from scratch; build a URL deduplicator CLI that processes a large URL log file (1M+ lines) without loading it fully into memory.

Medium Project:
- Build a full-text search engine in memory: tokenise documents, build an inverted index using a hash map, implement Boolean AND/OR query evaluation with a posting-list merge, and rank results using TF-IDF scores.

Ambitious Project:
- Design and implement a mini database engine: parse a SQL-like DSL (SELECT, FROM, WHERE, ORDER BY, LIMIT), execute queries using B+ tree indexes, implement a query cost estimator, and benchmark against a hash-based linear scan baseline.

Capstone Project:
- Algorithm Showcase Portfolio: Combine all four project ideas into a unified command-line toolkit — the LRU/LFU cache (Phase 1), the dependency resolver (Phase 2), the route optimiser (Phase 3), and the full-text search engine (Phase 5) — wired together with a CLI dispatcher and documented with algorithm explanations, complexity proofs, and benchmark results. Publish to GitHub as a portfolio artefact.

Resources:
- Book: Algorithm Design (Kleinberg & Tardos) — Chapters 10–13.
- Book: Designing Data-Intensive Applications (Kleppmann) — for B-tree and LSM-tree system design context.
- Site: cp-algorithms.com — Sequences and miscellaneous sections.
- Video: MIT OCW 6.851 Advanced Data Structures (Prof. Demaine) — lectures on cache-oblivious structures.
- Video: Stanford CS166 Data Structures — lecture notes (available online).
- Practice: Codeforces Div. 1 A/B/C problems; LeetCode contest simulations (weekly/biweekly).

Notes:
- This phase is deliberately project-heavy; the theory has been covered — the goal now is synthesis, polish, and communication.
- For FAANG interviews, prioritise the Medium and Ambitious projects as they map directly to system design + coding rounds.

======================================================================
