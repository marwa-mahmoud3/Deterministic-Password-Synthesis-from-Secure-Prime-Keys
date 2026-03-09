# 🔐 MathPass: Deterministic Password Desktop Engine (2023)
### Enterprise-Grade Windows Desktop Solution Powered by DevExpress

---

## 📝 Project Overview
**MathPass** is a professional **Windows Desktop Application** developed and delivered in **2023**. It was designed to provide a stateless security solution for password management. Developed in **C#**, it implements a custom deterministic algorithm to generate unique, secure 18-character passwords without any database dependency or cloud storage.

As a **Desktop Engine**, it ensures maximum privacy by keeping all mathematical computations local. By leveraging **DevExpress** UI components, the application delivers a high-end user experience tailored for security-conscious environments.

---

## ⚙️ The Engineering Logic (2023 Implementation)
The core of **MathPass** is a sophisticated mathematical pipeline that transforms variable user input into a fixed-length secure output:

### 1️⃣ Input Validation & Normalization
* **Constraints**: Minimum 4 characters for the Prime Key and 5 for the Link.
* **Normalization**: Links are automatically converted to Uppercase and validated to ensure they are "www-free" for consistent hashing across platforms.

### 2️⃣ Advanced Folding Algorithm
* **ASCII Transformation**: Maps raw string data into decimal ASCII segments.
* **Key Resizing (6-Segment Folding)**: A custom algorithm that uses cross-multiplication for short keys and a hybrid "Multiplication-Addition" folding technique for long keys (up to 200 characters).
* **Link Resizing (18-Segment Folding)**: Ensures every URL or link is mapped to a unique 18-character array using circular multiplication logic.

### 3️⃣ Checksum & Deterministic Synthesis
* **Integrity Validation**: Calculates checksums for both formatted keys and links to ensure computational reproducibility.
* **ASCII Mapping**: Applies a **Modulo 95 + 32** transformation to map results into the printable ASCII range (32-126), ensuring the password contains valid symbols, numbers, and letters.

---

## 🛠️ Technical Stack
* **Project Date**: Developed & Delivered in 2023.
* **Platform**: Windows Desktop.
* **Language**: C# (.NET).
* **UI Framework**: **DevExpress WinForms** (Advanced Layouts & Premium UI Controls).
* **Core Concepts**: Deterministic Security, ASCII Folding, Checksum Logic, Data Normalization.

---

## 🚀 Key Features
* **Zero-Persistence**: No passwords or keys are ever stored on disk or in the cloud.
* **Deterministic**: The same Key + Link combination always yields the exact same password.
* **Offline Security**: Operates completely offline, protecting against remote data breaches.
* **Professional UX**: Built with industrial-grade **DevExpress** components for a sleek, responsive interface.

---

## 🖼️ Visual Showcase

<p align="center">
  <img src="https://github.com/user-attachments/assets/da162961-79f2-4e45-9515-cdbfb20b83b8" width="85%" alt="MathPass GUI">
</p>

---

## 👤 Developer
**Marwa Mahmoud Mohamed** *Senior Software Engineer* 
**📧 Email**: [marwa.sw.eng@outlook.com](mailto:marwa.sw.eng@outlook.com)  
**🔗 LinkedIn**: [marwa-mahmoud123](https://www.linkedin.com/in/marwa-mahmoud123)  
**💻 Portfolio**: [marwa-mahmoud-sw-eng.vercel.app](https://marwa-mahmoud-sw-eng.vercel
