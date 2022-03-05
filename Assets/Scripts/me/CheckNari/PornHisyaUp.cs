using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PornHisyaUp : MonoBehaviour
{
    public GameObject tile;
    public void OnClickporn()
    {
        GameObject[] GameController = GameObject.FindGameObjectsWithTag("Player");
        GameController[0].GetComponent<GameManager>().currentPorn = 1;
        if (GameController[0].GetComponent<GameManager>().currentPlayer == 0)
        {
            GameObject[] objects = GameObject.FindGameObjectsWithTag("tilepre");
            foreach (GameObject tile in objects)
            {
                Destroy(tile);
            }
            //自分の座標を取得する
            Transform myTransform = this.transform;
            Vector2 pos = myTransform.position;
            //前の座標にオブジェクとがあるのか確認する
            //全体が共有するスクリプトで2次元配列で盤面の駒の有無を01等数字で管理
            Debug.Log("イベントを受け取る");
            //上に移動
            int i = 1;
            //gridの範囲分だけ行う
            while (pos.y + i <= 3 && pos.y + i >= -3)
            {
                GameObject tileobj;
                tileobj = (GameObject)Instantiate(tile, new Vector2(pos.x, pos.y + i), Quaternion.identity);
                tileobj.transform.parent = this.transform;
                if (GameController[0].GetComponent<GameManager>().grid[3 - Mathf.FloorToInt(pos.y) - i, Mathf.FloorToInt(pos.x) + 2] == 1)
                {
                    //駒があったとき終了
                    Debug.Log(3 - Mathf.FloorToInt(pos.y) - i);
                    Debug.Log(Mathf.FloorToInt(pos.x) + 2);
                    Debug.Log("駒を発見");
                    //tileobj = (GameObject)Instantiate(tile, new Vector2(pos.x, pos.y + i), Quaternion.identity);
                    //tileobj.transform.parent = this.transform;
                    break;
                }
                i++;
            }
            //下に移動する
            int n = 1;
            //gridの範囲分だけ行う
            while (pos.y - n <= 3 && pos.y - n >= -3)
            {
                GameObject tileobj;
                if (GameController[0].GetComponent<GameManager>().grid[3 - Mathf.FloorToInt(pos.y) + n, Mathf.FloorToInt(pos.x) + 2] == 1)
                {
                    Debug.Log(3 - Mathf.FloorToInt(pos.y) - i);
                    Debug.Log(Mathf.FloorToInt(pos.x) + 2);
                    Debug.Log("駒を発見");
                    tileobj = (GameObject)Instantiate(tile, new Vector2(pos.x, pos.y - n), Quaternion.identity);
                    tileobj.transform.parent = this.transform;
                    break;
                }


                tileobj = (GameObject)Instantiate(tile, new Vector2(pos.x, pos.y - n), Quaternion.identity);
                tileobj.transform.parent = this.transform;
                n++;
            }

            //左右1マス移動できる
            GameObject tile_extra;
            GameObject tile_ex;
            tile_extra = (GameObject)Instantiate(tile, new Vector2(pos.x + 1, pos.y), Quaternion.identity);
            tile_extra.transform.parent = this.transform;
            tile_ex = (GameObject)Instantiate(tile, new Vector2(pos.x - 1, pos.y), Quaternion.identity);
            tile_ex.transform.parent = this.transform;
        }
    }
}
