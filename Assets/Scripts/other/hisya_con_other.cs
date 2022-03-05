﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hisya_con_other : MonoBehaviour
{
    public GameObject tile;

    // Start is called before the first frame update
    public void OnClickporn()
    {
        GameObject[] GameController = GameObject.FindGameObjectsWithTag("Player");
        //駒の種類を更新する
        GameController[0].GetComponent<GameManager>().currentPorn = 5;

        if (GameController[0].GetComponent<GameManager>().currentPlayer == 1)
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
            //上に移動
            int i = 1;

            while (pos.y + i <= 3 && pos.y + i >= -3)
            {
                GameObject tileobj;
                Debug.Log(2 - Mathf.FloorToInt(pos.y) - i);
                Debug.Log(Mathf.FloorToInt(pos.x) + 2);
                if (GameController[0].GetComponent<GameManager>().grid[3 - Mathf.FloorToInt(pos.y) - i, Mathf.FloorToInt(pos.x) + 2] == 1)
                {
                    //駒があったとき終了
                    tileobj = (GameObject)Instantiate(tile, new Vector2(pos.x, pos.y + i), Quaternion.identity);
                    tileobj.transform.parent = this.transform;
                    break;
                }
                tileobj = (GameObject)Instantiate(tile, new Vector2(pos.x, pos.y + i), Quaternion.identity);
                tileobj.transform.parent = this.transform;
                i++;
            }
            //下に移動する
            int n = 1;
            while (pos.y - n <= 3 && pos.y - n >= -3)
            {
                GameObject tileobj;
                if (GameController[0].GetComponent<GameManager>().grid[3 - Mathf.FloorToInt(pos.y) + n, Mathf.FloorToInt(pos.x) + 2] == 1)
                {
                    tileobj = (GameObject)Instantiate(tile, new Vector2(pos.x, pos.y - n), Quaternion.identity);
                    tileobj.transform.parent = this.transform;
                    break;
                }

                tileobj = (GameObject)Instantiate(tile, new Vector2(pos.x, pos.y - n), Quaternion.identity);
                tileobj.transform.parent = this.transform;
                n++;
            }
        }
    }
}
