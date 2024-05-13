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

    private CharacterStatHandler characterStatHandler;

    private void Awake()
    {
        if (null == Instance)
            Instance = this;
    }

    private void Start()
    {
        Instantiate(Player);

        characterStatHandler = Player.GetComponent<CharacterStatHandler>();

        if (PlayerPrefs.HasKey("playerName"))
        {
            characterStatHandler.CurrentStat.name = PlayerPrefs.GetString("playerName");
            characterStatHandler.CurrentStat.characterType = (CharacterType)PlayerPrefs.GetInt("playerType");
        }
    }

    private void Update()
    {
        timeTxt.text = DateTime.Now.ToString(("HH:mm"));
    }
}
