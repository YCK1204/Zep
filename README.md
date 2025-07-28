🏗️ 핵심 아키텍처



&nbsp; 싱글톤 매니저 시스템



&nbsp; - Manager: 게임 전반을 관리하는 중앙 허브

&nbsp; - ResourceManager: 프리팹, 이미지 등 리소스 로딩 담당

&nbsp; - SceneManagerEx: 커스텀 씬 전환 로직

&nbsp; - BaseScene: 모든 씬의 공통 베이스 클래스



&nbsp; 모듈화된 구조



&nbsp; 각 미니게임은 독립적인 씬으로 구성되어 있으며, SceneType 열거형으로 관리됩니다.



&nbsp; 🎮 구현된 기능들



&nbsp; 플래피버드 스타일 게임



&nbsp; - Rigidbody2D 기반 물리 시스템

&nbsp; - 실시간 캐릭터 회전과 중력 시뮬레이션

&nbsp; - 2D 충돌 감지를 통한 게임 오버 처리



&nbsp; NPC 대화 시스템



&nbsp; - 월드 공간 말풍선: NPC 위치에 고정되는 3D 텍스트

&nbsp; - 동적 크기 조정: 텍스트 길이에 따른 자동 말풍선 크기 변경

&nbsp; - 큐 기반 대화: 여러 문장을 순차적으로 표시하는 시스템



&nbsp; 🔧 기술적 특징



&nbsp; 크로스 플랫폼 호환성



&nbsp; - Physics2D 대신 Collider Bounds 기반 커스텀 클릭 감지 시스템

&nbsp; - 에디터와 빌드 환경 간 차이점 해결



&nbsp; 렌더링 최적화



&nbsp; - TextMeshPro Overlay Shader로 UI 요소 최상단 표시

&nbsp; - Sorting Layer를 통한 체계적인 렌더링 순서 관리



&nbsp; 안정성



&nbsp; - 다중 백업 시스템 (여러 입력 감지 방식)

&nbsp; - 자동 메모리 관리 (오브젝트 자동 정리)



&nbsp; 🎯 주요 특징



&nbsp; - 확장 가능한 아키텍처: 새로운 미니게임 추가 용이

&nbsp; - 일관된 사용자 경험: 통일된 UI/UX 패턴

&nbsp; - 안정적인 상호작용: 빌드 환경에서도 안정적인 마우스 클릭 감지

