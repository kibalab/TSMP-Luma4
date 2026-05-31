[한국어](README.md) | **English** | [日本語](README.ja.md)

# TSMP Codec Luma4

Default Luma4 codec package for TSMP.

This package is used with TSMP Core and provides the Luma4 codec handler, decode shader, material, prefab, and codec catalog asset discovered by the Codec tab in `TSMPSetup`.

## Installation

Add the VPM repository in VRChat Creator Companion.

```
https://vpm.kiba.red/
```

Then install `TSMP Codec Luma4`.

## Requirements

- `com.kibalab.tsmp.core` 0.0.1 or newer
- VRChat Worlds SDK 3.9.0 or newer

## Usage

1. Add the TSMP Core `TSMPController.prefab` or an equivalent TSMP setup to the scene.
2. Open the Codec tab on `TSMPSetup`.
3. Press `Refresh Codecs`.
4. Confirm that `Luma4` appears and select it.
5. Run `Apply Setup`.

Luma4 is the default TSMP codec and should be the first transport path used when setting up or debugging a scene.

## Release

This repository is configured so pushing a version tag creates release artifacts and registers the package with the VPM backend.

The tag must match the `version` in `package.json`.

Example:

```bash
git tag v0.0.1
git push origin v0.0.1
```
