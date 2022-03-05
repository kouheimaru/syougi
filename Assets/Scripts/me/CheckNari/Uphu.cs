using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Uphu : MonoBehaviour
{
    public GameObject tile;
    GameObject Obj;
    GameObject Obj_a;
    GameObject Obj_b;
    GameObject Obj_c;


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
            Obj = (GameObject)Instantiate(tile, new Vector2(pos.x, pos.y + 1), Quaternion.identity);
            Obj.transform.parent = this.transform;
            Obj_a = (GameObject)Instantiate(tile, new Vector2(pos.x, pos.y - 1), Quaternion.identity);
            Obj_a.transform.parent = this.transform;

            Obj_b = (GameObject)Instantiate(tile, new Vector2(pos.x + 1, pos.y), Quaternion.identity);
            Obj_b.transform.parent = this.transform;
            Obj_c = (GameObject)Instantiate(tile, new Vector2(pos.x - 1, pos.y), Quaternion.identity);
            Obj_c.transform.parent = this.transform;

        }
    }
}
