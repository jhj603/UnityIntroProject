using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class IntroMovement : MonoBehaviour
{
    // 실제로 이동이 일어날 컴포넌트
    private IntroController controller;
    private Rigidbody2D movementRigidbody;

    private Vector2 movementDirection = Vector2.zero;

    // 주로 내 컴포넌트 안에서 끝나는 작업을 처리하는 메서드
    private void Awake()
    {
        // controller와 IntroController가 같은 게임 오브젝트 안에 위치한다는 가정
        controller = GetComponent<IntroController>();
        movementRigidbody = GetComponent<Rigidbody2D>();
    }

    // Awake가 끝나면서 controller에 접근해서 함수 등록하는 등의 작업을 처리하는 메서드
    private void Start()
    {
        controller.OnMoveEvent += Move;
    }

    private void Move(Vector2 direction)
    {
        movementDirection = direction;
    }

    // 물리 업데이트와 관련있는 메서드
    // Rigidbody의 값을 바꾸니까 물리 업데이트에 속함
    private void FixedUpdate()
    {
        ApplyMovement(movementDirection);
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * 5;

        movementRigidbody.velocity = direction;
    }
}