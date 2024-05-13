using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField] private CharacterStatHandler characterStatHandler;

    private void Awake()
    {
        if (null == Instance)
            Instance = this;

        if (PlayerPrefs.HasKey("playerName"))
        {
            characterStatHandler.CurrentStat.name = PlayerPrefs.GetString("playerName");
            characterStatHandler.CurrentStat.characterType = (CharacterType)PlayerPrefs.GetInt("playerType");
        }
    }
}
