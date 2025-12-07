# Rotatine Wheel 게임
이 프로젝트는 Unity로 제작된 캐주얼 게임으로 플레이방식은 간단합니다.
<br>

#### 플레이방식
- 휠의 구멍을 피해 왼쪽 또는 오른쪽으로 이동한다.
- 시간이 지날수록 휠 회전 속도는 점점 빨라진다.
- 1초에 1점씩 점수가 쌓이면 300초를 버티면 게임에서 이기게 된다.

#### 스크린샷
<div>
  <img src="https://user-images.githubusercontent.com/56622731/213666855-46284811-6672-41b0-8b7d-60dc8a62ae79.png" width="200"/>
  <img src="https://user-images.githubusercontent.com/56622731/213666994-123f190b-a292-4a16-a362-6020ff8f77b3.png" width="200"/>
  <img src="https://user-images.githubusercontent.com/56622731/213667016-ed3e4023-5b93-41a4-bb34-a9aa8cf7ce18.png" width="200"/>
  <img src="https://user-images.githubusercontent.com/56622731/213667027-e81977e0-ecfc-4218-a016-00a8fac0c339.png" width="200"/>
</div>
<br><br>

## 게임 실행 가이드
게임을 실행하기 위한 단계는 다음과 같습니다.

#### 1. Unity Hub 및 Editor 설치
* 이 프로젝트를 열기 위해서는 **Unity Hub**와 적절한 버전의 **Unity Editor**가 필요합니다.
* ProjectSettings/ProjectVersion.txt 파일을 확인하여 정확한 Unity 버전을 알 수 있습니다. (일반적으로 Unity Hub에서 프로젝트를 추가하면 자동으로 버전을 감지하고 설치를 유도합니다.)

#### 2. 프로젝트 열기
1. **Unity Hub**를 실행합니다.
2. **Projects** 탭에서 **Add** 버튼을 클릭합니다.
3. `Rotating Wheel` 프로젝트가 위치한 폴더를 선택하여 추가합니다.
4. 목록에 추가된 프로젝트를 클릭하여 엽니다.

#### 3. 게임 실행 (에디터 내)
1. Unity 에디터가 열리면, **Project** 창에서 `Assets/Scenes` 폴더로 이동합니다.
2. **`HomeScene.unity`** 파일을 더블 클릭하여 엽니다. (이 씬이 게임의 시작 화면입니다.)
3. 에디터 상단의 **Play (▶)** 버튼을 클릭합니다.
4. **Game** 탭에서 게임을 플레이할 수 있습니다.

#### 4. 빌드 및 실행 (Android)
프로젝트 루트에 `Rotating Wheel.aab` 파일을 통해 알 수 있듯 Android 빌드가 포함되어 있습니다.
1. **File > Build Settings**로 이동합니다.
2. Platform이 **Android로** 설정되어 있는지 확인합니다. (아니라면 Android를 선택하고 **Switch Platform** 클릭)
3. **Scenes In Build** 목록에 `HomeScene`, `PlayScene`, `CreditScene`, `GameOverScene`, `WinScene` 등이 포함되어 있는지 확인합니다.
4. **Build And Run**을 클릭하여 연결된 Android 기기에서 실행하거나, **Build**를 클릭하여 APK/AAB 파일을 생성합니다.

#### 주요 씬 설명
* **HomeScene**: 게임의 메인 메뉴 및 시작 지점
* **PlayScene**: 실제 게임 플레이가 이루어지는 곳
* **CreditScene**: 제작진 정보
* **GameOverScene**: 게임 오버 화면
* **WinScene**: 승리 화면
<br>

## 다운로드 링크
#### 구글플레이 (Android)
https://play.google.com/store/apps/details?id=com.TAURUSX.RotatingWheel
<br>

#### 앱스토어 (iOS)
https://apps.apple.com/app/id1606578955
<br>
