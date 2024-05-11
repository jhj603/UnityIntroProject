public enum CharacterType
{
    Main,
    Knight
}

[System.Serializable]
public class CharacterStat
{
    public CharacterType characterType;

    public string name;
}