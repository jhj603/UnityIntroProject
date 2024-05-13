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
    [SerializeField] private GameObject attendants;

    private GameObject player;
    private GameObject npc;
    private Player scPlayer;
    private CharacterStatHandler npcStatHandler;

    public List<GameObject> CharacterList { get; private set; } = new List<GameObject>();

    private void Awake()
    {
        if (null == Instance)
            Instance = this;
    }

    private void Start()
    {
        player = Instantiate(Player);
        npc = Instantiate(NPC);

        CharacterList.Add(player);
        CharacterList.Add(npc);

        scPlayer = player.GetComponent<Player>();
        scPlayer.Initialize();

        npcStatHandler = npc.GetComponent<CharacterStatHandler>();
        npcStatHandler.CurrentStat.name = "Angel";

        npc.transform.position = new Vector2(0f, 28f);
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

    public void OnClickShowAttendants()
    {
        attendants.SetActive(true);
    }

    public void CloseShowAttendants()
    {
        attendants.SetActive(false);
    }
}
