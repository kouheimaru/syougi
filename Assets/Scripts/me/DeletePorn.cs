using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeletePorn : MonoBehaviour
{
    private bool canJudge = true;
    //変数を用意する
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
        //敵の駒が来たときに消える
        if (other.CompareTag("enemy"))
        {
            Destroy(other.gameObject);

        }
        //  仲間の駒が来たとき
        if (other.CompareTag("me"))
        {

            Destroy(other.gameObject);
        }

            canJudge = false;
        }

    }
}
