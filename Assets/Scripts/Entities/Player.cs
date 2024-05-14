using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private TMP_Text text;
    [SerializeField] private List<Sprite> sprites = new List<Sprite>((int)CharacterType.Knight);
    [SerializeField] private Vector3 camOffset;
    [SerializeField] private LayerMask levelCollisionLayer;

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

        Canvas canvas = GetComponentInChildren<Canvas>();
        canvas.worldCamera = camera;
    }

    private void LateUpdate()
    {
        camera.transform.position = transform.position + camOffset;
    }

    public void Initialize()
    {
        if (PlayerPrefs.HasKey("playerName"))
        {
            characterStatHandler.CurrentStat.name = PlayerPrefs.GetString("playerName");
            characterStatHandler.CurrentStat.characterType = (CharacterType)PlayerPrefs.GetInt("playerType");

            CharacterAnimationController controller = gameObject.GetComponent<CharacterAnimationController>();
            controller.ChangeCharacter();
        }
    }

    public void ChangePlayerName(string name)
    {
        characterStatHandler.CurrentStat.name = name;

        text.text = characterStatHandler.CurrentStat.name;
    }

    public void ChangePlayerType(CharacterType type)
    {
        characterStatHandler.CurrentStat.characterType = type;
        spriteRenderer.sprite = sprites[(int)characterStatHandler.CurrentStat.characterType];

        CharacterAnimationController controller = gameObject.GetComponent<CharacterAnimationController>();
        controller.ChangeCharacter();

        switch (characterStatHandler.CurrentStat.characterType)
        {
            case CharacterType.Main:
                break;
            case CharacterType.Knight:
                break;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (IsLayerMatched(levelCollisionLayer.value, collision.gameObject.layer))
        {
            CharacterStatHandler collisionInfo = collision.gameObject.GetComponent<CharacterStatHandler>();
            GameManager.Instance.ShowTalkBackGround(collisionInfo.CurrentStat.name);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (IsLayerMatched(levelCollisionLayer.value, collision.gameObject.layer))
        {
            GameManager.Instance.CloseTalkBackGround();
        }
    }

    private bool IsLayerMatched(int value, int layer)
    {
        return value == (value | 1 << layer);
    }
}
