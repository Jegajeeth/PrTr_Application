======================================================================
DATA STRUCTURES & ALGORITHMS: INTERMEDIATE TO ADVANCED (30-WEEK BLUEPRINT)
======================================================================

A structured path for developers who know the basics and want to reach competitive-programming
and senior-engineer interview level. Each phase includes a built-in problem-pattern reference
so you always know which data structure or algorithm to reach for.

----------------------------------------------------------------------
PHASE 1: Complexity Analysis & Core Structures Refresher (Weeks 1–2)
----------------------------------------------------------------------
Goal: Rigorously analyse time and space complexity and select the correct data structure for any input shape before writing a line of code.

Difficulty: Intermediate

Time Commitment: ~8 hrs/week

Key Topics:
- Complexity: Big-O / Big-Ω / Big-Θ; amortised analysis; recurrence relations and the Master Theorem.
- Arrays & Strings: in-place manipulation, prefix sums, difference arrays, kadane's max-subarray warmup.
- Hash Maps & Sets: open addressing vs chaining; rolling hash; frequency counting patterns.
- Stacks & Queues: monotonic stack (next greater element); monotonic deque (sliding-window max/min).
- Pattern → Algorithm: "find pair with target sum in unsorted array" → Hash Map O(n); "subarray sum equals k" → Prefix Sum + Hash Map O(n); "next greater element" → Monotonic Stack O(n); "sliding-window max" → Monotonic Deque O(n).

Topic Projects:
- (Complexity) Solve the same "find all pairs with sum S" problem with O(n²) brute-force, O(n log n) sort+binary-search, and O(n) hash-map; benchmark on 10K, 100K, and 1M elements; derive the Master Theorem result for one chosen divide-and-conquer recurrence.
- (Arrays & Strings) Implement Kadane's max-subarray algorithm returning the actual subarray indices; also implement prefix-sum + hash-map for "count subarrays with sum equal to k"; validate both on edge cases (all-negative, all-zero, single-element).
- (Hash Maps & Sets) Implement a HashMap from scratch using open addressing with linear probing, quadratic probing, and double hashing; benchmark collision rate and get/set throughput at load factors 0.5, 0.75, and 0.95.
- (Stacks & Queues) Implement a monotonic stack for "next greater element" and a monotonic deque for "sliding-window maximum"; solve 5 LeetCode problems using each structure and record the pattern tag and O-complexity for each.
- (Pattern → Algorithm) Read 10 new LeetCode Medium problems cold; for each, write down the pattern name, correct data structure, and expected time complexity before reading any hints; track your accuracy rate across the phase.

Architect Skills:
- Choose data structures based on access patterns, cache locality, and memory budget.
- Document trade-offs (array vs linked list, hash map vs sorted map) in a decision log.

Target Certification:
- No formal cert for this phase — builds the foundation required by all later phases.

Small Project:
- Implement a HashMap from scratch using open addressing with linear probing and dynamic resizing; benchmark it against your language's built-in map.

Medium Project:
- Build a "Stock Span" dashboard: given daily prices compute span, next-greater-price, and maximum-profit window using a monotonic stack and deque, then render results as a CLI chart.

Ambitious Project:
- Write a mini query engine over CSV data: support GROUP BY (hash map), range filters (sorted array + binary search), and running aggregates (prefix sums). Benchmark with 1 M rows.

Resources:
- "Introduction to Algorithms" (CLRS) – Chapters 1–4, 10–12.
- Neetcode.io – Arrays & Hashing and Stack roadmaps.
- MIT 6.006 Lectures 1–4 (YouTube, free).

Notes:
- Aim to solve 15–20 LeetCode Easy/Medium problems per phase before advancing. Track your pattern-recognition speed — you should be able to name the right approach within 2 minutes of reading a new problem.

----------------------------------------------------------------------
PHASE 2: Two Pointers, Sliding Window & Binary Search (Weeks 3–5)
----------------------------------------------------------------------
Goal: Reduce O(n²) brute-force solutions to O(n) or O(n log n) by mastering pointer movement and window shrink/expand strategies.

Difficulty: Intermediate

Prerequisites: Phase 1

Time Commitment: ~8 hrs/week

Key Topics:
- Two Pointers (opposite ends): sorted-array pair sum, container with most water, trapping rain water.
- Two Pointers (same direction): remove duplicates in-place, Dutch National Flag (3-way partition).
- Sliding Window (fixed size): max sum subarray of size k, find all anagrams in a string.
- Sliding Window (variable size): longest substring without repeating characters, minimum window substring.
- Binary Search (classic): sorted array search, first/last occurrence, rotated sorted array.
- Binary Search (answer space): "minimise the maximum", "capacity to ship packages within D days", "koko eating bananas" — predicate-based bisect.
- Pattern → Algorithm: "pair with sum S in sorted array" → Two Pointers O(n); "longest contiguous subarray satisfying condition" → Sliding Window O(n); "minimum X such that f(X) is true and f is monotone" → Binary Search on Answer O(log(max) × f-cost); "k-th smallest in sorted matrix" → Binary Search + count O(n log(max)).

Topic Projects:
- (Two Pointers — Opposite Ends) Implement "trapping rain water" and "container with most water" using two pointers; draw the pointer-movement trace for 3 input examples and explain why each pointer moves at each step.
- (Two Pointers — Same Direction) Implement Dutch National Flag (3-way partition) in-place; verify correctness on arrays with all-same, two-distinct, and three-distinct element distributions.
- (Sliding Window — Fixed Size) Implement "find all anagrams in a string" using a fixed sliding window with a character-frequency map; benchmark vs. the brute-force O(n×m) approach on a 1M-character string.
- (Sliding Window — Variable Size) Implement "minimum window substring" with a variable sliding window; draw a step-by-step expand/shrink trace on a 20-character example.
- (Binary Search — Classic) Implement `bisect_left` and `bisect_right` from scratch with a test suite covering empty array, all-equal elements, target below minimum, and target above maximum.
- (Binary Search — Answer Space) Implement "capacity to ship packages within D days" and "koko eating bananas" using binary search on the answer space; visualise the search-range narrowing at each iteration.

Architect Skills:
- Identify monotonicity in an answer space — the decisive insight that enables binary-search-on-answer.
- Analyse cache-line efficiency of pointer-based vs index-based traversal.

Target Certification:
- No formal cert — prepares for FAANG-style early screening rounds.

Small Project:
- Implement generic bisect_left and bisect_right functions with a comprehensive edge-case test suite (empty array, all-same elements, target outside range).

Medium Project:
- "Shipping Optimiser": binary-search the minimum ship capacity to meet a deadline; output a step-by-step trace of the search space narrowing.

Ambitious Project:
- Build a real-time log anomaly detector: use a sliding window over a streaming log file to flag error-rate bursts above a configurable threshold, with adjustable window size and step; expose a CLI and a JSON summary report.

Resources:
- Neetcode.io – Two Pointers and Sliding Window roadmaps.
- LeetCode Explore – Binary Search card.
- "Competitive Programmer's Handbook" (Laaksonen) – Chapter 3.

----------------------------------------------------------------------
PHASE 3: Recursion, Backtracking & Divide and Conquer (Weeks 6–8)
----------------------------------------------------------------------
Goal: Design elegant recursive solutions and prune exponential search spaces with backtracking to solve constraint-satisfaction and combinatorial-enumeration problems.

Difficulty: Intermediate

Prerequisites: Phase 1–2

Time Commitment: ~10 hrs/week

Key Topics:
- Recursion Patterns: base-case design, tail recursion, memoisation scaffold (top-down DP preview).
- Backtracking — Enumeration: subsets (power set), permutations (swap-based), combinations of size k.
- Backtracking — Constraint Satisfaction: N-Queens, Sudoku solver; pruning strategies (forward checking, arc consistency).
- Divide and Conquer: merge sort (count inversions), quicksort and partition schemes (Lomuto, Hoare), closest pair of points O(n log n), Karatsuba multiplication.
- QuickSelect: k-th largest element in O(n) average with randomised pivot.
- Pattern → Algorithm: "generate all subsets" → Backtracking O(2^n); "generate all permutations" → Backtracking O(n!); "solve constraint puzzle (Sudoku, N-Queens)" → Backtracking + Pruning; "count inversions" → Merge Sort D&C O(n log n); "k-th largest unsorted" → QuickSelect O(n) avg.

Topic Projects:
- (Recursion Patterns) Implement Fibonacci using naive recursion, memoisation, and bottom-up tabulation; compare call counts and memory usage for n=35, 40, 45; visualise overlapping subproblems with a recursion-tree diagram.
- (Backtracking — Enumeration) Implement power-set generation, swap-based permutation generation, and combinations of size k; verify output counts equal 2^n, n!, and C(n,k) for n=4 and n=5.
- (Backtracking — Constraint Satisfaction) Implement a Sudoku solver; measure solve time on 10 easy, 10 medium, and 10 hard puzzles with and without AC-3 arc-consistency pruning; report the average speedup.
- (Divide and Conquer) Implement merge sort instrumented to count inversions; verify the count against an O(n²) brute-force on a 10-element array; benchmark both up to n=10⁶.
- (QuickSelect) Implement QuickSelect with a randomised pivot; benchmark average-case vs. worst-case (sorted input) performance for k-th largest in arrays of 10K, 100K, and 1M elements.

Architect Skills:
- Estimate search-space explosion (branching-factor^depth) and apply pruning to keep it tractable.
- Compare iterative DFS (explicit stack) vs recursive DFS for production code — stack-overflow risk and debuggability.

Target Certification:
- No formal cert.

Small Project:
- Implement a Sudoku solver with backtracking; measure solve time with and without arc-consistency (AC-3) constraint propagation.

Medium Project:
- "Word Break Explorer": visualise the full backtracking tree for word-break and word-ladder problems, highlighting pruned branches in a different colour.

Ambitious Project:
- Build a configurable branch-and-bound optimiser: given a set of items and constraints, enumerate feasible solutions and report the global optimum — generalised 0/1 knapsack with real-time progress display.

Resources:
- "Algorithm Design" (Kleinberg & Tardos) – Chapters 5–6.
- Neetcode.io – Backtracking roadmap.
- Stanford CS161 lecture notes (Divide and Conquer, free online).

----------------------------------------------------------------------
PHASE 4: Dynamic Programming — Patterns & Optimisations (Weeks 9–13)
----------------------------------------------------------------------
Goal: Recognise and implement the eight canonical DP patterns and apply space and time optimisations to reduce constant factors and asymptotic complexity.

Difficulty: Advanced

Prerequisites: Phase 1–3

Time Commitment: ~12 hrs/week

Key Topics:
- Linear DP: Fibonacci variants, house robber, climbing stairs, coin change (count and min).
- Knapsack Family: 0/1 knapsack, unbounded knapsack, partition equal subset sum, target sum.
- String DP: longest common subsequence (LCS), longest common substring, edit distance (Levenshtein), palindrome partitioning.
- Interval DP: matrix chain multiplication, burst balloons, minimum cost to merge stones.
- Tree DP: maximum path sum in binary tree, diameter, house robber III (no-adjacent-node).
- State Machine DP: buy/sell stock variants (with cooldown, with transaction fee), regex matching, wildcard matching.
- Bitmask DP: travelling salesman (small n), minimum cost to visit all nodes, shortest path visiting all nodes.
- Optimisations: 1-D rolling array (space O(n) → O(1)); divide-and-conquer optimisation O(n log n); convex hull trick (CHT) for linear cost functions; monotonic-queue DP optimisation.
- Pattern → Algorithm: "overlapping subproblems + optimal substructure" → DP (memo or tabulation); "max subarray sum" → Kadane's O(n); "LIS (longest increasing subsequence)" → DP O(n²) or patience sorting O(n log n); "count/min/max over all subsets" → Bitmask DP O(2^n × n); "optimal bracket cost between i and j" → Interval DP O(n³); "digits of a number with a property" → Digit DP.

Topic Projects:
- (Linear DP) Implement coin-change minimum, coin-change count-ways, climbing stairs, and house robber; compare space-optimised O(amount) rolling-array vs. the full 2-D table on inputs of size 10³ and 10⁴.
- (Knapsack Family) Implement 0/1 knapsack, unbounded knapsack, and partition-equal-subset-sum; draw the complete DP table for a 5-item example; quantify memory savings from the 1-D rolling-array optimisation.
- (String DP) Implement LCS, edit distance (Levenshtein), and longest palindromic subsequence; for each, reconstruct the actual sequence by backtracking through the DP table, not just the scalar length.
- (Interval DP) Implement matrix chain multiplication and burst balloons; draw the interval-expansion diagram for a 5-element input; verify against brute-force enumeration.
- (Tree DP) Implement "house robber III" and "binary tree maximum path sum"; implement both iteratively (post-order stack) and recursively; confirm identical results on 5 test trees.
- (State Machine DP) Implement all buy/sell stock variants (one transaction, unlimited, with cooldown, with fee); draw the state-machine diagram and label each transition edge with its cost.
- (Bitmask DP) Implement TSP via bitmask DP for n=10, 14, and 18 cities; plot the exponential runtime growth; add a greedy nearest-neighbour heuristic and compare solution quality vs. the exact DP result.
- (Optimisations) Apply the 1-D rolling-array optimisation to the LCS DP; implement the Convex Hull Trick for a linear DP problem and measure the reduction from O(n²) to O(n); benchmark on n=10⁴ and n=10⁵.

Architect Skills:
- Prove when greedy is sufficient vs when DP is required (exchange-argument proof).
- Apply DP thinking to real system design: optimal caching eviction policies, shortest-path cost amortisation, resource-scheduling.

Target Certification:
- No formal cert — content maps to the Google L4/L5 interview bar.

Small Project:
- Implement all five knapsack variants with test suites comparing space-optimised vs unoptimised memory usage.

Medium Project:
- "Diff Tool": implement Myers diff algorithm (edit distance DP) to produce a minimal unified diff between two text files, with coloured CLI output for added/removed/unchanged lines.

Ambitious Project:
- Build a text auto-correct engine: DP edit distance for candidate ranking, trie for O(1) dictionary lookup, bigram language model for context-aware re-ranking — capable of processing 10 k corrections per second.

Resources:
- "Dynamic Programming for Coding Interviews" (Meenakshi & Kamal Rawat).
- Neetcode.io – 1-D DP, 2-D DP, and Advanced DP roadmaps.
- AtCoder DP Contest (26 canonical problems, all patterns covered).
- "Competitive Programmer's Handbook" – Chapter 7.

Notes:
- After finishing this phase, review your pattern journal and categorise every problem you solved by its DP variant. Patterns you find hard to classify need one more round of practice.

----------------------------------------------------------------------
PHASE 5: Trees, Heaps & Advanced Tree Structures (Weeks 14–16)
----------------------------------------------------------------------
Goal: Traverse, construct, and query tree structures efficiently, and use heap-based techniques to maintain running order statistics on dynamic data.

Difficulty: Intermediate–Advanced

Prerequisites: Phase 1–3

Time Commitment: ~10 hrs/week

Key Topics:
- Binary Trees: DFS (pre/in/post-order iterative and recursive), BFS (level-order), serialisation/deserialisation, LCA.
- Binary Search Trees: insertion/deletion, balanced BST overview (AVL, Red-Black), order-statistics tree (rank/select).
- Heaps & Priority Queues: min-heap, max-heap, heap sort, merge k sorted lists, k-th largest in a stream.
- Tries: insert/search/prefix, autocomplete top-k, XOR-maximisation (max XOR of two numbers).
- Segment Trees: range sum/min/max query O(log n), lazy propagation for range-update O(log n).
- Fenwick Tree (BIT): prefix sum in O(log n), 2-D BIT, count of smaller numbers after self.
- Binary Lifting (Sparse Table): LCA in O(log n) preprocessing + O(log n) query; range-minimum query in O(1) after O(n log n) preprocessing.
- Pattern → Algorithm: "k-th smallest/largest dynamically" → Heap O(log k); "range sum with point updates" → Fenwick Tree O(log n); "range sum with range updates" → Segment Tree + lazy O(log n); "prefix / autocomplete search" → Trie O(L); "LCA of two nodes" → Binary Lifting O(log n); "median of a dynamic stream" → Two Heaps O(log n) per insert.

Topic Projects:
- (Binary Trees) Implement all four traversals (pre/in/post-order iterative + BFS level-order); implement serialise/deserialise using level-order BFS; verify round-trip correctness on a balanced tree, a left-skewed tree, and a single-node tree.
- (Binary Search Trees) Implement an AVL tree with insert, delete, and self-balancing rotations; assert the balance-factor invariant after every operation on a 20-node randomised stress test.
- (Heaps & Priority Queues) Implement "merge k sorted lists" using a min-heap; benchmark throughput for k=10, 100, and 1000 lists each containing 10K elements; compare with a naive merge-all O(kN) baseline.
- (Tries) Implement a Trie with autocomplete returning the top-3 suggestions by insertion frequency, backed by a min-heap; test on a 10K-word dictionary with 100 diverse prefix queries.
- (Segment Trees) Implement a segment tree with lazy propagation supporting range sum, range min, and range max updates and queries; verify correctness against a brute-force baseline on 10⁵ random operations.
- (Fenwick Tree) Implement a 1-D and 2-D Fenwick Tree; use the 1-D version to solve "count of smaller numbers after self"; verify the answer against an O(n²) brute-force for n≤10K.
- (Binary Lifting) Implement binary lifting for LCA with O(n log n) preprocessing and O(log n) queries; verify on a tree with 10K nodes; compare query latency vs. a naïve O(n) LCA walk.

Architect Skills:
- Choose between segment tree and Fenwick tree based on update/query symmetry and implementation complexity.
- Design an O(log n) rank/select leaderboard service using an augmented BST or Fenwick tree.

Target Certification:
- No formal cert.

Small Project:
- Implement a Trie with autocomplete returning the top-3 suggestions by insert frequency, backed by a min-heap.

Medium Project:
- "Leaderboard API": in-memory rank service with O(log n) insert, rank, and select operations using a Fenwick tree; expose via a local REST endpoint.

Ambitious Project:
- Build a range-query engine supporting sum, min, max, and GCD over dynamic arrays of 10⁶ elements, using a lazy-propagation segment tree, with a CLI query interface and a correctness test suite comparing against a brute-force baseline.

Resources:
- "Competitive Programmer's Handbook" – Chapters 9–10.
- CP-Algorithms.com – Segment Trees, Fenwick Trees, Tries sections.
- Neetcode.io – Trees and Heap / Priority Queue roadmaps.

----------------------------------------------------------------------
PHASE 6: Graph Algorithms — Core (Weeks 17–20)
----------------------------------------------------------------------
Goal: Model real-world problems as graphs and apply canonical traversal and shortest-path algorithms with provable correctness.

Difficulty: Advanced

Prerequisites: Phase 1–5

Time Commitment: ~12 hrs/week

Key Topics:
- Representations: adjacency list, adjacency matrix, edge list; implicit graph (grid, word ladder).
- Traversal: BFS (shortest path unweighted, bipartite check), DFS (cycle detection, flood fill).
- Topological Sort: Kahn's algorithm (BFS-based), DFS-based post-order; course schedule, alien dictionary.
- Shortest Paths: Dijkstra O((V+E) log V) with min-heap, Bellman-Ford O(VE) for negative edges, SPFA, Floyd-Warshall O(V³) all-pairs.
- Minimum Spanning Tree: Kruskal's (Union-Find + sort edges), Prim's (heap-based).
- Union-Find (DSU): path compression + union by rank → O(α) per operation; cycle detection, dynamic connectivity, number of connected components.
- Pattern → Algorithm: "shortest path unweighted" → BFS O(V+E); "shortest path non-negative weights" → Dijkstra O((V+E) log V); "shortest path with negative edges" → Bellman-Ford O(VE); "all-pairs shortest path" → Floyd-Warshall O(V³); "minimum cost to connect all nodes" → Kruskal/Prim MST; "task ordering with dependencies" → Topological Sort; "cycle detection undirected" → Union-Find or BFS/DFS coloring; "cycle detection directed" → DFS 3-color marking.

Topic Projects:
- (Representations) Implement the same 30-node, 50-edge graph as an adjacency list, adjacency matrix, and edge list; benchmark BFS traversal time and memory consumption for each representation.
- (Traversal) Implement BFS for bipartite-checking and DFS with 3-colour marking for cycle detection in a directed graph; apply both to a 100-node graph and verify the cycle detection result against brute force.
- (Topological Sort) Implement Kahn's BFS-based and DFS post-order topological sorts; apply both to the "course schedule" problem; verify they produce equivalent valid orderings.
- (Shortest Paths) Implement Dijkstra (binary heap), Bellman-Ford, and Floyd-Warshall; benchmark on graphs of 100, 1K, and 5K nodes; document when each algorithm is the right choice.
- (Minimum Spanning Tree) Implement Kruskal's (with DSU) and Prim's (with a min-heap); benchmark on dense vs. sparse graphs at 1K nodes; verify both produce MSTs of identical total weight.
- (Union-Find) Implement DSU with path compression and union by rank; benchmark amortised operation cost vs. naïve union-find without optimisations for 10⁶ union/find operations.

Architect Skills:
- Map service-mesh topology to a directed graph and identify critical-path bottlenecks.
- Evaluate Dijkstra vs A* for spatial routing — when an admissible heuristic is available and worth the implementation cost.

Target Certification:
- No formal cert — aligns with Amazon/Microsoft senior SDE interview content.

Small Project:
- Implement Dijkstra with a binary-heap priority queue and visualise the shortest-path tree on a 20×20 weighted grid.

Medium Project:
- "Dependency Resolver": parse a package manifest with version constraints, build a DAG, topologically sort, detect circular dependencies, and print a valid install order.

Ambitious Project:
- Build a road-routing microservice: ingest OpenStreetMap XML, construct a weighted adjacency list, expose a REST endpoint for shortest-path queries using Dijkstra, with a spatial index for nearest-node lookup.

Resources:
- "Introduction to Algorithms" (CLRS) – Chapters 22–25.
- CP-Algorithms.com – Graphs section (traversal, shortest paths, MST).
- Neetcode.io – Graphs roadmap.
- William Fiset's Graph Theory playlist (YouTube, free).

----------------------------------------------------------------------
PHASE 7: Advanced Graph Algorithms (Weeks 21–24)
----------------------------------------------------------------------
Goal: Solve network-flow, strongly-connected-component, and bipartite-matching problems that appear in competitive programming and production system design.

Difficulty: Expert

Prerequisites: Phase 6

Time Commitment: ~12 hrs/week

Key Topics:
- Strongly Connected Components (SCC): Kosaraju's algorithm (2-pass DFS), Tarjan's algorithm (low-link / DFS stack); condensation DAG for 2-SAT.
- Articulation Points & Bridges: Tarjan's bridge-finding; biconnected components; network reliability analysis.
- Network Flow: Ford-Fulkerson / Edmonds-Karp O(VE²); Dinic's algorithm O(V²E) with level graph and blocking flow; max-flow min-cut theorem.
- Bipartite Matching: Hopcroft-Karp O(E√V); Hungarian algorithm for weighted assignment (minimum cost perfect matching).
- Euler Path & Circuit: Hierholzer's algorithm O(V+E); existence conditions for directed and undirected graphs.
- Advanced Shortest Path: A* with admissible heuristic O((V+E) log V), bidirectional Dijkstra, contraction hierarchies (conceptual overview).
- Pattern → Algorithm: "find SCCs / condensation graph" → Tarjan's or Kosaraju's O(V+E); "bridges or cut vertices in a network" → Tarjan's bridge-finding O(V+E); "maximum flow / minimum cut" → Dinic's O(V²E); "maximum bipartite matching" → Hopcroft-Karp O(E√V); "route visiting every edge once" → Eulerian Circuit via Hierholzer's O(V+E); "fastest path in a game map with heuristic" → A*.

Topic Projects:
- (Strongly Connected Components) Implement both Tarjan's and Kosaraju's SCC algorithms; apply both to a 50-node directed graph; verify they identify identical SCCs; build and display the condensation DAG.
- (Articulation Points & Bridges) Implement Tarjan's bridge-finding algorithm; apply it to a modelled network graph; report all bridges and articulation points as single points of failure.
- (Network Flow) Implement Dinic's max-flow; solve a bipartite matching problem using it; benchmark throughput vs. Edmonds-Karp on unit-capacity networks of 100 and 500 nodes.
- (Bipartite Matching) Implement Hopcroft-Karp; apply it to a job-applicant matching scenario with 100 applicants and 100 jobs; verify the maximum matching size against brute force for n≤10.
- (Euler Path & Circuit) Implement Hierholzer's algorithm; verify the existence conditions (all-even-degree for circuit, exactly-2-odd-degree for path) on 5 test graphs; trace the circuit construction step-by-step.
- (Advanced Shortest Path) Implement A* with a Manhattan-distance heuristic on a 2-D grid; compare nodes explored vs. plain Dijkstra on 10 source-destination pairs; measure speedup as obstacle density increases.

Architect Skills:
- Model load-balancing capacity constraints as a max-flow problem; apply min-cut to identify network bottlenecks and calculate theoretical maximum throughput.
- Justify algorithm choice (Dinic's vs Edmonds-Karp) based on graph density and expected flow magnitude.

Target Certification:
- No formal cert — aligns with Codeforces Div. 1 / competitive programming Expert tier.

Small Project:
- Implement Tarjan's SCC algorithm and display the condensation DAG for a software module dependency graph.

Medium Project:
- "Network Bottleneck Finder": model a data-centre topology as a flow network, compute max-flow and min-cut, and highlight the bottleneck edges in a graph visualisation (ASCII or SVG).

Ambitious Project:
- Build an online job-matching platform backend: model applicants and jobs as a bipartite graph, compute maximum matching with Hopcroft-Karp, and re-compute incrementally as new applicants arrive using an augmenting-path update.

Resources:
- "Introduction to Algorithms" (CLRS) – Chapter 26 (Network Flow).
- CP-Algorithms.com – SCC, Bridges, Network Flow, Bipartite Matching.
- "Competitive Programmer's Handbook" – Chapters 19–20.
- Stanford CS261 Network Flows lecture slides (free online).

----------------------------------------------------------------------
PHASE 8: Advanced Algorithm Techniques & Competitive Programming (Weeks 25–30)
----------------------------------------------------------------------
Goal: Master meta-strategies — greedy correctness proofs, randomised algorithms, string algorithms, and number theory — and reach LeetCode Hard / Codeforces Div. 1 fluency.

Difficulty: Expert

Prerequisites: Phase 1–7

Time Commitment: ~15 hrs/week

Key Topics:
- Greedy Algorithms: interval scheduling / activity selection, Huffman coding, fractional knapsack, task scheduling; exchange-argument correctness proofs.
- String Algorithms: KMP failure function O(n+m), Z-algorithm O(n+m), Rabin-Karp rolling hash O(n+m) average, Aho-Corasick multi-pattern O(n+m+matches), suffix array + LCP array O(n log n), Manacher's palindrome O(n).
- Suffix Structures: suffix automaton for distinct substrings; suffix array + LCP for longest repeated substring.
- Randomised Algorithms: randomised QuickSort, reservoir sampling, Miller-Rabin primality testing O(k log²n), Monte Carlo vs Las Vegas distinction.
- Number Theory: modular arithmetic and fast exponentiation O(log n), Euler's totient, modular inverse (Fermat's Little Theorem / extended Euclidean), CRT, sieve of Eratosthenes O(n log log n), prime factorisation.
- Advanced DP Revisited: digit DP (count numbers in [L,R] satisfying digit constraints), tree DP with rerooting technique, matrix exponentiation for linear recurrences O(k³ log n).
- Computational Geometry: convex hull (Graham scan / Andrew's monotone chain O(n log n)), line segment intersection, rotating calipers, point-in-polygon.
- Pattern → Algorithm: "single pattern in text" → KMP or Z-Algorithm O(n+m); "multiple patterns in text simultaneously" → Aho-Corasick O(text + patterns + matches); "count distinct substrings" → Suffix Array + LCP O(n log n); "longest repeated substring" → Suffix Array; "interval scheduling — maximise count" → Greedy sort-by-end-time O(n log n); "linear recurrence mod p in O(log n)" → Matrix Exponentiation; "count integers in [L,R] satisfying digit rule" → Digit DP; "primality for large n" → Miller-Rabin O(k log²n); "convex hull of points" → Graham Scan or Monotone Chain O(n log n).

Topic Projects:
- (Greedy Algorithms) Implement interval scheduling (maximise count), Huffman coding, and task scheduling with deadlines; write an exchange-argument correctness proof for one of them; verify greedy optimality against a DP solution.
- (String Algorithms) Implement KMP, Z-algorithm, and Rabin-Karp; benchmark all three finding a 10-character pattern in a 100 MB text corpus; verify all return identical match positions.
- (Suffix Structures) Build a suffix array with LCP array for a 10K-character string; use it to find the longest repeated substring and count distinct substrings; verify both against an O(n²) brute-force.
- (Randomised Algorithms) Implement reservoir sampling for a stream of unknown size; verify uniform distribution over 1M samples with a chi-squared test; implement Miller-Rabin and test it on the first 1000 Carmichael numbers.
- (Number Theory) Implement the Sieve of Eratosthenes, fast modular exponentiation, modular inverse (Fermat's Little Theorem + extended Euclidean), and CRT; use this toolkit to solve 3 competitive programming number-theory problems.
- (Advanced DP Revisited) Implement digit DP counting integers in [L, R] with no two consecutive equal digits; implement matrix exponentiation to compute the n-th Fibonacci in O(log n); verify both against brute force for small inputs.
- (Computational Geometry) Implement Andrew's monotone chain convex hull; benchmark on point sets of 1K, 100K, and 1M points; use rotating calipers to compute the hull's diameter.

Architect Skills:
- Apply amortised analysis (aggregate, accounting, potential methods) to justify O(1) amortised operations in system-level structures such as dynamic buffers and event queues.
- Design a scalable search-as-you-type service using Aho-Corasick plus a trie and analyse throughput under simulated load.

Target Certification:
- No formal cert — content exceeds the bar for most FAANG senior roles and aligns with ICPC regional level.

Small Project:
- Implement KMP and benchmark it against naive search and your language's built-in find function over a 100 MB text corpus; plot throughput vs pattern length.

Medium Project:
- "Plagiarism Detector": use Rabin-Karp rolling hash and a suffix array to detect shared k-grams between two documents, reporting per-section similarity scores with highlighted matches.

Ambitious Project:
- Build a full-text search engine: Aho-Corasick for keyword indexing, suffix array for substring queries, inverted index for ranked retrieval — capable of indexing 100 k documents and returning results in under 50 ms.

Capstone Project:
- Six-week competitive sprint: participate in 12 rated Codeforces rounds (Div. 2 or Div. 1+2); solve at least 5 problems rated 2000+ on LeetCode; submit one accepted solution to Kattis or SPOJ. For every problem solved, record the pattern tag, time complexity, and a one-paragraph reflection in your pattern journal.

Resources:
- "Competitive Programmer's Handbook" (Laaksonen) – full read (free PDF at cses.fi).
- "Introduction to Algorithms" (CLRS) – Chapters 15–17, 31–35 (selected).
- CP-Algorithms.com – Strings, Number Theory, Geometry sections.
- Codeforces problemset filtered by tag and rating 1800–2400.
- CSES Problem Set (cses.fi) – 300 canonical problems covering all phases.
- "Programming Challenges" (Skiena & Revilla).

Notes:
- Maintain a "pattern journal": for every problem you solve write one line — problem name, pattern tag, key insight. Review weekly. After 100 entries, pattern recognition becomes automatic.

======================================================================

----------------------------------------------------------------------
QUICK-REFERENCE: PROBLEM PATTERN → DATA STRUCTURE / ALGORITHM
----------------------------------------------------------------------

Use this table when you read a problem and need to choose the right tool fast.

ARRAY & STRING PATTERNS
- Find pair/triplet with target sum in sorted array         → Two Pointers O(n)
- Find pair with target sum in unsorted array               → Hash Map O(n)
- Longest subarray/substring satisfying a condition         → Sliding Window O(n)
- Subarray sum equals k (array may have negatives)          → Prefix Sum + Hash Map O(n)
- Next greater / smaller element                            → Monotonic Stack O(n)
- Sliding-window maximum or minimum                         → Monotonic Deque O(n)
- Count subarrays with at most k distinct elements          → Sliding Window + Hash Map O(n)
- Maximum subarray sum                                      → Kadane's Algorithm O(n)
- k-th largest in unsorted array                            → QuickSelect O(n) avg / Heap O(n log k)

SEARCH & OPTIMISATION PATTERNS
- Search in sorted array / rotated sorted array             → Binary Search O(log n)
- Minimise the maximum / maximise the minimum               → Binary Search on Answer Space
- k-th smallest in sorted matrix                            → Binary Search + Count O(n log(max))
- Minimum X such that predicate f(X) is true                → Binary Search on Answer + f

RECURSION & ENUMERATION PATTERNS
- Generate all subsets                                      → Backtracking O(2^n)
- Generate all permutations                                 → Backtracking O(n!)
- Generate all combinations of size k                      → Backtracking O(C(n,k))
- Constraint puzzle (Sudoku, N-Queens)                      → Backtracking + Forward Checking
- Count inversions in array                                 → Merge Sort (D&C) O(n log n)
- Sort in O(n log n)                                        → Merge Sort / Heap Sort / Intro Sort

DYNAMIC PROGRAMMING PATTERNS
- Overlapping subproblems, no ordering required             → Memoisation (top-down DP)
- Build answer from smaller answers, clear ordering         → Bottom-up Tabulation DP
- 2-D grid path count / cost                               → 2-D DP O(m×n)
- Longest common subsequence / edit distance                → String DP O(m×n)
- Optimal cost over interval [i, j]                         → Interval DP O(n³)
- Min/max over all subsets of elements                      → Bitmask DP O(2^n × n)
- Longest increasing subsequence                            → DP O(n²) or Patience Sort O(n log n)
- Count integers in [L, R] satisfying digit property        → Digit DP
- Compute linear recurrence mod p fast                      → Matrix Exponentiation O(k³ log n)

TREE & HEAP PATTERNS
- Path sum, diameter in a binary tree                       → DFS post-order O(n)
- Level-order / breadth-first tree properties               → BFS O(n)
- Lowest common ancestor (LCA)                              → Binary Lifting O(log n) / Euler Tour + Sparse Table
- Range sum / min / max with point updates                  → Fenwick Tree (BIT) O(log n)
- Range sum / min / max with range updates                  → Segment Tree + Lazy Propagation O(log n)
- Prefix / autocomplete word search                         → Trie O(L)
- Max XOR of two numbers in an array                        → Trie (binary trie) O(n × 32)
- Median of a dynamic stream                                → Two Heaps (max + min) O(log n) per insert
- k-th largest in a dynamic stream                          → Min-Heap of size k O(log k) per insert
- Merge k sorted lists                                      → Min-Heap O(n log k)

GRAPH PATTERNS
- Shortest path in unweighted graph                         → BFS O(V+E)
- Shortest path with non-negative weights                   → Dijkstra O((V+E) log V)
- Shortest path with negative edge weights                  → Bellman-Ford O(VE)
- All-pairs shortest path                                   → Floyd-Warshall O(V³)
- Minimum spanning tree                                     → Kruskal (DSU + sorted edges) / Prim (heap)
- Task ordering with dependencies                           → Topological Sort (Kahn's BFS or DFS)
- Cycle detection in undirected graph                       → Union-Find or BFS/DFS coloring
- Cycle detection in directed graph                         → DFS 3-colour marking (white/grey/black)
- Connected components (static)                             → BFS/DFS
- Connected components (dynamic, edges added)               → Union-Find (DSU)
- Strongly connected components                             → Tarjan's or Kosaraju's O(V+E)
- Bridges / articulation points in a network                → Tarjan's bridge-finding O(V+E)
- Maximum flow / minimum cut                                → Dinic's Algorithm O(V²E)
- Maximum bipartite matching                                → Hopcroft-Karp O(E√V)
- Eulerian path or circuit                                  → Hierholzer's Algorithm O(V+E)
- Fastest path with spatial heuristic                       → A* Search O((V+E) log V)
- 2-SAT (boolean satisfiability, 2 literals/clause)         → SCC + Condensation DAG O(V+E)

STRING ALGORITHM PATTERNS
- Single pattern search in text                             → KMP O(n+m) or Z-Algorithm O(n+m)
- Multiple patterns searched simultaneously                 → Aho-Corasick O(text + patterns + matches)
- Substring matching with probabilistic hashing             → Rabin-Karp Rolling Hash O(n+m) avg
- Longest repeated substring                                → Suffix Array + LCP O(n log n)
- Count distinct substrings                                 → Suffix Array + LCP  or Suffix Automaton O(n)
- Longest palindromic substring                             → Manacher's Algorithm O(n)

NUMBER THEORY PATTERNS
- Primality check (small n, n < 10⁷)                       → Sieve of Eratosthenes O(n log log n)
- Primality check (large n)                                 → Miller-Rabin O(k log²n)
- Modular inverse (mod prime p)                             → Fermat's Little Theorem: a^(p-2) mod p
- Modular inverse (mod composite m)                         → Extended Euclidean Algorithm
- Combine congruences x ≡ a (mod m)                         → Chinese Remainder Theorem (CRT)
- Power a^b mod p efficiently                               → Fast Exponentiation (binary exponentiation) O(log b)

----------------------------------------------------------------------
