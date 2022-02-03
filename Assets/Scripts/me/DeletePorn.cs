using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeletePorn : MonoBehaviour
{
    public GameObject upPorn;
    private bool canJudge = true;
    //変数を用意する
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
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
