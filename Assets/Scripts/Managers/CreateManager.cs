using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.XR;

public class CreateManager : MonoBehaviour
{
    [SerializeField] private InputField inputField;
    [SerializeField] private Button startBtn;

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

        SceneManager.LoadScene("MainScene");
    }
}
