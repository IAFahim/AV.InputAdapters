# AV.InputAdapters

[![Unity Version](https://img.shields.io/badge/Unity-2022.3%2B-blue.svg)](https://unity3d.com/get-unity/download)
[![License](https://img.shields.io/badge/License-MIT-green.svg)](LICENSE.md)
[![Version](https://img.shields.io/badge/Version-1.0.0-orange.svg)](CHANGELOG.md)

Input adapter foundation package for Unity - placeholder for future input system integrations.

## Status

This package is currently a foundation/placeholder package for future input adapter implementations.

## Interfaces

The package provides the following interfaces following strict naming guidelines:

- **`IHitProvider`** - Provides access to a `RaycastHit` result via `Hit` property
- **`IRayProvider`** - Provides access to a `Ray` for raycasting via `Ray` property
- **`IPositionReceiver`** - Receives a `Vector2` position via `Position` property

## Code Quality

This package follows strict naming guidelines from AGENTS.md:
- ✅ **Descriptive interface names**: `IHitProvider` (not `IRaycastHitGet`)
- ✅ **Descriptive properties**: `Hit`, `Ray`, `Position` (not generic `Value`)
- ✅ **Pronounceable**: All names read naturally
- ✅ **Searchable**: No cryptic abbreviations
- ✅ **Clear intent**: Interface names describe their purpose

## Installation

```
Window > Package Manager > + > Add package from git URL
```
```
https://github.com/IAFahim/AV.InputAdapters.git
```

## License

MIT License - see [LICENSE.md](LICENSE.md) for details.

## Author

**IAFahim** - [GitHub](https://github.com/IAFahim)
