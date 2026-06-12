<div align="center">

# 🐤 Flappy Bird With Unity

### A from-scratch Unity recreation of the classic Flappy Bird — built as a learning challenge

![Unity](https://img.shields.io/badge/Unity-2019.4+-000000?style=for-the-badge&logo=unity&logoColor=white)
![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white)
![Platform](https://img.shields.io/badge/Platform-Windows%20%7C%20Android-blue?style=for-the-badge&logo=android&logoColor=white)
![License](https://img.shields.io/badge/License-MIT-green?style=for-the-badge)
![Forks](https://img.shields.io/github/forks/TheODDYSEY/Flappy-Bird-Unity?style=for-the-badge&color=orange)
![Stars](https://img.shields.io/github/stars/TheODDYSEY/Flappy-Bird-Unity?style=for-the-badge&color=yellow)

[![Forks](https://img.shields.io/github/forks/TheODDYSEY/Flappy-Bird-Unity?style=for-the-badge&color=orange&logo=github)](https://github.com/TheODDYSEY/Flappy-Bird-Unity/network/members)

</div>

---

## 🎮 Demo

<div align="center">

![Gameplay](https://github.com/TheODDYSEY/Flappy-Bird-Unity/raw/main/gameplay.gif)

*Tap or press Space — survive as long as you can*

</div>

---

## 📖 About

**Flappy Bird With Unity** is a full recreation of the iconic Flappy Bird game, built entirely in Unity from scratch with no prior game development experience. The project was initiated as a personal challenge to learn Unity and C# by building something recognizable and fun.

Every mechanic — physics, pipe generation, collision, score tracking, audio — was implemented from the ground up as part of the learning process.

---

## ✨ Features

- 🐦 **Physics-based bird movement** — realistic gravity and flap impulse using Unity's Rigidbody2D
- 🟩 **Procedural pipe spawning** — randomly generated gaps keep every run unique
- 💥 **Collision detection** — game ends on pipe or ground contact
- 🔢 **Score tracking** — increments each time the bird clears a pipe gap
- 🔊 **Sound effects & music** — flap, score, and death sounds via Unity AudioSource
- 🖱️ **Dual input support** — mouse click or spacebar to flap
- 🔁 **Instant restart** — jump back in immediately after death

---

## 🕹️ Controls

| Input | Action |
|---|---|
| `Left Mouse Click` | Flap wings |
| `Spacebar` | Flap wings |

---

## 🛠️ Tech Stack

| Technology | Role |
|---|---|
| ![Unity](https://img.shields.io/badge/Unity-000000?logo=unity&logoColor=white) | Game engine, physics, scene management |
| ![C#](https://img.shields.io/badge/C%23-239120?logo=csharp&logoColor=white) | Game logic, input handling, scoring |
| `ShaderLab / HLSL` | Visual shaders for 2D rendering |
| `Unity AudioSource` | Sound effects and background music |
| `Unity Sprite Renderer` | 2D asset display and animation |
| `Unity Rigidbody2D` | Physics-based bird movement |

---

## 🚀 Getting Started

### Prerequisites

- [Unity Hub](https://unity.com/download)
- Unity **2019.4.20f1** or later
- Android Build Support *(optional — only needed for mobile builds)*

### Installation

```bash
# 1. Clone the repository
git clone https://github.com/TheODDYSEY/Flappy-Bird-Unity.git
```

1. Open **Unity Hub** and click **Add project from disk**
2. Select the cloned `Flappy-Bird-Unity` folder
3. Open the project in Unity
4. Navigate to `Assets/Scenes/` and open the **Game** scene
5. Press ▶ **Play** in the Unity Editor to run

---

## 📁 Project Structure

```
Flappy-Bird-Unity/
├── Assets/
│   ├── Scenes/         # Game scene
│   ├── Scripts/        # C# game logic (Bird, PipeSpawner, GameManager...)
│   ├── Sprites/        # 2D art assets
│   ├── Audio/          # Sound effects and music
│   └── Prefabs/        # Pipe and bird prefabs
├── Packages/           # Unity package manifest
├── ProjectSettings/    # Unity project configuration
├── gameplay.gif        # Demo recording
└── README.md
```

---

## 📚 What I Learned

This project was a first dive into Unity and game development. Key concepts covered:

- Unity Editor interface, scenes, and project setup
- GameObjects, Components, and the scene hierarchy
- Physics-based movement with `Rigidbody2D` and `AddForce`
- 2D asset creation and display with `Sprite Renderer`
- Input handling (`Input.GetMouseButtonDown`, `Input.GetKeyDown`)
- Collision detection with `OnCollisionEnter2D` / `OnTriggerEnter2D`
- Procedural content generation (random pipe gap spawning)
- Audio integration with `AudioSource.PlayOneShot`
- Multi-platform builds (PC and Android)

---

## 🤝 Contributing

Forks are welcome — use this as a base for your own Unity experiments. If you make something cool with it, consider opening a PR or dropping a star ⭐

---

## 📄 License

Licensed under the [MIT License](LICENSE). Free for personal and educational use. Commercial use requires permission.

---

## 🙏 Acknowledgments

- Original **Flappy Bird** by Dong Nguyen for the concept and inspiration
- The **Unity community**, docs, and tutorials that made this learning journey possible


---

<div align="center">

Made with ❤️ and Unity &nbsp;·&nbsp; Happy flapping! 🐤

</div>
