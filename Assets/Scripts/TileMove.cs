using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMove : MonoBehaviour
{
    public GameObject Audio_Object;

    public Vector2 AdjustUnit(Vector2 vec)
    {

        return new Vector2((int)(vec.x + 0.5f * Mathf.Sign(vec.x)), (int)(vec.y + 0.5f * Mathf.Sign(vec.y)));
    }
    public void OnClicktile()
    {
        GameObject[] GameController = GameObject.FindGameObjectsWithTag("Player");
        //効果音
        Debug.Log("音が出る");
        //インスタンスを生成する
        Instantiate(Audio_Object, transform.position, transform.rotation);

        //自分の座標を取得する
        Transform myTransform = this.transform;
        Vector2 _pos = myTransform.position;
        Vector2 pos = AdjustUnit(_pos);
        //親のオブジェクトを取得
        GameObject parentGameObject = transform.parent.gameObject;
        Instantiate(parentGameObject, new Vector2(pos.x, pos.y), Quaternion.identity);
        //gridを変更する1
        GameController[0].GetComponent<GameManager>().grid[3 - Mathf.FloorToInt(pos.y), Mathf.FloorToInt(pos.x) + 2] = 1;
        //親の座標を取得する

        Vector2 _pos_p = parentGameObject.transform.position;
        Debug.Log("なくす");
        Debug.Log(3 - Mathf.FloorToInt(_pos_p.y));
        Vector2 pos_p = AdjustUnit(_pos_p);

        //親のgridを変更する0
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
            if(GameController[0].GetComponent<GameManager>().currentPlayer == 1)
            {
                GameController[0].GetComponent<GameManager>().currentPlayer = 0;
            }
            else
            {
 
            GameController[0].GetComponent<GameManager>().currentPlayer = 1;
            }
            
    }
}
