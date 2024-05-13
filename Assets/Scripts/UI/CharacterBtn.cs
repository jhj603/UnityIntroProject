using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterBtn : MonoBehaviour
{
    public CharacterType CharacterType { get; set; }
    
    [SerializeField] private Image characterImg;

    private void Start()
    {
        characterImg.sprite = CreateManager.Instance.sprites[(int)CharacterType];
    }

    public void OnClick()
    {
        CreateManager.Instance.SelectCharacter(CharacterType);
    }
}
