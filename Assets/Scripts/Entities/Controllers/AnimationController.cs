using UnityEngine;

public class AnimationController : MonoBehaviour
{
    protected Animator animator;
    protected IntroController controller;

    protected virtual void Awake()
    {
        animator = GetComponentInChildren<Animator>();
        controller = GetComponent<IntroController>();
    }
}
