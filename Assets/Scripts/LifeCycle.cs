using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    private void Awake() // 객체가 장면안에 생성될 때 최초로 실행되는 함수 딱 한번만 실행
    {
        Debug.Log("플레이어 데이터가 준비되었습니다.");
    }

    private void OnEnable() // 오브젝트가 활성화될 때 실행되는 함수, 스크립트가 활성화될 때
    {
        // 한번만 실행되는 것이 아닌 오브젝트를 켜고 끌때마다 실행된다.
        Debug.Log("플레이어가 로그인했습니다.");
    }

    void Start() // Update로 들어가기 전에 Awake함수 다음으로 실행되는 함수. 한번만 실행된다.
    {
        Debug.Log("플레이어가 사냥 장비를 챙겼습니다.");
    }

    // -------------------------- 여기까지 초기화 영역. 여기 다음부터는 물리연산 영역 

    void FixedUpdate() // 유니티 엔진이 물리 연산을 하기 전에 실행되는 함수
    {
        // 컴퓨터 사양에 따라 다른 수의 계산을 하는 것이 아닌, 고정된 실행 주기 (1초에 약 50회)를 가짐 (CPU를 많이 사용)
        // 그래서 보통 물리 연산에 관한 로직만 넣는다.
        Debug.Log("이동");
    }

    // ------------------------ 게임 로직 영역

    void Update() // 물리 연산을 제외한 나머지 주기적으로 변하는 로직을 넣을때 사용하는 영역.
    {
        // 컴퓨터 환경에 따라 실행 주기가 달라질 수 있다.
        Debug.Log("몬스터 사냥");
    }

    private void LateUpdate() // 모든 업데이트가 끝난 뒤에 마지막으로 실행되는 함수
    {
        // 캐릭터를 따라가는 카메라나 로직의 후처리를 담는 함수
        Debug.Log("경험지 획득");
    }

    private void OnDisable() // 오브젝트가 비활성화될 때 실행되는 함수 , 스크립트가 꺼질때
    {
        Debug.Log("플레이어가 로그아웃을 했습니다.");
    }

    // ----------------------- 해체 영역

    private void OnDestroy() // 오브젝트가 삭제되기 직전에 무언가를 남기고 삭제되는 함수 Awake와 반대
    {
        Debug.Log("플레이어 데이터가 해체되었습니다.");
    }

}
