using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KingDelete : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnDestroy()
    {
        GameObject[] GameController = GameObject.FindGameObjectsWithTag("Player");
        if (GameController[0].GetComponent<GameManager>().currentPlayer == 0)
        {
        Debug.Log("meがまけた");
        }
        Debug.Log("meがmovve");
    }

}
