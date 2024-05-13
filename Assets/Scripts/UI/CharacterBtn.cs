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

    private void Start()
    {
        characterImg[1].sprite = CreateManager.Instance.sprites[(int)CharacterType];
    }

    public void OnClick()
    {
        CreateManager.Instance.SelectCharacter(CharacterType);
    }
}
