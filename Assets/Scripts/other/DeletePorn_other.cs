using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeletePorn_other : MonoBehaviour
{
    // Start is called before the first frame update
    private bool canJudge = true;
    void Awake()
    {
        //変数を変更する 
        canJudge = true;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (canJudge)
        {
            // 衝突判定時のアクションをここに書く
        GameObject[] GameController = GameObject.FindGameObjectsWithTag("Player");
        Debug.Log("nanika");

        if (other.CompareTag("me"))
        {
                Debug.Log("味方の駒に攻撃ができます");
                Destroy(other.gameObject);

        }
        //  仲間の駒が来たとき
        if (other.CompareTag("enemy"))
        {

            Destroy(other.gameObject);
        }

            canJudge = false;
        }


    }
}
