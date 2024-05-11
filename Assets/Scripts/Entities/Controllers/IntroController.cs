using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent;   // Action�� ������ void�� ��ȯ�ؾ� ��. �ƴϸ� Func�� ��� ��.
    public event Action<Vector2> OnLookEvent;   

    // Move �̺�Ʈ �߻� �� Invoke�ϴ� ����
    public void CallMoveEvent(Vector2 direction)
    {
        OnMoveEvent?.Invoke(direction);     // ?. : ��ü�� ������ �������� �ʰ� ������ ����
    }

    public void CallLookEvent(Vector2 direction)
    {
        OnLookEvent?.Invoke(direction);
    }
}
