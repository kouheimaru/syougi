using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckKing : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("調べる");
        GameObject[] GameController = GameObject.FindGameObjectsWithTag("Player");

            Debug.Log(other.tag);
        if (other.CompareTag("king"))
        {
            Debug.Log("王の駒に触れた");
            Destroy(this.gameObject);

        }

    }
}
