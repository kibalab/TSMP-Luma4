**한국어** | [English](README.en.md) | [日本語](README.ja.md)

# TSMP Codec Luma4

Luma4는 TSMP의 기본 코덱입니다. 색상 정보 대신 밝기 단계 중심으로 TSMP 데이터를 기록해, 설정이 단순하고 디코딩 경로가 안정적인 기준 코덱으로 사용됩니다.

처음 TSMP를 설치하거나 문제를 진단할 때는 Luma4를 먼저 사용하는 것을 권장합니다.

## 특징

- TSMP 기본 코덱
- 낮은 색상 의존도와 단순한 디코딩 경로
- VRChat 화면 캡처, OBS/Spout 같은 일반적인 영상 경로에서 테스트하기 쉬운 기준 패턴
- Core 패키지의 `TSMPSetup` Codec 탭에서 자동 검색

## 요구 사항

- TSMP Core: https://github.com/kibalab/TSMP-Core
- `com.kibalab.tsmp.core` 0.0.1 이상
- VRChat Worlds SDK 3.9.0 이상

## 설치

VRChat Creator Companion에서 VPM 저장소를 추가합니다.

```text
https://vpm.kiba.red/
```

그 다음 `TSMP Core`와 `TSMP Codec Luma4`를 설치합니다.

## 사용 방법

1. Core 패키지의 `Packages/com.kibalab.tsmp.core/Samples/TSMPController.prefab`을 씬에 배치합니다.
2. `TSMPSetup`의 Codec 탭에서 `Refresh Codecs`를 누릅니다.
3. `Luma4`를 선택합니다.
4. `Apply Setup`을 실행합니다.

## 배포 상태

현재 beta 단계이며 패키지 버전과 Git 태그는 `v0.0.x-beta.x` 형식을 사용합니다.

## 라이선스

MIT License. Copyright (c) 2026 KIBA_Labs.
