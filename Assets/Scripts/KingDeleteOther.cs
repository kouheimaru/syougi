using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KingDeleteOther : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnDestroy()
    {
        GameObject[] GameController = GameObject.FindGameObjectsWithTag("Player");
        if (GameController[0].GetComponent<GameManager>().currentPlayer == 1)
        {
            Debug.Log("otherがまけた");
        }
        Debug.Log("otherがmovve");
    }
}
