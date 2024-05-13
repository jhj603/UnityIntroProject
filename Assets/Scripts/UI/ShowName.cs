using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShowName : MonoBehaviour
{
    [SerializeField] private GameObject nameObject;

    private GridLayoutGroup gridLayout;

    private void Awake()
    {
        gridLayout = GetComponent<GridLayoutGroup>();
    }

    private void Start()
    {
        List<GameObject> characterList = GameManager.Instance.CharacterList;

        for (int i = 0; i < characterList.Count; ++i)
        {
            GameObject goText = Instantiate(nameObject, this.transform);

            CharacterStatHandler csGameObject = characterList[i].GetComponent<CharacterStatHandler>();

            goText.GetComponent<TMP_Text>().text = csGameObject.CurrentStat.name;
        }
    }

    public void ShowNames()
    {
        List<GameObject> characterList = GameManager.Instance.CharacterList;

        int i = 0;

        foreach (Transform child in this.transform)
        {
            GameObject goText = child.gameObject;

            CharacterStatHandler csGameObject = characterList[i].GetComponent<CharacterStatHandler>();

            goText.GetComponent<TMP_Text>().text = csGameObject.CurrentStat.name;

            ++i;
        }
    }
}
