using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterBtn : MonoBehaviour
{
    public CharacterType CharacterType { get; set; }
    
    private Image[] characterImg;

    private void Awake()
    {
        characterImg = GetComponentsInChildren<Image>();
    }

    public void OnClick()
    {
        CreateManager.Instance.SelectCharacter(CharacterType);
    }

    public void OnClickInGame()
    {
        GameManager.Instance.CloseShowSelectCharacterBtn(CharacterType);
    }

    public void SettingImg(Sprite sprite)
    {
        characterImg[1].sprite = sprite;
    }
}
