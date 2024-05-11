using Unity.VisualScripting;
using UnityEngine;

public class CharacterStatHandler : MonoBehaviour
{
    [SerializeField] private CharacterStat baseStat;
    public CharacterStat CurrentStat { get; private set; }

    private void Awake()
    {
        UpdateCharacterStat();
    }

    private void UpdateCharacterStat()
    {
        CurrentStat = new CharacterStat();

        CurrentStat.name = baseStat.name;
        CurrentStat.characterType = baseStat.characterType;
    }
}