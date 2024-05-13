using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CreateManager : MonoBehaviour
{
    public static CreateManager Instance;

    [SerializeField] private InputField inputField;
    [SerializeField] private Button startBtn;
    [SerializeField] private Image characterImg;

    [SerializeField] private GameObject selectUI;

    public List<Sprite> sprites = new List<Sprite>((int)CharacterType.Knight);

    RectTransform ImgTransform;

    CharacterType characterType = CharacterType.Main;

    private void Awake()
    {
        if (null == Instance)
            Instance = this;

        ImgTransform = characterImg.GetComponent<RectTransform>();
    }

    private void Start()
    {
        ImgTransform.sizeDelta = new Vector2(500f, 500f);
        ImgTransform.localPosition = new Vector3(0, 85f, 0);

        characterImg.sprite = sprites[(int)characterType];
    }

    // Update is called once per frame
    void Update()
    {
        if ((1 < inputField.text.Length) && (11 > inputField.text.Length))
            startBtn.interactable = true;
        else
            startBtn.interactable = false;
    }

    public void StartGame()
    {
        PlayerPrefs.SetString("playerName", inputField.text);
        PlayerPrefs.SetInt("playerType", (int)characterType);

        SceneManager.LoadScene("MainScene");
    }

    public void ShowSelectCharacter()
    {
        selectUI.SetActive(true);
    }

    public void SelectCharacter(CharacterType type)
    {
        characterType = type;

        switch (characterType)
        {
            case CharacterType.Main:
                ImgTransform.sizeDelta = new Vector2(500f, 500f);
                ImgTransform.localPosition = new Vector3(0, 85f, 0);
                break;
            case CharacterType.Knight:
                ImgTransform.sizeDelta = new Vector2(150f, 300f);
                ImgTransform.localPosition = new Vector3(0, 45f, 0);
                break;
        }

        characterImg.sprite = sprites[(int)characterType];

        selectUI.SetActive(false);
    }
}
