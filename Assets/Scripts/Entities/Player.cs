using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private TMP_Text text;

    private CharacterStatHandler characterStatHandler;

    private void Awake()
    {
        characterStatHandler = GetComponent<CharacterStatHandler>();
    }

    // Start is called before the first frame update
    void Start()
    {
        text.text = characterStatHandler.CurrentStat.name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
