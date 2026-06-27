======================================================================
MACHINE LEARNING: BEGINNER TO ADVANCED (40-WEEK BLUEPRINT)
======================================================================

A hands-on, career-focused curriculum for software engineers with no prior ML experience who want to land an ML/AI role, earn Azure AI certifications, build real-world projects, and engage with research-grade topics.

----------------------------------------------------------------------
PHASE 1: Math & Statistics Foundations for ML (Weeks 1–4)
----------------------------------------------------------------------
Goal: Build the mathematical intuition needed to understand why ML algorithms work, covering linear algebra, calculus, and statistics with Python tooling.

Difficulty: Intermediate

Prerequisites: Comfortable with Python; high-school algebra sufficient to start.

Time Commitment: ~15 hrs/week

Key Topics:
- Linear Algebra: Vectors, matrices, dot products, eigenvalues/eigenvectors, SVD — the language of data transformations and dimensionality.
- Calculus & Optimisation: Derivatives, chain rule, gradient descent intuition, partial derivatives, Jacobian and Hessian overview.
- Probability & Statistics: Probability distributions (Gaussian, Bernoulli, Poisson), Bayes' theorem, MLE, MAP estimation, hypothesis testing, p-values, confidence intervals.
- NumPy & Pandas Fundamentals: Vectorised operations, broadcasting, DataFrame manipulation, EDA workflows.
- Data Visualisation: Matplotlib and Seaborn for distributions, correlations, and feature inspection.

Topic Projects:
- (Linear Algebra) Implement SVD from scratch using NumPy power iteration; use it to compress a grayscale image at three quality levels and compare reconstruction error.
- (Calculus & Optimisation) Implement and animate gradient descent, momentum, and Adam on a 2D loss surface; compare convergence trajectories across learning rates.
- (Probability & Statistics) Build a Bayesian A/B test calculator that computes posterior distributions over conversion rates and outputs a decision recommendation with credible intervals.
- (NumPy & Pandas Fundamentals) Process a 1M-row CSV end-to-end — ingest, clean, aggregate, and produce a summary HTML report using only NumPy and Pandas (no scikit-learn).
- (Data Visualisation) Create an interactive EDA dashboard in Plotly for a tabular Kaggle dataset with distribution plots, correlation heatmap, and outlier flag table.
- Identify when a problem is data-limited vs. compute-limited to guide investment decisions.
- Evaluate dataset quality risks (bias, leakage, staleness) before committing to an approach.

Target Certification:
- Microsoft Azure AI Fundamentals (AI-901) — lightweight certification to anchor Azure context early; sit exam at end of Phase 2.

Small Project:
- EDA notebook on a Kaggle tabular dataset: compute summary statistics, plot distributions, identify outliers, and document findings as a mini data quality report.

Medium Project:
- Implement gradient descent from scratch in NumPy to minimise a least-squares loss, then compare convergence under different learning rates using Matplotlib visualisation.

Ambitious Project:
- Statistical A/B test framework: Python library that ingests two samples, runs t-tests and Mann-Whitney U, computes effect sizes, and generates an HTML report with Plotly.

Resources:
- 3Blue1Brown "Essence of Linear Algebra" and "Essence of Calculus" (YouTube, free).
- "Mathematics for Machine Learning" — Deisenroth, Faisal, Ong (free PDF at mml-book.com).
- "Statistics and Probability" — Khan Academy (free, interactive).
- "Python for Data Analysis" — Wes McKinney, 3rd ed. (O'Reilly).

Notes:
- Skip proof-heavy theoretical sections initially; focus on geometric intuition. Revisit rigour once you have practical anchors.

----------------------------------------------------------------------
PHASE 2: Classical Supervised Learning (Weeks 5–10)
----------------------------------------------------------------------
Goal: Implement, tune, and critically evaluate the full family of classical supervised ML models on real datasets using scikit-learn.

Difficulty: Intermediate

Prerequisites: Phase 1 complete.

Time Commitment: ~15 hrs/week

Key Topics:
- Regression Models: Linear regression, ridge/lasso regularisation, polynomial regression, bias-variance trade-off.
- Classification Models: Logistic regression, k-NN, Naive Bayes, decision trees, support vector machines (kernel trick, margin, C/gamma).
- Ensemble Methods: Bagging, random forests, gradient boosting (XGBoost, LightGBM, CatBoost) — the workhorses of tabular ML competitions.
- Model Evaluation: Cross-validation, confusion matrix, precision/recall/F1, ROC-AUC, learning curves, RMSE/MAE/R².
- Scikit-learn Pipelines: Transformers, estimators, Pipeline and ColumnTransformer for reproducible workflows.
- Hyperparameter Tuning: Grid search, random search, Optuna basics.

Topic Projects:
- (Regression Models) Compare ridge, lasso, and elastic net on the Ames Housing dataset; plot regularisation paths and select the best alpha via cross-validation.
- (Classification Models) Build a pipeline comparing logistic regression, k-NN, and SVM on a medical dataset; include ROC curves and evaluate statistical significance of AUC differences.
- (Ensemble Methods) Train XGBoost, LightGBM, and CatBoost on a tabular classification task; compare SHAP feature importance plots and calibration curves side-by-side.
- (Model Evaluation) Implement stratified k-fold with custom metrics; demonstrate the effect of target leakage by comparing a leaky vs. correct pipeline on holdout performance.
- (Scikit-learn Pipelines) Build a production-ready Pipeline with ColumnTransformer, imputation, encoding, and a gradient boosting estimator; serialise with joblib and load in a FastAPI endpoint.
- (Hyperparameter Tuning) Use Optuna to tune XGBoost hyperparameters on a Kaggle dataset; visualise the hyperparameter importance plot and optimisation history.
- Build a model selection decision matrix: when to use tree-based vs. linear vs. kernel methods based on data shape, interpretability, and latency constraints.
- Document model cards (performance, limitations, fairness metrics) as part of every project.

Target Certification:
- Microsoft Azure AI Fundamentals (AI-901) — sit exam during Weeks 9–10.

Small Project:
- Titanic survival predictor: full scikit-learn Pipeline with feature engineering, cross-validation, and a model comparison table.

Medium Project:
- House price regression with Ames Housing dataset: feature engineering, regularised models vs. gradient boosting, SHAP explainability, and a FastAPI endpoint serving predictions.

Ambitious Project:
- Kaggle tabular competition entry: join an active competition and iterate through feature engineering → ensemble stacking → leaderboard submission cycle for 3+ weeks.

Resources:
- "Hands-On Machine Learning with Scikit-Learn, Keras & TensorFlow" — Aurélien Géron, 3rd ed. (Chapters 1–7).
- Scikit-learn official user guide (scikit-learn.org).
- "The Elements of Statistical Learning" — Hastie, Tibshirani, Friedman (free PDF) — reference depth reading.
- XGBoost and LightGBM official documentation.

Notes:
- Gradient boosting (XGBoost/LightGBM) covers 80% of real tabular ML problems in industry. Spend extra time here.

----------------------------------------------------------------------
PHASE 3: Unsupervised Learning & Feature Engineering (Weeks 11–14)
----------------------------------------------------------------------
Goal: Extract signal from unlabelled data, engineer features that boost model performance, and build a rigorous evaluation mindset.

Difficulty: Intermediate

Prerequisites: Phase 2 complete.

Time Commitment: ~15 hrs/week

Key Topics:
- Clustering: k-Means, hierarchical clustering, DBSCAN, Gaussian Mixture Models; cluster validation (silhouette, Davies-Bouldin).
- Dimensionality Reduction: PCA (geometry and implementation), t-SNE, UMAP for visualisation and preprocessing.
- Anomaly Detection: Isolation Forest, Local Outlier Factor, one-class SVM for fraud and monitoring use cases.
- Feature Engineering: Encoding strategies (target encoding, embeddings for categoricals), date/time features, interaction features, binning.
- Feature Selection: Filter methods, RFE, SHAP-based importance — avoiding the curse of dimensionality.
- Data Preprocessing Pipelines: Missing data strategies, scaling, imbalanced datasets (SMOTE, class weights).

Topic Projects:
- (Clustering) Apply k-Means and DBSCAN to a geospatial dataset; evaluate with silhouette scores and visualise cluster boundaries on a map.
- (Dimensionality Reduction) Compare PCA, t-SNE, and UMAP on MNIST embeddings; evaluate neighbourhood preservation using KNN accuracy in the reduced space.
- (Anomaly Detection) Apply Isolation Forest and LOF to a credit card fraud dataset; tune the contamination parameter and compare precision-recall curves at different thresholds.
- (Feature Engineering) Engineer 10 new features for a tabular dataset (date decomposition, interaction terms, target encoding); measure lift in model performance using SHAP values before and after.
- (Feature Selection) Compare RFE, SelectFromModel, and SHAP-based selection on a high-dimensional dataset; plot model performance vs. feature count for each method.
- (Data Preprocessing Pipelines) Build an imbalanced-learn pipeline combining SMOTE, feature scaling, and a classifier; compare against the class-weight approach on F1 and ROC-AUC.
- Design a feature store schema: distinguish raw, derived, and aggregated features; identify reuse opportunities across models.
- Cost-benefit analysis of labelling effort vs. leveraging unsupervised pre-training.

Target Certification:
- Begin DP-100 study: review Azure ML Studio, datasets, and compute targets in parallel with project work.

Small Project:
- Customer segmentation on a retail dataset: k-Means + UMAP visualisation + cluster persona description document.

Medium Project:
- Fraud detection pipeline: imbalanced dataset handling, anomaly detection baseline (Isolation Forest) vs. supervised gradient boosting, precision-recall optimisation, and monitoring dashboard.

Ambitious Project:
- End-to-end feature store prototype: ingest raw data, build a feature engineering pipeline, persist features to Azure Blob Storage, and serve them to two different downstream models using the same feature definitions.

Resources:
- "Hands-On Machine Learning" — Géron, Chapters 8–9 (dimensionality reduction and unsupervised).
- "Feature Engineering for Machine Learning" — Alice Zheng & Amanda Casari (O'Reilly).
- UMAP paper and documentation (umap-learn.readthedocs.io).

Notes:
- Unsupervised techniques are often under-estimated; they are essential for pre-training, data exploration, and cold-start recommendation systems.

----------------------------------------------------------------------
PHASE 4: Deep Learning Fundamentals (Weeks 15–20)
----------------------------------------------------------------------
Goal: Build, train, and debug neural networks from scratch and with PyTorch, understanding backpropagation, optimisation, and regularisation at a theoretical and practical level.

Difficulty: Advanced

Prerequisites: Phases 1–3 complete; linear algebra and calculus from Phase 1.

Time Commitment: ~18 hrs/week

Key Topics:
- Neural Network Fundamentals: Perceptron, multi-layer perceptron, activation functions (ReLU, sigmoid, softmax), forward pass, computational graph.
- Backpropagation: Chain rule through a graph, vanishing/exploding gradients, gradient clipping.
- Optimisers: SGD with momentum, Adam, AdaGrad, learning rate schedules, warm-up strategies.
- Regularisation: Dropout, batch normalisation, layer normalisation, weight decay, early stopping.
- PyTorch Core: Tensors, autograd, custom Datasets and DataLoaders, training loop, checkpointing.
- Convolutional Neural Networks: Convolution operation, pooling, stride/padding, classic architectures (LeNet, VGG, ResNet).
- Recurrent Networks: RNN, LSTM, GRU — sequential modelling, vanishing gradient in time.

Topic Projects:
- (Neural Network Fundamentals) Implement a 3-layer MLP in pure NumPy with vectorised forward pass and backpropagation; verify outputs and gradients match PyTorch's nn.Linear layers.
- (Backpropagation) Build a scalar-valued autograd engine following Karpathy's micrograd; trace the computation graph for a small net and verify every gradient by finite differences.
- (Optimisers) Implement SGD with momentum, Adam, and AdaGrad from scratch; compare convergence speed and final loss on CIFAR-10 using an identical architecture for each.
- (Regularisation) Train a deep network on a small dataset with and without dropout, batch norm, and weight decay; plot train/val loss curves to isolate each regulariser's effect on overfitting.
- (PyTorch Core) Build a custom Dataset and DataLoader for an image folder with on-the-fly augmentation; profile throughput with different num_workers and pin_memory settings.
- (Convolutional Neural Networks) Implement a ResNet block with skip connections from scratch; train a 20-layer ResNet on CIFAR-10 and confirm skip connections improve convergence vs. a plain net.
- (Recurrent Networks) Implement an LSTM cell from scratch, validate against PyTorch's nn.LSTM, and train a character-level language model on a Shakespeare excerpt.
- GPU cost modelling: estimate training time and Azure GPU SKU cost before starting a run; define stopping criteria and budget alerts.
- Trade-off analysis: CNN vs. transformer for vision tasks at different data scales and latency budgets.

Target Certification:
- Continue DP-100 study; target exam at end of Phase 6.

Small Project:
- Implement a two-layer MLP from scratch in NumPy (forward pass, backprop, mini-batch SGD) on MNIST, then replicate with PyTorch to validate.

Medium Project:
- Image classifier on CIFAR-10: custom CNN architecture, learning rate finder, mixed-precision training, TensorBoard logging, and error analysis on worst predictions.

Ambitious Project:
- Time-series anomaly detector: LSTM autoencoder trained on normal behaviour, reconstruction error threshold tuning, deployed as a REST API on Azure Container Instances.

Resources:
- "Deep Learning" — Goodfellow, Bengio, Courville (free online; Chapters 6–9).
- PyTorch official tutorials (pytorch.org/tutorials).
- "Deep Learning with PyTorch" — Stevens, Antiga, Viehmann (Manning).
- fast.ai "Practical Deep Learning for Coders" Part 1 (fast.ai, free).
- Andrej Karpathy "Neural Networks: Zero to Hero" YouTube series.

Notes:
- Build Karpathy's micrograd (minimal autograd engine) before using PyTorch — this single exercise cements backpropagation permanently.

----------------------------------------------------------------------
PHASE 5: NLP, Computer Vision & Transfer Learning (Weeks 21–26)
----------------------------------------------------------------------
Goal: Apply deep learning to real-world NLP and CV tasks by fine-tuning pre-trained models, mastering the transformer architecture, and shipping end-to-end inference systems.

Difficulty: Advanced

Prerequisites: Phase 4 complete; PyTorch comfortable.

Time Commitment: ~18 hrs/week

Key Topics:
- Transformer Architecture: Self-attention, multi-head attention, positional encoding, encoder-decoder design — implement a mini transformer from scratch.
- Hugging Face Ecosystem: Tokenisers, AutoModel, AutoTokenizer, Trainer API, datasets library, PEFT (LoRA, QLoRA) for efficient fine-tuning.
- NLP Tasks: Text classification, NER, question answering, summarisation, translation — task-specific heads on BERT/RoBERTa/T5.
- Computer Vision: Object detection (YOLO, DETR), semantic segmentation, vision transformers (ViT), fine-tuning torchvision models.
- Transfer Learning Strategies: Feature extraction vs. full fine-tuning vs. LoRA; dataset size rules of thumb.
- Azure AI Cognitive Services: Vision, Language, and OpenAI services — when to use managed APIs vs. custom models.
- Evaluation & Ethics: BLEU, ROUGE for NLP; mAP, IoU for CV; bias auditing and responsible AI practices.

Topic Projects:
- (Transformer Architecture) Implement multi-head self-attention and a transformer encoder block from scratch in PyTorch; verify outputs match Hugging Face's equivalent layer on the same input tensor.
- (Hugging Face Ecosystem) Fine-tune a BERT model using the Trainer API with LoRA on a custom text classification dataset; log metrics to TensorBoard and evaluate on a held-out test set.
- (NLP Tasks) Build a named entity recognition pipeline with a fine-tuned RoBERTa model; report per-entity-type F1 and compare with a spaCy rule-based baseline.
- (Computer Vision) Fine-tune a ViT on a 10-class image dataset; compare convergence speed and final accuracy vs. a fine-tuned ResNet-50 with identical training budget.
- (Transfer Learning Strategies) Compare full fine-tuning vs. LoRA vs. feature extraction of a BERT model on a small labelled dataset; plot accuracy vs. number of trainable parameters.
- (Azure AI Cognitive Services) Build a document processing pipeline using Azure Form Recogniser; compare key-value extraction accuracy vs. a custom-trained model on the same 50-document test set.
- (Evaluation & Ethics) Audit a fine-tuned sentiment model for demographic bias using subgroup performance analysis across gender and age; document findings in a model card.
- Build vs. buy decision framework: custom fine-tuned model vs. Azure Cognitive Services vs. Azure OpenAI API, with cost and latency modelling.
- Design multi-modal systems: define data contracts between vision and language components.

Target Certification:
- Microsoft Azure AI Apps and Agents Developer Associate (AI-103) — primary focus; sit exam during Weeks 25–26.

Small Project:
- Sentiment analysis API: fine-tune DistilBERT on a domain-specific dataset, serve with FastAPI, containerise with Docker.

Medium Project:
- Document intelligence pipeline: combine Azure Form Recogniser + custom NER model to extract structured fields from scanned invoices and store in Azure Cosmos DB.

Ambitious Project:
- Multi-lingual product catalogue enrichment system: fine-tune a multilingual T5 model to generate SEO descriptions from structured attributes, deployed on Azure Container Apps with auto-scaling.

Resources:
- "Natural Language Processing with Transformers" — Lewis Tunstall et al. (O'Reilly).
- Hugging Face documentation (huggingface.co/docs).
- Azure AI Services documentation (learn.microsoft.com/azure/ai-services).
- Andrej Karpathy "Let's build GPT" YouTube video.

Notes:
- AI-102 exam covers Azure AI services broadly; allocate one dedicated week of Microsoft Learn paths before sitting it.

----------------------------------------------------------------------
PHASE 6: Azure ML Platform & MLOps (Weeks 27–32)
----------------------------------------------------------------------
Goal: Operationalise ML models end-to-end on Azure with automated training pipelines, experiment tracking, model registry, CI/CD, monitoring, and responsible AI tooling.

Difficulty: Advanced

Prerequisites: Phase 5 complete; Docker and Git CI/CD from software engineering background.

Time Commitment: ~18 hrs/week

Key Topics:
- Azure Machine Learning: Workspaces, compute clusters, environments, datasets, jobs — full SDK v2 and CLI v2 workflows.
- ML Pipelines: Component-based pipelines in Azure ML, DAG orchestration, pipeline scheduling.
- Experiment Tracking & Model Registry: MLflow on Azure ML, run comparison, model versioning, stage transitions (staging → production).
- Model Deployment: Managed online endpoints (real-time), batch endpoints, blue/green deployments, canary rollouts.
- CI/CD for ML: GitHub Actions + Azure ML for automated retraining triggers, model evaluation gates, and deployment promotion.
- Monitoring & Drift Detection: Data drift, concept drift, Azure Monitor integration, alerting strategies.
- Responsible AI Dashboard: Fairness assessment, error analysis, SHAP explainability, causal analysis in Azure ML.
- Cost & Governance: Compute quotas, auto-pause policies, tagging strategy for ML cost attribution.

Topic Projects:
- (Azure Machine Learning) Submit an Azure ML command job with a custom environment and GPU compute cluster; compare wall-clock time and cost vs. local training on the same dataset.
- (ML Pipelines) Build a 3-step Azure ML component pipeline: data validation → training → evaluation; schedule it to run weekly and verify the output model artefact.
- (Experiment Tracking & Model Registry) Track 10 training runs with MLflow parameters and metrics; compare runs in the Azure ML UI and promote the best model from staging to production.
- (Model Deployment) Deploy a model to an Azure ML managed online endpoint with blue/green deployment; run a load test and verify the endpoint meets a 200ms P95 latency SLA.
- (CI/CD for ML) Build a GitHub Actions workflow that triggers retraining when new data arrives, evaluates the candidate model, and promotes it only if accuracy improves by ≥1%.
- (Monitoring & Drift Detection) Set up Azure Monitor data drift detection on a deployed endpoint; simulate drift by shifting input feature distributions and verify the alert fires within the expected window.
- (Responsible AI Dashboard) Run the Azure ML Responsible AI dashboard on a loan approval model; document at least two fairness issues found and propose concrete mitigations.
- (Cost & Governance) Configure compute quota limits, auto-pause policies, and cost alert budgets in an Azure ML workspace; produce a monthly training cost estimate.
- Design a three-tier ML environment (dev/staging/prod) with access controls, network isolation (private endpoints, VNet injection), and audit logging.
- Define an MLOps maturity model assessment: score an organisation's current state and produce a roadmap to fully automated retraining and monitoring.

Target Certification:
- Microsoft Machine Learning Operations Engineer Associate (AI-300) — sit exam during Weeks 31–32.

Small Project:
- Automated retraining pipeline: weekly Azure ML pipeline job that retrains a classification model, evaluates against a baseline, and registers the model only if it passes a quality gate.

Medium Project:
- Full MLOps cycle: GitHub Actions CI/CD for a tabular model — lint, unit test, train, evaluate, deploy to a managed online endpoint, and smoke test in under 30 minutes.

Ambitious Project:
- ML platform blueprint: Terraform IaC for Azure ML workspace + supporting services (Key Vault, Storage, Container Registry, Log Analytics), with RBAC assignments, network policies, and a runbook.

Resources:
- Microsoft Learn "Azure Machine Learning" learning path (free, official).
- "Practical MLOps" — Noah Gift, Alfredo Deza (O'Reilly).
- Azure ML SDK v2 and CLI v2 documentation (learn.microsoft.com/azure/machine-learning).
- "Designing Machine Learning Systems" — Chip Huyen (O'Reilly).
- MLflow documentation (mlflow.org).

Notes:
- Leverage your existing software engineering skills heavily here — CI/CD, IaC, and observability patterns transfer directly. This is where engineers typically outpace data scientists.

----------------------------------------------------------------------
PHASE 7: Advanced ML, Generative AI & Capstone (Weeks 33–40)
----------------------------------------------------------------------
Goal: Explore research-grade ML topics including reinforcement learning, generative models, and LLM applications, then synthesise all learning into a portfolio-grade capstone project.

Difficulty: Expert

Prerequisites: Phases 1–6 complete.

Time Commitment: ~20 hrs/week

Key Topics:
- Reinforcement Learning: Markov decision processes, Q-learning, DQN, policy gradient (REINFORCE), actor-critic (PPO, SAC) — OpenAI Gymnasium environments.
- Generative Models: Variational Autoencoders (VAE), GANs (StyleGAN), diffusion models (DDPM, Stable Diffusion architecture overview).
- Large Language Models in Depth: GPT architecture, pre-training vs. fine-tuning vs. RLHF, RAG (retrieval-augmented generation), agents and tool use.
- Azure OpenAI & Semantic Kernel: Deploying GPT-4o, orchestrating multi-step AI workflows, prompt engineering, function calling, evaluation with Microsoft Foundry.
- ML Research Literacy: How to read papers, identify strong vs. weak empirical claims, reproduce a paper result.
- Scalable ML Systems: Distributed training (DDP with PyTorch), model parallelism, quantisation (INT8/FP16), ONNX export, TensorRT optimisation.
- Real-World Problem Solving: Framing a business problem as an ML task, stakeholder communication, iterative delivery.

Topic Projects:
- (Reinforcement Learning) Train DQN on CartPole and LunarLander; plot reward curves and analyse the impact of replay buffer size and target-network update frequency on sample efficiency.
- (Generative Models) Train a conditional DDPM on MNIST from scratch; implement DDIM sampling and compare image quality (FID) at 10, 50, and 1000 denoising steps.
- (Large Language Models in Depth) Reproduce the GPT-2 architecture following Karpathy’s nanoGPT; train on a 10MB text corpus and sample outputs at three temperature values.
- (Azure OpenAI & Semantic Kernel) Build a multi-step agent with tool use using Semantic Kernel and Azure OpenAI; the agent retrieves documents from Azure AI Search and synthesises a grounded answer.
- (ML Research Literacy) Reproduce a key ablation result from a published ML paper; document methodology, any deviations, and findings in a one-page research memo.
- (Scalable ML Systems) Train a model with PyTorch DDP on 2 GPUs; compare wall-clock time, GPU utilisation, and final accuracy vs. a single-GPU baseline.
- (Real-World Problem Solving) Frame a business problem of your choice as an ML task; produce a two-page problem framing document covering data requirements, success metrics, and a baseline approach.
- Design a GenAI application architecture: LLM selection, RAG vs. fine-tune decision, guardrails, grounding, latency/cost SLAs, and fallback strategy.
- Evaluate foundation model trade-offs across cost, capability, latency, data privacy, and regulatory constraints for enterprise deployments.

Target Certification:
- Optional stretch: AWS Certified Machine Learning Specialty (MLS-C01) or Google Professional Machine Learning Engineer for platform breadth.

Small Project:
- Train a DQN agent to play CartPole, plot training curves, and analyse failure modes.

Medium Project:
- RAG-based knowledge assistant: ingest a document corpus into Azure AI Search (vector index), connect Azure OpenAI GPT-4o, add streaming responses, and evaluate faithfulness and relevance with a custom evaluation harness.

Ambitious Project:
- Fine-tune a 7B parameter open-source LLM (Mistral or Phi-3) with LoRA on a domain-specific dataset using Azure ML, quantise to 4-bit, deploy as a streaming endpoint, and benchmark against the Azure OpenAI baseline on accuracy and cost-per-token.

Capstone Project:
- End-to-end ML product solving a real-life problem of your choice: problem definition, data collection plan, EDA, modelling (classical + deep learning comparison), MLOps pipeline on Azure, public-facing demo (Streamlit or React), a model card, and a 10-minute recorded walkthrough video.

Resources:
- "Reinforcement Learning: An Introduction" — Sutton & Barto, 2nd ed. (free PDF).
- "Generative Deep Learning" — David Foster, 2nd ed. (O'Reilly).
- "Build a Large Language Model (From Scratch)" — Sebastian Raschka (Manning).
- Hugging Face PEFT and TRL documentation for fine-tuning.
- Azure OpenAI and Azure AI Studio documentation (learn.microsoft.com/azure/ai-services/openai).
- Papers With Code (paperswithcode.com) for reproducible baselines.

Notes:
- Reserve the final 2 weeks exclusively for the Capstone Project. One exceptional portfolio project outweighs five shallow ones for job applications.

======================================================================
