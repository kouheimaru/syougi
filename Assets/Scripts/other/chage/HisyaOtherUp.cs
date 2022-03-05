using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HisyaOtherUp : MonoBehaviour
{
    public GameObject tile;
    public Vector2 AdjustUnit(Vector2 vec)
    {

        return new Vector2((int)(vec.x + 0.5f * Mathf.Sign(vec.x)), (int)(vec.y + 0.5f * Mathf.Sign(vec.y)));
    }

    // Start is called before the first frame update
    public void OnClickporn()
    {
        GameObject[] GameController = GameObject.FindGameObjectsWithTag("Player");
        //駒の種類を更新する
        GameController[0].GetComponent<GameManager>().currentPorn = 1;

        if (GameController[0].GetComponent<GameManager>().currentPlayer == 1)
        {
            GameObject[] objects = GameObject.FindGameObjectsWithTag("tilepre");
            foreach (GameObject tile in objects)
            {
                Destroy(tile);
            }
            //自分の座標を取得する
            Transform myTransform = this.transform;
            Vector2 _pos = myTransform.position;
            Vector2 pos = AdjustUnit(_pos);
            //前の座標にオブジェクとがあるのか確認する
            //全体が共有するスクリプトで2次元配列で盤面の駒の有無を01等数字で管理
            //上に移動
            int i = 1;
            while (3 - Mathf.FloorToInt(pos.y) - i >= 0)
            {
                GameObject tileobj;
                Debug.Log(3 - Mathf.FloorToInt(pos.y) - i);
                Debug.Log(GameController[0].GetComponent<GameManager>().grid[3 - Mathf.FloorToInt(pos.y) - i, Mathf.FloorToInt(pos.x) + 2]);
                if (GameController[0].GetComponent<GameManager>().grid[3 - Mathf.FloorToInt(pos.y) - i, Mathf.FloorToInt(pos.x) + 2] == 1)
                {
                    //駒があったとき終了
                    tileobj = (GameObject)Instantiate(tile, new Vector2(pos.x, Mathf.FloorToInt(pos.y) + i), Quaternion.identity);
                    tileobj.transform.parent = this.transform;


                    Debug.Log("駒を発見する");
                    break;
                }
                tileobj = (GameObject)Instantiate(tile, new Vector2(pos.x, Mathf.FloorToInt(pos.y) + i), Quaternion.identity);
                tileobj.transform.parent = this.transform;
                i++;
            }
            //下に移動する

            Debug.Log("下の移動処理");

            int n = 1;
            while (3 - Mathf.FloorToInt(pos.y) + n < 7)
            {
                GameObject tileobj;
                Debug.Log("nの値");
                Debug.Log(n);

                Debug.Log(3 - pos.y + n);
                if (GameController[0].GetComponent<GameManager>().grid[3 - Mathf.FloorToInt(pos.y) + n, Mathf.FloorToInt(pos.x) + 2] == 1)
                {
                    tileobj = (GameObject)Instantiate(tile, new Vector2(pos.x, Mathf.FloorToInt(pos.y) - n), Quaternion.identity);
                    tileobj.transform.parent = this.transform;
                    Debug.Log("komawohakken");
                    break;
                }


                tileobj = (GameObject)Instantiate(tile, new Vector2(pos.x, Mathf.FloorToInt(pos.y) - n), Quaternion.identity);
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
