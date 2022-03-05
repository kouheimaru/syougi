using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightOtherUp : MonoBehaviour
{
    public GameObject tile;
    GameObject[] Obj;
    public void OnClickporn()
    {
        GameObject[] GameController = GameObject.FindGameObjectsWithTag("Player");
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
            Vector2 pos = myTransform.position;
            Obj[0] = (GameObject)Instantiate(tile, new Vector2(pos.x - 1, pos.y + 2), Quaternion.identity);
            Obj[0].transform.parent = this.transform;
            Obj[1] = (GameObject)Instantiate(tile, new Vector2(pos.x + 1, pos.y + 2), Quaternion.identity);
            Obj[1].transform.parent = this.transform;
            //追加移動座標(上)
            Obj[1] = (GameObject)Instantiate(tile, new Vector2(pos.x + 2, pos.y + 1), Quaternion.identity);
            Obj[1].transform.parent = this.transform;
            Obj[2] = (GameObject)Instantiate(tile, new Vector2(pos.x - 2, pos.y + 1), Quaternion.identity);
            Obj[2].transform.parent = this.transform;
            //追加移動座標（下）
            Obj[3] = (GameObject)Instantiate(tile, new Vector2(pos.x + 2, pos.y - 1), Quaternion.identity);
            Obj[3].transform.parent = this.transform;
            Obj[4] = (GameObject)Instantiate(tile, new Vector2(pos.x - 2, pos.y - 1), Quaternion.identity);
            Obj[4].transform.parent = this.transform;

            Obj[5] = (GameObject)Instantiate(tile, new Vector2(pos.x + 2, pos.y - 2), Quaternion.identity);
            Obj[5].transform.parent = this.transform;
            Obj[6] = (GameObject)Instantiate(tile, new Vector2(pos.x - 2, pos.y - 2), Quaternion.identity);
            Obj[6].transform.parent = this.transform;
        }

    }
}
