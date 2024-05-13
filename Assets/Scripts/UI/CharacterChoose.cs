using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

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
            RectTransform[] ImgCharacterBtn = goCharacterBtn.GetComponentsInChildren<RectTransform>();

            cbCharacterBtn.CharacterType = (CharacterType)i;

            switch (cbCharacterBtn.CharacterType)
            {
                case CharacterType.Main:
                    ImgCharacterBtn[1].sizeDelta = new Vector2(500f, 500f);
                    ImgCharacterBtn[1].localPosition = new Vector3(0, 85f, 0);
                    break;
                case CharacterType.Knight:
                    ImgCharacterBtn[1].sizeDelta = new Vector2(150f, 300f);
                    ImgCharacterBtn[1].localPosition = new Vector3(0, 45f, 0);
                    break;
            }
        }
    }
}
