using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private TMP_Text text;
    [SerializeField] private List<Sprite> sprites = new List<Sprite>((int)CharacterType.Knight);
    [SerializeField] private Vector3 camOffset;

    private CharacterStatHandler characterStatHandler;
    private SpriteRenderer spriteRenderer;

    private Camera camera;

    private void Awake()
    {
        characterStatHandler = GetComponent<CharacterStatHandler>();
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();

        camera = Camera.main;
    }

    // Start is called before the first frame update
    void Start()
    {
        text.text = characterStatHandler.CurrentStat.name;
        spriteRenderer.sprite = sprites[(int)characterStatHandler.CurrentStat.characterType];

        switch (characterStatHandler.CurrentStat.characterType)
        {
            case CharacterType.Main:
                break;
            case CharacterType.Knight:
                break;
        }
    }

    private void LateUpdate()
    {
        camera.transform.position = transform.position + camOffset;
    }
}
