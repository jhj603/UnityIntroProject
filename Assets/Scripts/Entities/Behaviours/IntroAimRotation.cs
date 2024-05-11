using UnityEngine;

public class IntroAimRotation : MonoBehaviour
{
    [SerializeField] private SpriteRenderer characterRenderer;

    private IntroController controller;

    private void Awake()
    {
        controller = GetComponent<IntroController>();
    }

    private void Start()
    {
        controller.OnLookEvent += OnAim;
    }

    private void OnAim(Vector2 direction)
    {
        RotateCharacter(direction);
    }

    private void RotateCharacter(Vector2 direction)
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        characterRenderer.flipX = Mathf.Abs(rotZ) > 90f;
    }
}