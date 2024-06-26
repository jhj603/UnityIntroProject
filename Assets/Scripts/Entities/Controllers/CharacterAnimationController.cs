﻿using Unity.VisualScripting;
using UnityEngine;

public class CharacterAnimationController : AnimationController
{
    private static readonly int isWalking = Animator.StringToHash("isWalking");
    private static readonly int characterType = Animator.StringToHash("characterType");

    private readonly float magnitudeThreshold = 0.5f;

    [SerializeField] private CharacterStatHandler characterStatHandler;

    [SerializeField] private RuntimeAnimatorController mainController;
    [SerializeField] private RuntimeAnimatorController knightController;

    protected override void Awake()
    {
        base.Awake();
    }

    private void Start()
    {
        controller.OnMoveEvent += Move;

        animator.SetInteger(characterType, (int)characterStatHandler.CurrentStat.characterType);
    }

    private void Move(Vector2 direction)
    {
        animator.SetBool(isWalking, direction.magnitude > magnitudeThreshold);
    }

    public void ChangeCharacter()
    {
        if (CharacterType.Main == characterStatHandler.CurrentStat.characterType)
            animator.runtimeAnimatorController = mainController;
        else
            animator.runtimeAnimatorController = knightController;
    }
}