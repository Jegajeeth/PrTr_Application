======================================================================
<PLAN TITLE IN CAPS> (<TOTAL DURATION> BLUEPRINT)
======================================================================

<One or two sentence description of who this plan is for and what it achieves.>

----------------------------------------------------------------------
PHASE 1: <Phase Title> (Weeks 1–N)
----------------------------------------------------------------------
Goal: <Single concise sentence describing what you will be able to do after this phase.>

Difficulty: <Beginner | Intermediate | Advanced | Expert>

Prerequisites: <Skills/phases required before starting this one. Remove section if not needed.>

Time Commitment: <e.g. ~10 hrs/week>

Key Topics:
- <Category>: <Description of tools, concepts, or skills covered.>
- <Category>: <Description of tools, concepts, or skills covered.>
- <Category>: <Description of tools, concepts, or skills covered.>

Architect Skills:
- <Trade-off analysis, cost modelling, governance, or other architect-level competency.>
- <e.g. Well-Architected pillar focus, decision documentation, risk assessment.>

Target Certification:
- <Certification Name (Exam Code)>

Small Project:
- <Weekend-scale hands-on exercise that locks in the basics.>

Medium Project:
- <1–2 week project that integrates several concepts.>

Ambitious Project:
- <Multi-week portfolio-grade build that demonstrates mastery.>

Capstone Project:
- <Optional single capstone — kept for backward compatibility with older plans. Remove if using Small/Medium/Ambitious tiers above.>

Resources:
- <Book / official docs / video course / lab.>
- <Book / official docs / video course / lab.>

Notes:
- <Any prerequisites, tips, or caveats for this phase. Remove section if not needed.>

----------------------------------------------------------------------
PHASE 2: <Phase Title> (Weeks N+1–M)
----------------------------------------------------------------------
Goal: <Single concise sentence describing what you will be able to do after this phase.>

Difficulty: <Beginner | Intermediate | Advanced | Expert>

Prerequisites: <Skills/phases required before starting this one.>

Time Commitment: <e.g. ~10 hrs/week>

Key Topics:
- <Category>: <Description.>
- <Category>: <Description.>
- <Category>: <Description.>

Architect Skills:
- <Architect-level competency.>
- <Architect-level competency.>

Target Certification:
- <Certification Name (Exam Code)>

Small Project:
- <Weekend-scale exercise.>

Medium Project:
- <1–2 week project.>

Ambitious Project:
- <Multi-week portfolio-grade build.>

Resources:
- <Reference / book / course.>

Notes:
- <Optional notes. Remove section if not needed.>

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
