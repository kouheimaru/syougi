using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour
{
    public GameObject Audio_Object;
    public Vector2 AdjustUnit(Vector2 vec)
    {

        return new Vector2((int)(vec.x + 0.5f * Mathf.Sign(vec.x)), (int)(vec.y + 0.5f * Mathf.Sign(vec.y)));
    }
    public void OnClicktile()
    {
        GameObject[] GameController = GameObject.FindGameObjectsWithTag("Player");
        Instantiate(Audio_Object, transform.position, transform.rotation);
        //自分の座標を取得する
        Transform myTransform = this.transform;
        Vector2 _pos = myTransform.position;
        Vector2 pos = AdjustUnit(_pos);
        //親のオブジェクトを取得
        GameObject parentGameObject = transform.parent.gameObject;
        Debug.Log("生成する位置");
        Debug.Log(pos.x);
        Debug.Log(pos.y);

        //駒を動かす
        Instantiate(parentGameObject, new Vector2(pos.x, pos.y), Quaternion.identity);
        //生成したgridの情報を変更する1
        GameController[0].GetComponent<GameManager>().grid[3 - Mathf.FloorToInt(pos.y), Mathf.FloorToInt(pos.x) + 2] = 1;
        //もとの駒の座標を取得する
        Vector2 pos_p = parentGameObject.transform.position;

        GameController[0].GetComponent<GameManager>().grid[3 - Mathf.FloorToInt(pos_p.y), Mathf.FloorToInt(pos_p.x) + 2] = 0;
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
