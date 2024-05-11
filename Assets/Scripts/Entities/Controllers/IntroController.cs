using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent;   // Action은 무조건 void만 반환해야 함. 아니면 Func를 써야 함.
    public event Action<Vector2> OnLookEvent;   

    // Move 이벤트 발생 시 Invoke하는 역할
    public void CallMoveEvent(Vector2 direction)
    {
        OnMoveEvent?.Invoke(direction);     // ?. : 객체가 없으면 실행하지 않고 있으면 실행
    }

    public void CallLookEvent(Vector2 direction)
    {
        OnLookEvent?.Invoke(direction);
    }
}
