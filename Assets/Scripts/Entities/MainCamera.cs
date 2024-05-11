using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    [SerializeField]
    private GameObject Player;
    private void LateUpdate()
    {
        transform.position = Player.transform.position + new Vector3(0, 0, -10);
    }
}
