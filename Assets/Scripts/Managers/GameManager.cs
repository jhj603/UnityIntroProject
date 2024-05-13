using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField] private GameObject Player;
    [SerializeField] private GameObject NPC;
    [SerializeField] private TMP_Text timeTxt;
    [SerializeField] private GameObject changeName;
    [SerializeField] private GameObject selectCharacter;

    private GameObject player;
    private Player scPlayer;

    private void Awake()
    {
        if (null == Instance)
            Instance = this;
    }

    private void Start()
    {
        player = Instantiate(Player);

        scPlayer = player.GetComponent<Player>();
        scPlayer.Initialize();
    }

    private void Update()
    {
        timeTxt.text = DateTime.Now.ToString(("HH:mm"));
    }

    public void OnClickShowChangeNameBtn()
    {
        changeName.SetActive(true);
    }

    public void CloseShowChangeNameBtn(string name)
    {
        scPlayer.ChangePlayerName(name);

        changeName.SetActive(false);
    }

    public void OnClickShowSelectCharacterBtn()
    {
        selectCharacter.SetActive(true);
    }

    public void CloseShowSelectCharacterBtn(CharacterType type)
    {
        scPlayer.ChangePlayerType(type);

        selectCharacter.SetActive(false);
    }
}
