using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour
{
    public void OnClicktile()
    {
        GameObject[] GameController = GameObject.FindGameObjectsWithTag("Player");

        //自分の座標を取得する
        Transform myTransform = this.transform;
        Vector2 pos = myTransform.position;
        //親のオブジェクトを取得
        GameObject parentGameObject = transform.parent.gameObject;
        //駒を動かす
        Instantiate(parentGameObject, new Vector2(pos.x, pos.y), Quaternion.identity);
        //生成したgridの情報を変更する1
        GameController[0].GetComponent<GameManager>().grid[2 - Mathf.FloorToInt(pos.y), Mathf.FloorToInt(pos.x) + 2] = 1;
        //もとの駒の座標を取得する
        Vector2 pos_p = parentGameObject.transform.position;
        //もとの駒のgridの情報を変更する0
        GameController[0].GetComponent<GameManager>().grid[2 - Mathf.FloorToInt(pos_p.y), Mathf.FloorToInt(pos_p.x) + 2] = 0;
        //もとの駒を削除
        Destroy(transform.parent.gameObject);
        //画面のタイルを削除する
        GameObject[] objects = GameObject.FindGameObjectsWithTag("tilepre");
        foreach (GameObject tile in objects)
        {
            Destroy(tile);
        }
        //プレイヤーを変更する
        if (GameController[0].GetComponent<GameManager>().currentPlayer == 1)
        {
            Debug.Log("プレイヤー切り替え");
            GameController[0].GetComponent<GameManager>().currentPlayer = 0;

        }
        else
        {
            Debug.Log("プレイヤー切り替え");
            GameController[0].GetComponent<GameManager>().currentPlayer = 1;
 
        }

    }
}
