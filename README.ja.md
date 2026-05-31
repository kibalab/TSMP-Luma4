[한국어](README.md) | [English](README.en.md) | **日本語**

# TSMP Codec Luma4

Luma4 は TSMP の標準 codec です。豊富な色情報に依存せず、輝度ベースのシンボルで TSMP データを記録するため、セットアップが簡単で安定したデコード経路の基準 codec として使えます。

TSMP を初めて導入する場合やストリーム経路を確認する場合は、まず Luma4 を使用してください。

## 特徴

- TSMP 標準 codec
- 色への依存が少なく、デコード経路が単純
- VRChat カメラ キャプチャ、OBS、Spout などの映像経路で確認しやすい基準パターン
- `TSMPSetup` の Codec タブで自動検出

## 要件

- TSMP Core: https://github.com/kibalab/TSMP-Core
- `com.kibalab.tsmp.core` 0.0.1 以降
- VRChat Worlds SDK 3.9.0 以降

## インストール

VRChat Creator Companion で VPM リポジトリを追加します。

```text
https://vpm.kiba.red/
```

その後、`TSMP Core` と `TSMP Codec Luma4` をインストールします。

## 使い方

1. Core パッケージの `Packages/com.kibalab.tsmp.core/Samples/TSMPController.prefab` をシーンに配置します。
2. `TSMPSetup` の Codec タブで `Refresh Codecs` を押します。
3. `Luma4` を選択します。
4. `Apply Setup` を実行します。

## リリース状態

このパッケージは beta 段階で、`v0.0.x-beta.x` 形式のタグを使用します。

## ライセンス

MIT License. Copyright (c) 2026 KIBA_Labs.
