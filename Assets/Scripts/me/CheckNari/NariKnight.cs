using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NariKnight : MonoBehaviour
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
            GameObject Obj;
            GameObject Obj_a;
            GameObject Obj_b;
            GameObject Obj_c;
            GameObject Obj_d;
            GameObject Obj_e;
            GameObject Obj_f;
            GameObject Obj_g;
            Obj = (GameObject)Instantiate(tile, new Vector2(pos.x - 1, pos.y + 2), Quaternion.identity);
            Obj.transform.parent = this.transform;
            Obj_a = (GameObject)Instantiate(tile, new Vector2(pos.x + 1, pos.y + 2), Quaternion.identity);
            Obj_a.transform.parent = this.transform;
            //追加移動座標(上)
            Obj_b = (GameObject)Instantiate(tile, new Vector2(pos.x + 2, pos.y + 1), Quaternion.identity);
            Obj_b.transform.parent = this.transform;
            Obj_c = (GameObject)Instantiate(tile, new Vector2(pos.x - 2, pos.y + 1), Quaternion.identity);
            Obj_c.transform.parent = this.transform;
            //追加移動座標（下）
            Obj_d = (GameObject)Instantiate(tile, new Vector2(pos.x + 2, pos.y - 1), Quaternion.identity);
            Obj_d.transform.parent = this.transform;
            Obj_e = (GameObject)Instantiate(tile, new Vector2(pos.x - 2, pos.y - 1), Quaternion.identity);
            Obj_e.transform.parent = this.transform;

            Obj_f = (GameObject)Instantiate(tile, new Vector2(pos.x + 1, pos.y - 2), Quaternion.identity);
            Obj_f.transform.parent = this.transform;
            Obj_g = (GameObject)Instantiate(tile, new Vector2(pos.x - 1, pos.y - 2), Quaternion.identity);
            Obj_g.transform.parent = this.transform;
        }

    }
}
