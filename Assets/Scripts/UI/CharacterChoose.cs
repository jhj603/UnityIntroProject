using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterChoose : MonoBehaviour
{
    [SerializeField] private CreateManager createManager;
    [SerializeField] private GameObject characterBtn;

    void Start()
    {
        for (int i = 0; i < createManager.sprites.Count; ++i)
        {
            GameObject goCharacterBtn = Instantiate(characterBtn, this.transform);

            CharacterBtn cbCharacterBtn = goCharacterBtn.GetComponent<CharacterBtn>();

            cbCharacterBtn.CharacterType = (CharacterType)i;
        }
    }
}
