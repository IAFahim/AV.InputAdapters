# AV.InputAdapters

![Header](documentation_header.svg)

[![Unity](https://img.shields.io/badge/Unity-2022.3%2B-000000.svg?style=flat-square&logo=unity)](https://unity.com)
[![License](https://img.shields.io/badge/License-MIT-blue.svg?style=flat-square)](LICENSE.md)

Foundation interface definitions for input abstraction.

## ✨ Features

- **Decoupled Input**: Defines interfaces for common input patterns.
- **IHitProvider**: Interface for getting RaycastHit results.
- **IRayProvider**: Interface for getting Ray data (e.g., from camera).
- **IPositionReceiver**: Interface for receiving screen/world positions.

## 📦 Installation

Install via Unity Package Manager (git URL).

## 🚀 Usage

Implement these interfaces in your input handlers to allow systems (like Navigation) to be input-agnostic.

```csharp
public class MouseInput : MonoBehaviour, IPositionReceiver
{
    public Vector2 Position => Input.mousePosition;
}
```

## ⚠️ Status

- 🧪 **Tests**: Missing.
- 📘 **Samples**: None.
