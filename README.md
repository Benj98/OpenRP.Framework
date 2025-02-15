# OpenRP.Framework  

**Open Roleplay** is an ambitious gamemode developed for [open.mp](https://github.com/openmultiplayer) (Open Multiplayer, a multiplayer mod for GTA San Andreas) using the [SampSharp](https://github.com/ikkentim/SampSharp) framework.  

## Index
- [General Information](#general-information)
  - [What is OpenRP.Framework?](#-what-is-openrpframework)
  - [What is Roleplay?](#-what-is-roleplay)
  - [The Vision](#-the-vision)
  - [The Open Philosophy](#-the-open-philosophy)
  - [Open Source, Not Copy-Paste](#-open-source-not-copy-paste)
  - [Get Involved](#-get-involved)
- [Video Highlights](#video-highlights)
  - [Procedural Biome Generator](#-procedural-biome-generator)
  - [AI Actors](#-ai-actors)
  - [AI Actors 2.0 (WIP)](#-ai-actors-20-wip)
- [Technical Documentation](#technical-documentation)
  - [File Structure](#-file-structure)

## General Information
### 🔹 What is OpenRP.Framework?  
OpenRP.Framework is the **open-source backbone** of Open Roleplay, containing most of the gameplay functionalities that make the server tick. While some unique features - such as the **biome generator** - remain closed-source, this library is designed to be a **powerful, community-driven** foundation for our roleplay server on Open Multiplayer.  

Open Roleplay itself is split into two projects:  
- **OpenRP.Core** - The closed-source part of the gamemode, containing server-specific logic and proprietary features.  
- **OpenRP.Framework** - The open-source library that powers most of the game mechanics, designed to be modular.  

### 🎭 What is Roleplay?  
Roleplay is about **stepping into a character and shaping stories through player-driven interactions**. Open Roleplay takes this concept further with **immersive mechanics, unique player-led factions, and dynamic world systems**, cutting out unnecessary bureaucracy while keeping realism and structure in place.  

### 🚀 The Vision  
The goal of Open Roleplay is to **break away from outdated roleplay formulas** and introduce **fresh, ambitious features** that feel like they could’ve been made by Rockstar, if they cared about their community rather than just selling Shark Cards.  

Russian roleplay servers have been pushing the boundaries of what’s possible for years. Open Roleplay takes inspiration from that approach, aiming to bring **highly detailed, feature-rich** roleplay to the English-speaking community while ensuring everything remains **polished, immersive, and grounded in realism**.  

The philosophy is simple:  
- No **excessive bureaucracy:** If you have a roleplay idea that makes sense, you can make it happen if you are willing to put in effort and dedication. Our admin team will advise you on how to make it happen if you ask for help.
- No **stagnation:** This isn't just another copy-paste server. Every system is designed to **innovate** and **break the game, only to make the impossible, possible**!
- **Nothing is impossible:** If an idea is **realistic, fits the time period, and aligns with the lore of our world**, then it’s possible. It just takes some work to make it happen!
- **A world shaped by its players:** Open Roleplay isn’t just a server. It’s a living world shaped by you, both IC and OOC. The direction of the server isn’t dictated from the top down but the community helps to decide the direction we go in.

### 🌍 The Open Philosophy  
The **"Open"** in Open Roleplay isn’t just a name but it reflects the way the project is run:  
- **Transparent Development:** A large portion of the framework is open-source and open for contributions.  
- **Freedom to Build:** No red tape stopping you from making things happen. If an idea is **realistic, fits the time period, and aligns with the lore of our world**, then you can make it happen if you are willing to put in effort and dedication.
- **Community-Driven:** OpenRP.Framework is built to evolve with its contributors, shaping the ultimate roleplay experience. The community helps to decide the direction we go in, both IC and OOC.

### 🛠 Open Source, Not Copy-Paste

This framework isn’t a plug-and-play gamemode for copycats. It’s a foundation for the community to help build the ultimate roleplaying server together.  

**OpenRP.Framework is distributed under the [LGPL-3.0 license](https://www.gnu.org/licenses/lgpl-3.0.html).**

What does that mean for you if you use it in your project? Simply put:

- **Include the License:**  
  Any project that uses OpenRP.Framework must include a copy of the LGPL-3.0 license. This informs your users of their rights and the conditions under which the library is provided.

- **Keep the Credits Intact:**  
  The original credits and acknowledgments must remain. It’s about honoring the work that built this foundation and keeping our community’s heritage visible.

- **Share Your Library Modifications:**  
  If you tweak or improve the framework itself, those modifications must be released under the LGPL-3.0. This ensures that improvements benefit the entire community.

- **Freedom for Your Own Code:**  
  You’re free to use and even integrate OpenRP.Framework into proprietary projects, provided that you link to it dynamically. That means your own code can remain closed, as long as the library’s part stays compliant and replaceable.

- **Distribution Must Respect User Freedom:**  
  Whether you distribute a compiled binary or source code, you must provide a means (or instructions) that allows re-link or update the LGPL-covered portions. This prevents “lock-in” and keeps the spirit of open collaboration alive.

- **Beware of Copy-Pasting Code:**  
  Simply copying the library’s code directly into your project (instead of linking to it) converts your project into a derivative work. In that case, any modifications to that copied code must also be released under the LGPL-3.0. Failure to do so breaches the license.

By using OpenRP.Framework, you’re not only benefiting from a solid roleplay server foundation, you’re also agreeing to uphold these principles. They protect both your freedom as a developer and the collective progress of our community.

### 🚀 Get Involved  
OpenRP.Framework is a **community-driven project**, and contributions are encouraged. Whether you're a **developer, designer, or just passionate about roleplay**, you can help shape the future of the framework. Fork the project, submit pull requests, or join discussions to be part of something bigger.  

## Video Highlights
Click on any thumbnail to watch the video, or [click here](https://www.youtube.com/@openrp-server) to visit our YouTube channel.

### 🌳 Procedural Biome Generator
[![Open Roleplay | Procedural Biome Generator | Red County v2.2](https://img.youtube.com/vi/6HkTJOOMALA/0.jpg)](https://www.youtube.com/watch?v=6HkTJOOMALA)

### 👨🏻‍🌾 AI Actors
[![Open Roleplay | AI Actors | Meeting Finn O'Hare at Palomino Creek Fishing Bay](https://img.youtube.com/vi/ZoWpUR5I7V8/0.jpg)](https://www.youtube.com/watch?v=ZoWpUR5I7V8)

### 👨‍👩‍👧 AI Actors 2.0 (WIP)
[![Open Roleplay | AI Actors 2.0 | Ability to roleplay with /me and /do](https://img.youtube.com/vi/RMHRkCpbA9A/0.jpg)](https://www.youtube.com/watch?v=RMHRkCpbA9A)

## Technical Documentation

### 📁 File Structure

| Path                                              | Description                                                                                                                         |
| ------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------- |
| `Database/Models`                                 | Contains all database models.                                                                                                       |
| `Database/BaseDataContext.cs`                     | Defines the BaseDataContext and DbSets against which queries are executed.                                                          |
| `Extensions/ServiceCollectionExtensions.cs`       | Registers all combined service extensions of all features.                                                                             |
| `Features/**/Commands`                            | Contains all command classes for a given feature.                                                                                   |
| `Features/**/Components`                          | Houses all component implementations for a given feature.                                                                           |
| `Features/**/Enums`                               | Defines all enums used within a feature.                                                                                            |
| `Features/**/Extensions`                          | Contains extension methods for a feature.                                                                                           |
| `Features/**/Extensions/ServiceCollectionExtensions.cs` | Registers service extensions belonging to a feature.                                                                             |
| `Features/**/Services`                            | Contains all service classes and interfaces for a feature.                                                                             |
| `Features/**/Systems`                             | Contains system implementations for a feature (including both `ISystem` and `IServerSystem` types).                                   |
| `Features/**/Entities`                            | Holds all entity classes associated with a feature.                                                                                 |
| `Features/**/Helpers`                             | Contains miscellaneous helper classes for a feature.                                                                                |
| `Shared/Chat/`                                    | Contains shared logic related to chat functionality.                                                                                |
| `Shared/Dialogs/`                                 | Contains shared dialog logic used across the project.                                                                               |
| `Shared/ServerEvents/`                            | Houses logic for handling server events that is used project-wide.                                                                    |
| `Shared/ChatColor.cs`                             | Defines constants for shared chat color settings.                                                                                   |
| `Shared/ServerCOLOR.cs`                           | Defines constants for shared server color settings.                                                                                 |
| `Systems`                                         | Contains all project-related systems.                                                                                               |
