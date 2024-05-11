﻿using Unity.VisualScripting;
using UnityEngine;

public class CharacterAnimationController : AnimationController
{
    private static readonly int isWalking = Animator.StringToHash("isWalking");
    private static readonly int characterType = Animator.StringToHash("characterType");

    private readonly float magnitudeThreshold = 0.5f;

    protected override void Awake()
    {
        base.Awake();
    }

    private void Start()
    {
        controller.OnMoveEvent += Move;

        animator.SetInteger(characterType, 1);
    }

    private void Move(Vector2 direction)
    {
        animator.SetBool(isWalking, direction.magnitude > magnitudeThreshold);
    }
}