[한국어](README.ko.md) | **English** | [日本語](README.md)

# TSMP Codec Luma4

Luma4 is the default TSMP codec. It writes TSMP data through luminance-oriented symbols instead of relying on rich color information, making it the baseline codec for simple setup and stable decoding.

Use Luma4 first when installing TSMP or diagnosing a stream path.

## Characteristics

- Default TSMP codec
- Low color dependency and simple decode path
- Practical baseline pattern for VRChat camera capture, OBS, Spout, and similar video routes
- Automatically discovered in the `TSMPSetup` Codec tab

## Requirements

- TSMP Core: https://github.com/kibalab/TSMP-Core
- `com.kibalab.tsmp.core` 0.0.1 or newer
- VRChat Worlds SDK 3.9.0 or newer

## Installation

Add the VPM repository in VRChat Creator Companion.

```text
https://vpm.kiba.red/
```

Then install `TSMP Core` and `TSMP Codec Luma4`.

## Usage

1. Add `Packages/com.kibalab.tsmp.core/Samples/TSMPController.prefab` from the Core package to your scene.
2. Open the Codec tab in `TSMPSetup` and click `Refresh Codecs`.
3. Select `Luma4`.
4. Click `Apply Setup`.

## Release Status

This package is currently beta and uses `v0.0.x-beta.x` tags.

## License

MIT License. Copyright (c) 2026 KIBA_Labs.
