using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InGameChangeName : MonoBehaviour
{
    private InputField changeNameInputField;
    private Button changeBtn;

    private void Awake()
    {
        changeNameInputField = GetComponentInChildren<InputField>();
        changeBtn = GetComponentInChildren<Button>();
    }

    private void Update()
    {
        if ((1 < changeNameInputField.text.Length) && (11 > changeNameInputField.text.Length))
            changeBtn.interactable = true;
        else
            changeBtn.interactable = false;
    }

    public void OnClickChangeBtn()
    {
        GameManager.Instance.CloseShowChangeNameBtn(changeNameInputField.text);
    }
}
