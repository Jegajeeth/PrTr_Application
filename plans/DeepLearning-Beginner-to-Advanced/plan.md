======================================================================
DEEP LEARNING: BEGINNER TO ADVANCED (38-WEEK BLUEPRINT)
======================================================================

A companion deep-dive for engineers who have completed foundational ML (classical algorithms, NumPy, and basic PyTorch/CNNs/RNNs). Covers both PyTorch and TensorFlow/Keras across all major DL domains: CV, NLP, Generative AI, Audio, RL, and production LLM systems on Azure.

----------------------------------------------------------------------
PHASE 1: PyTorch & TensorFlow/Keras Mastery (Weeks 1–4)
----------------------------------------------------------------------
Goal: Move beyond basic PyTorch usage to expert-level proficiency in both PyTorch and TensorFlow/Keras, including custom autograd, compiler optimisations, and profiling.

Difficulty: Intermediate

Prerequisites: ML plan Phase 4 complete — MLP, CNN, RNN basics, and PyTorch fundamentals known.

Time Commitment: ~15 hrs/week

Key Topics:
- PyTorch Internals: Custom nn.Module, custom autograd functions, torch.func (vmap, grad, jacfwd), memory management, gradient checkpointing.
- torch.compile: TorchDynamo, TorchInductor, compilation modes (default, reduce-overhead, max-autotune), debugging compilation failures.
- TensorFlow/Keras Deep Dive: tf.GradientTape, @tf.function tracing, XLA compilation, custom training loops, Keras functional and subclassing APIs.
- Mixed Precision Training: AMP with torch.amp and Keras mixed_precision, BF16 vs FP16 trade-offs.
- Profiling & Debugging: PyTorch Profiler, TensorBoard, CUDA memory snapshots, identifying bottlenecks in data loading and forward/backward passes.
- Distributed Training Basics: DDP overview, FSDP motivation, when to use each.

Topic Projects:
- (PyTorch Internals) Write a custom autograd Function implementing the Mish activation; verify gradients with torch.autograd.gradcheck and benchmark throughput vs. the built-in ReLU.
- (torch.compile) Benchmark ResNet-50 training with and without torch.compile across three compile modes; report speedup percentages and memory delta.
- (TensorFlow/Keras Deep Dive) Reproduce a PyTorch CNN training loop using tf.GradientTape and @tf.function; verify loss curves converge identically on CIFAR-10.
- (Mixed Precision Training) Convert a training run to BF16 AMP in both PyTorch and Keras; measure throughput gain and peak memory reduction on the same GPU.
- (Profiling & Debugging) Use PyTorch Profiler to identify the top-3 bottlenecks in a custom DataLoader; eliminate them and report the resulting throughput improvement.
- (Distributed Training Basics) Launch a 2-process DDP job on a single machine; verify gradient synchronisation with allreduce hooks and measure throughput scaling vs. single-process.

Architect Skills:
- Framework selection decision tree: PyTorch vs TF/Keras based on ecosystem, deployment target (TFLite, ONNX, TorchScript), and team expertise.
- Establish a reproducibility checklist: seed management, deterministic ops, environment pinning.

Target Certification:
- Microsoft Azure AI Fundamentals (AI-901) — if not already earned from ML plan; lightweight Azure AI anchor.

Small Project:
- Implement a custom autograd function for a novel activation (e.g., Mish) and benchmark it against the standard PyTorch implementation using the Profiler.

Medium Project:
- Port a PyTorch training loop to TF/Keras and benchmark convergence, throughput, and GPU memory usage side-by-side on CIFAR-100.

Ambitious Project:
- Build a reusable training framework (like a mini PyTorch Lightning) that abstracts training loops, logging, checkpointing, and early stopping for both PyTorch and Keras models.

Resources:
- PyTorch official documentation: torch.compile, torch.func, and Profiler guides (pytorch.org/docs).
- TensorFlow official guide: Custom training walkthrough and performance guides (tensorflow.org/guide).
- Lilian Weng's blog "Some Tricks for Training Neural Networks" (lilianweng.github.io).
- "Programming PyTorch for Deep Learning" — Ian Pointer (O'Reilly).

Notes:
- torch.compile is stable in PyTorch 2.x and delivers 20–36% average speedups; understanding it is increasingly expected in production DL roles.

----------------------------------------------------------------------
PHASE 2: Advanced Computer Vision (Weeks 5–10)
----------------------------------------------------------------------
Goal: Master modern CNN architectures, real-time object detection, segmentation, self-supervised vision, and deploy vision models to production on Azure.

Difficulty: Advanced

Prerequisites: Phase 1 complete; basic CNNs from ML plan Phase 4.

Time Commitment: ~18 hrs/week

Key Topics:
- Modern Backbones: EfficientNet, ConvNeXt, NFNet — design principles, compound scaling, and when to use over ResNet.
- Vision Transformers: ViT, DeiT, Swin Transformer — patch embeddings, attention in vision, hierarchical features.
- Object Detection: YOLOv8/YOLOv9, DETR (end-to-end detection with transformers), DINO — anchor-free detection, non-maximum suppression.
- Segmentation: Mask R-CNN (instance), SegFormer (semantic), SAM (Segment Anything Model) — use cases and inference optimisation.
- Self-Supervised Vision: MAE (Masked Autoencoders), DINO, SimCLR — pre-training without labels, feature quality evaluation.
- Production Serving: ONNX export, TensorRT optimisation, Azure Machine Learning managed online endpoints for vision models.
- Data Augmentation: Albumentations, RandAugment, MixUp, CutMix — modern augmentation pipelines.

Topic Projects:
- (Modern Backbones) Fine-tune EfficientNet-B4 and ConvNeXt-Small on the same custom dataset; compare accuracy, FLOPs, inference latency, and GPU memory usage side-by-side.
- (Vision Transformers) Train a ViT-Small from scratch on CIFAR-100; visualise learned attention maps and compare with a fine-tuned Swin Transformer pre-trained on ImageNet.
- (Object Detection) Fine-tune YOLOv8 on a custom object detection dataset; evaluate mAP50 and mAP50-95; compare inference speed vs. DETR at the same accuracy threshold.
- (Segmentation) Segment arbitrary objects using SAM zero-shot; compare mask quality vs. a SegFormer fine-tuned with 50 labelled images on the same test set.
- (Self-Supervised Vision) Pre-train a ViT-Tiny using MAE on an unlabelled dataset; fine-tune with 1%, 10%, and 100% of labels; plot downstream accuracy vs. label fraction.
- (Production Serving) Export a fine-tuned EfficientNet to ONNX, optimise with TensorRT, and benchmark P50/P99 inference latency on CPU vs. GPU vs. the PyTorch baseline.
- (Data Augmentation) Compare baseline augmentation vs. RandAugment vs. MixUp+CutMix on CIFAR-100; plot validation accuracy vs. augmentation strength parameter.

Architect Skills:
- Select a detection architecture: YOLO (real-time, edge) vs. DETR (accuracy, complex scenes) vs. cloud API — with latency/accuracy/cost trade-off matrix.
- Design a vision data pipeline at scale: Azure Blob Storage, Azure ML Datasets, streaming DataLoader, and label versioning strategy.

Target Certification:
- Continue AI-901 study if not yet earned, or begin AI-103 (Azure AI Apps and Agents Developer Associate) study.

Small Project:
- Fine-tune a Swin Transformer on a custom 10-class dataset and compare vs. a ResNet baseline; evaluate with confusion matrix and Grad-CAM visualisations.

Medium Project:
- Real-time object detection microservice: YOLOv8 fine-tuned on a custom dataset, containerised with Docker, deployed to Azure Container Apps with autoscaling and latency monitoring.

Ambitious Project:
- Defect detection system: self-supervised MAE pre-training on unlabelled production images, fine-tune with a small labelled set, compare vs. supervised-only baseline, deploy with Azure ML batch endpoint for nightly inference.

Resources:
- Ultralytics YOLOv8 documentation (docs.ultralytics.com).
- "An Image is Worth 16x16 Words" — Dosovitskiy et al. (ViT paper, arxiv.org).
- Hugging Face Transformers documentation — vision models (huggingface.co/docs/transformers).
- Microsoft Azure Computer Vision documentation (learn.microsoft.com/azure/ai-services/computer-vision).

Notes:
- SAM (Segment Anything) has become a standard labelling accelerator; integrating it into your pipeline immediately impresses in interviews.

----------------------------------------------------------------------
PHASE 3: NLP & Transformer Architecture in Depth (Weeks 11–16)
----------------------------------------------------------------------
Goal: Implement the transformer from scratch, master fine-tuning the full BERT/GPT/T5 family, and build production NLP pipelines with efficient attention.

Difficulty: Advanced

Prerequisites: Phase 2 complete; ML plan Phase 5 NLP basics helpful but not required.

Time Commitment: ~18 hrs/week

Key Topics:
- Transformer from Scratch: Multi-head attention, positional encoding, encoder-decoder with masking; train a character-level model following Karpathy's nanoGPT.
- BERT Family: RoBERTa, DeBERTa, ALBERT — pre-training objectives, tokenisation strategies, fine-tuning for classification, NER, QA, and span extraction.
- Autoregressive Models: GPT-2 architecture, causal attention mask, sampling strategies (top-k, top-p, temperature, beam search).
- Sequence-to-Sequence: T5, mT5, BART — encoder-decoder for summarisation, translation, and data-to-text.
- Efficient Attention: Flash Attention 2 (integrated in PyTorch 2.x via scaled_dot_product_attention), Longformer, BigBird — handling long contexts.
- Hugging Face Advanced: Custom model heads, Trainer callbacks, DeepSpeed integration with Trainer, model merging (SLERP, TIES).
- PEFT Methods: LoRA, QLoRA (4-bit quantisation), IA³, prefix tuning — when each is appropriate.

Topic Projects:
- (Transformer from Scratch) Implement nanoGPT following Karpathy; train on a 10MB text corpus; extend positional encoding with RoPE and compare perplexity vs. learned absolute embeddings.
- (BERT Family) Fine-tune DeBERTa-v3-base on a domain-specific NER task; evaluate per-entity-class F1 and compare with a spaCy rule-based baseline on the same test set.
- (Autoregressive Models) Sample from GPT-2-small with five decoding strategies (greedy, top-k, top-p, beam search, contrastive); score outputs with MAUVE and human preference.
- (Sequence-to-Sequence) Fine-tune mBART on a low-resource translation pair (e.g., English→Welsh); evaluate BLEU and chrF; compare with a cloud translation API on the same test set.
- (Efficient Attention) Measure GPU memory and wall-clock time for standard attention vs. Flash Attention 2 (PyTorch SDPA) on sequences of length 512, 2048, and 8192 tokens.
- (Hugging Face Advanced) Implement a custom Trainer callback that performs early stopping based on a composite metric; test on a multi-label classification task.
- (PEFT Methods) Compare LoRA (r=8), QLoRA (4-bit), and full fine-tuning of a 1.5B model; report accuracy, GPU memory, and training time; produce a cost-per-experiment table.

Architect Skills:
- Design a multilingual NLP system: language detection, shared vs. language-specific heads, evaluation across languages.
- Build a model size vs. latency vs. accuracy trade-off document for encoder, decoder, and encoder-decoder architectures at different parameter scales.

Target Certification:
- Microsoft Azure AI Apps and Agents Developer Associate (AI-103) — primary focus; sit exam during Weeks 15–16.

Small Project:
- Implement nanoGPT from scratch, train on a small text corpus, and extend with rotary positional embeddings (RoPE).

Medium Project:
- Domain-specific QA system: fine-tune DeBERTa on a SQuAD-style dataset from your domain, add a BM25 + dense retrieval layer, serve via FastAPI with streaming tokens.

Ambitious Project:
- Multilingual summarisation service: fine-tune mT5 with LoRA on a multilingual summarisation dataset, deploy to Azure Container Apps with language auto-detection, evaluate ROUGE across five languages.

Resources:
- "Natural Language Processing with Transformers" — Lewis Tunstall et al. (O'Reilly).
- Andrej Karpathy "Let's build GPT" and nanoGPT repository (github.com/karpathy/nanoGPT).
- Hugging Face PEFT documentation (huggingface.co/docs/peft).
- "Attention Is All You Need" — Vaswani et al. (original transformer paper, arxiv.org).

Notes:
- QLoRA (Dettmers et al.) changed the economics of fine-tuning — a 7B model fine-tuned on a single consumer GPU. Understanding this technique is now a baseline expectation.

----------------------------------------------------------------------
PHASE 4: Generative Models (Weeks 17–22)
----------------------------------------------------------------------
Goal: Understand and implement the major generative modelling paradigms — VAEs, GANs, and diffusion models — and build systems that generate images, text, and structured data.

Difficulty: Advanced

Prerequisites: Phase 3 complete.

Time Commitment: ~18 hrs/week

Key Topics:
- Variational Autoencoders: ELBO derivation, reparameterisation trick, beta-VAE for disentangled representations, VQ-VAE for discrete latent spaces.
- GANs: Original GAN loss, training instabilities (mode collapse, vanishing gradients), WGAN-GP, progressive growing, StyleGAN2/3 architecture.
- Score-Based & Diffusion Models: DDPM (forward/reverse process, noise schedule), DDIM (accelerated sampling), classifier-free guidance, latent diffusion (Stable Diffusion architecture).
- Consistency Models: Consistency training and distillation for single-step generation.
- Evaluation Metrics: FID, KID, IS for image quality; CLIP score for text-image alignment; coverage and density metrics.
- Conditional Generation: Conditioning on class labels, text prompts, and reference images; ControlNet for spatial conditioning.
- Azure Integration: Azure Machine Learning for large-scale training jobs; Azure Container Registry for serving diffusion models.

Topic Projects:
- (Variational Autoencoders) Train a beta-VAE on CelebA; sweep beta values and visualise disentangled facial attributes (pose, smile, age) in the 2D latent space.
- (GANs) Train a DCGAN and a WGAN-GP on a 10K-image dataset; compare FID scores; document each training instability encountered and how you resolved it.
- (Score-Based & Diffusion Models) Implement DDPM from scratch on MNIST; add DDIM sampler; benchmark FID vs. sample steps at 10, 50, and 1000.
- (Consistency Models) Fine-tune a pre-trained consistency model on a custom style dataset; compare single-step image quality vs. a 50-step DDIM run using FID and human preference.
- (Evaluation Metrics) Compute FID, KID, and CLIP score for images generated by three different generative models; discuss which metric best correlates with human preference on your dataset.
- (Conditional Generation) Add ControlNet conditioning to a diffusion model; demonstrate edge-map guided generation on 10 test images and document failure modes.
- (Azure Integration) Run a diffusion model fine-tuning job on Azure ML with GPU compute; track experiments with MLflow and register the best checkpoint in the model registry.

Architect Skills:
- Generative model selection: VAE (latent structure, interpolation) vs. GAN (perceptual quality) vs. diffusion (diversity, controllability) — cost, latency, and quality trade-offs.
- Data governance for generative AI: consent, synthetic data validation, and bias amplification risks.

Target Certification:
- Continue AI-103 study if not yet completed, or begin AI-300 (Machine Learning Operations Engineer Associate) study.

Small Project:
- Train a conditional DDPM on MNIST from scratch, implement DDIM sampling, and visualise the denoising trajectory.

Medium Project:
- Fine-tune Stable Diffusion with DreamBooth or LoRA on a custom image set; serve inference via a Gradio UI containerised on Azure Container Apps.

Ambitious Project:
- Tabular data synthesiser: train a conditional VAE and a conditional CTGAN on a real tabular dataset, evaluate statistical fidelity (TVD, correlation preservation, downstream ML utility), and document privacy risks.

Resources:
- "Generative Deep Learning" — David Foster, 2nd ed. (O'Reilly).
- "Denoising Diffusion Probabilistic Models" — Ho et al. (DDPM paper, arxiv.org).
- Hugging Face Diffusers documentation (huggingface.co/docs/diffusers).
- fast.ai Part 2: "From Deep Learning Foundations to Stable Diffusion" (course.fast.ai, free).

Notes:
- The diffusion model ecosystem moves fast; follow Hugging Face Diffusers release notes as your primary signal for new capabilities.

----------------------------------------------------------------------
PHASE 5: Audio & Speech Deep Learning (Weeks 23–26)
----------------------------------------------------------------------
Goal: Build automatic speech recognition, text-to-speech, and audio classification systems using modern deep learning, and integrate with Azure Speech Services.

Difficulty: Advanced

Prerequisites: Phase 3 complete (NLP and transformers); Phase 4 helpful but not required.

Time Commitment: ~15 hrs/week

Key Topics:
- Audio Fundamentals: Waveform representation, STFT, mel spectrograms, MFCCs — librosa for feature extraction and visualisation.
- Self-Supervised Audio: wav2vec 2.0 and HuBERT — contrastive pre-training, quantised speech representations, fine-tuning for ASR and speaker recognition.
- Whisper: Architecture, zero-shot multilingual ASR, fine-tuning on custom accents and domains with Hugging Face Transformers.
- Text-to-Speech: FastSpeech 2, VITS end-to-end TTS, Bark and other neural TTS — voice cloning considerations and ethics.
- Audio Classification: Environmental sound classification, music genre classification, keyword spotting — CNNs on spectrograms vs. audio transformers (AST).
- Azure Speech Services: Real-time speech-to-text, custom speech models, neural TTS, speaker recognition — managed service vs. custom model trade-offs.

Topic Projects:
- (Audio Fundamentals) Build a spectrogram feature extractor with librosa; compare STFT, mel, and MFCC representations for a speech vs. music binary classification task.
- (Self-Supervised Audio) Fine-tune HuBERT-Base on a 1-hour speech dataset for keyword spotting; compare word error rate vs. a supervised-only baseline trained on the same data.
- (Whisper) Fine-tune Whisper-small on a 2-hour domain-specific corpus (e.g., medical dictation); evaluate WER before and after fine-tuning; compare with the Azure Speech custom model endpoint.
- (Text-to-Speech) Fine-tune VITS on 30 minutes of target-speaker audio; evaluate MOS using a proxy model; document voice cloning ethical considerations and safeguards.
- (Audio Classification) Train an Audio Spectrogram Transformer (AST) for environmental sound classification on ESC-50; compare accuracy vs. a CNN-on-mel-spectrogram baseline.
- (Azure Speech Services) Build a real-time meeting transcription app using Azure Speech SDK with speaker diarisation; measure latency, accuracy, and cost vs. self-hosted Whisper.

Architect Skills:
- Audio pipeline architecture: streaming vs. batch ASR, latency SLA trade-offs, punctuation restoration and inverse text normalisation post-processing.
- Responsible AI for voice: consent for voice cloning, deepfake audio detection, GDPR implications for voice biometrics.

Target Certification:
- Microsoft Azure AI Apps and Agents Developer Associate (AI-103) covers Azure Speech — review speech service sections if not yet passed.

Small Project:
- Fine-tune Whisper (small) on a 1-hour custom-domain audio dataset; evaluate WER before and after fine-tuning.

Medium Project:
- Real-time meeting transcription service: Whisper + Azure Speech SDK, speaker diarisation, punctuation restoration, export to structured JSON with timestamps; containerised on Azure Container Apps.

Ambitious Project:
- End-to-end voice assistant: speech recognition (Whisper) → intent classification (fine-tuned BERT) → response generation (Azure OpenAI) → TTS (VITS) → streaming audio output; deployed as an Azure Container App.

Resources:
- Hugging Face Audio course (huggingface.co/learn/audio-course, free).
- "Whisper: Robust Speech Recognition via Large-Scale Weak Supervision" — Radford et al. (arxiv.org).
- librosa documentation (librosa.org).
- Azure Speech Services documentation (learn.microsoft.com/azure/ai-services/speech-service).

Notes:
- Azure Speech Services cover 90% of production ASR use cases. Custom Whisper fine-tuning adds value in niche domains (medical, legal, low-resource languages) where managed models underperform.

----------------------------------------------------------------------
PHASE 6: Reinforcement Learning (Weeks 27–32)
----------------------------------------------------------------------
Goal: Progress from tabular RL through deep Q-networks to modern policy gradient and actor-critic algorithms, and apply RL to real-world sequential decision problems.

Difficulty: Expert

Prerequisites: Phases 1–3 complete; solid PyTorch; linear algebra and probability from ML plan Phase 1.

Time Commitment: ~20 hrs/week

Key Topics:
- Foundations Recap: MDPs, Bellman equations, value iteration, policy iteration, temporal difference learning (Q-learning, SARSA).
- Deep Q-Networks: DQN, Double DQN, Dueling DQN, Prioritised Experience Replay, Rainbow — Atari benchmarks.
- Policy Gradient Methods: REINFORCE, baseline subtraction, Actor-Critic (A2C/A3C).
- Modern Actor-Critic: PPO (clipped surrogate objective), SAC (maximum entropy RL), TD3 (twin delayed DDPG).
- Model-Based RL: Dyna, World Models, Dreamer V3 — planning in latent space.
- Multi-Agent RL: Independent learners, CTDE (centralised training decentralised execution), QMIX basics.
- RL for LLMs: RLHF pipeline overview, reward modelling, PPO for language fine-tuning, DPO as a simpler alternative.

Topic Projects:
- (Foundations Recap) Implement tabular Q-learning and SARSA on FrozenLake-v1; visualise Q-table convergence and compare on-policy vs. off-policy behaviour across 10 random seeds.
- (Deep Q-Networks) Compare DQN, Double DQN, Dueling DQN, and DQN+PER on LunarLander-v2; plot learning curves and sample efficiency; quantify each improvement's contribution.
- (Policy Gradient Methods) Implement REINFORCE with and without a learned baseline; compare variance of policy gradient estimates over 5 seeds on CartPole; plot the variance reduction effect.
- (Modern Actor-Critic) Train PPO and SAC on HalfCheetah-v4 using Stable Baselines 3; compare final reward, sample efficiency, and wall-clock training time.
- (Model-Based RL) Implement a Dyna-Q agent (tabular); compare data efficiency vs. pure model-free Q-learning on a gridworld; sweep the number of planning steps (1, 10, 50).
- (Multi-Agent RL) Train two QMIX agents in a cooperative 2-agent Gymnasium environment; visualise emergent cooperative behaviour and compare vs. two independent DQN agents.
- (RL for LLMs) Fine-tune GPT-2 on a sentiment-positive generation task using PPO from TRL; compare RLHF output quality vs. SFT-only and vanilla GPT-2 using reward model scores.

Architect Skills:
- RL applicability assessment: when RL is appropriate vs. simpler supervised/search methods — sample efficiency, reward engineering risks, safety constraints.
- Design a reward function: identify reward shaping pitfalls (specification gaming, reward hacking) and mitigation strategies.

Target Certification:
- Microsoft Machine Learning Operations Engineer Associate (AI-300) — primary focus; sit exam during Weeks 31–32.

Small Project:
- Train DQN, Double DQN, and Dueling DQN on LunarLander-v2; plot learning curves, compare sample efficiency, and analyse failure modes.

Medium Project:
- PPO agent for a custom Gymnasium environment simulating a real-world scheduling problem (e.g., server resource allocation); train, evaluate, and visualise policy behaviour.

Ambitious Project:
- RLHF toy pipeline: train a reward model on human preference pairs, then fine-tune a small language model (GPT-2) using PPO from the TRL library; compare output quality vs. SFT-only baseline.

Resources:
- "Reinforcement Learning: An Introduction" — Sutton & Barto, 2nd ed. (free PDF at incompleteideas.net).
- CleanRL documentation and implementations (cleanrl.dev).
- Stable Baselines 3 documentation (stable-baselines3.readthedocs.io).
- Hugging Face TRL documentation for RLHF (huggingface.co/docs/trl).
- David Silver RL lecture series (YouTube, UCL/DeepMind).

Notes:
- DPO (Direct Preference Optimisation) has largely replaced PPO for LLM fine-tuning in practice due to its simplicity. Cover both but prioritise understanding DPO for industry relevance.

----------------------------------------------------------------------
PHASE 7: LLMs, Fine-Tuning & Production DL Systems (Weeks 33–38)
----------------------------------------------------------------------
Goal: Understand LLM internals and the full fine-tuning ecosystem, build production-grade inference systems, and design scalable DL infrastructure on Azure using Microsoft Foundry.

Difficulty: Expert

Prerequisites: Phases 1–6 complete.

Time Commitment: ~20 hrs/week

Key Topics:
- LLM Architecture in Depth: Rotary positional embeddings (RoPE), grouped query attention (GQA), SwiGLU activation, KV cache, speculative decoding — how Llama/Mistral/Phi differ from GPT-2.
- Pre-Training at Scale: Data curation pipelines (deduplication, quality filtering), BPE/SentencePiece tokenisers from scratch, distributed training with FSDP and DeepSpeed ZeRO stages.
- Advanced Fine-Tuning: SFT (supervised fine-tuning), DPO, ORPO, merge methods (SLERP, TIES-merging for model soups).
- Inference Optimisation: Quantisation (GPTQ, AWQ, bitsandbytes INT4), vLLM for high-throughput serving, PagedAttention, continuous batching.
- ONNX & TensorRT: Export PyTorch models, optimise for latency, deploy on Azure GPU endpoints.
- Microsoft Foundry: Azure OpenAI deployments (GPT-4o, o-series), model catalogue, Semantic Kernel for agent orchestration, Prompt Flow for evaluation, responsible AI tooling.
- DL System Design: Estimate GPU requirements for training and inference; design a model serving system for 100K RPM; cost modelling for batch vs. real-time inference.

Topic Projects:
- (LLM Architecture in Depth) Annotate the Llama-3 architecture diagram (RoPE, GQA, SwiGLU, RMSNorm); implement RoPE and GQA from scratch and verify outputs match the reference implementation.
- (Pre-Training at Scale) Train a 10M parameter GPT-2-scale model from scratch on a deduplicated Wikipedia slice; track training loss, perplexity, and GPU throughput (tokens/second).
- (Advanced Fine-Tuning) Compare SFT, DPO, and ORPO on a 1B model using an instruction dataset; evaluate win-rate against the SFT baseline using GPT-4o as an automated judge.
- (Inference Optimisation) Benchmark a 7B model with bitsandbytes INT4, GPTQ, and AWQ quantisation; report perplexity, tokens/second, and GPU memory at batch sizes 1, 8, and 32.
- (ONNX & TensorRT) Export a fine-tuned DistilBERT to ONNX, optimise with TensorRT, deploy to an Azure ML managed online endpoint; benchmark P50/P99 latency vs. PyTorch baseline.
- (Microsoft Foundry) Build a multi-turn agent with tool use using Semantic Kernel and Azure OpenAI; evaluate task completion rate and faithfulness on 20 user scenarios using Prompt Flow.
- (DL System Design) Produce a design document for a model serving system targeting 100K RPM: GPU selection, batching strategy, autoscaling policy, cost estimate, and SLA analysis.

Architect Skills:
- Foundation model strategy: build vs. fine-tune vs. RAG vs. API — decision framework with cost/latency/privacy/compliance axes for enterprise deployments.
- Design a model governance process: versioning, A/B deployment, rollback strategy, drift detection, and audit logging for regulated industries.

Target Certification:
- Microsoft Machine Learning Operations Engineer Associate (AI-300) — sit exam if not taken in Phase 6.
- Optional stretch: AWS Certified Machine Learning Specialty (MLS-C01) or Google Professional Machine Learning Engineer for platform breadth.

Small Project:
- Benchmark inference throughput of a 7B model using three serving strategies: naive PyTorch, quantised (INT4 via bitsandbytes), and vLLM; plot tokens/second vs. batch size.

Medium Project:
- Production RAG system on Azure: ingest a 500-document corpus into Azure AI Search (vector index with hybrid retrieval), connect Azure OpenAI GPT-4o with streaming, add evaluation harness (faithfulness, relevance, groundedness) using Microsoft Foundry Prompt Flow.

Ambitious Project:
- Fine-tune a 7B open-source LLM (Mistral-7B or Phi-3) with QLoRA on a domain-specific instruction dataset using Azure ML, merge adapters, quantise to AWQ INT4, deploy via vLLM on an Azure ML managed online endpoint, and produce a full cost-per-token analysis vs. Azure OpenAI baseline.

Capstone Project:
- End-to-end DL product solving a real-world problem: combines at least two DL domains from this plan (e.g., vision + NLP, speech + RL), uses Microsoft Foundry or Azure ML for training and deployment, includes a model card, responsible AI assessment, a public Streamlit or React demo, and a 10-minute recorded walkthrough video.

Resources:
- "Build a Large Language Model (From Scratch)" — Sebastian Raschka (Manning).
- vLLM documentation (docs.vllm.ai).
- Hugging Face TRL and PEFT documentation for advanced fine-tuning.
- Microsoft Foundry documentation (learn.microsoft.com/azure/ai-foundry).
- "The Illustrated Transformer" — Jay Alammar (jalammar.github.io).
- LLM360 and OLMo open pre-training documentation for pre-training at scale.

Notes:
- Reserve the final two weeks for the Capstone Project. One exceptional portfolio project outweighs five shallow ones for job applications and research portfolios.

======================================================================
