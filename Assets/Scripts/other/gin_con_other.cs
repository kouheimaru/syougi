using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gin_con_other : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject tile;
    GameObject Obj;
    GameObject Obj_b;
    GameObject Obj_c;
    GameObject Obj_d;
    GameObject Obj_e;
    GameObject Obj_h;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnClickporn()
    {
        GameObject[] GameController = GameObject.FindGameObjectsWithTag("Player");
        GameController[0].GetComponent<GameManager>().currentPorn = 2;
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
            Obj = (GameObject)Instantiate(tile, new Vector2(pos.x, pos.y + 1), Quaternion.identity);
            Obj.transform.parent = this.transform;
            Obj_b = (GameObject)Instantiate(tile, new Vector2(pos.x + 1, pos.y + 1), Quaternion.identity);
            Obj_b.transform.parent = this.transform;
            Obj_c = (GameObject)Instantiate(tile, new Vector2(pos.x - 1, pos.y + 1), Quaternion.identity);
            Obj_c.transform.parent = this.transform;
            Obj_d = (GameObject)Instantiate(tile, new Vector2(pos.x, pos.y - 1), Quaternion.identity);
            Obj_d.transform.parent = this.transform;
            Obj_e = (GameObject)Instantiate(tile, new Vector2(pos.x + 1, pos.y - 1), Quaternion.identity);
            Obj_e.transform.parent = this.transform;
            Obj_h = (GameObject)Instantiate(tile, new Vector2(pos.x - 1, pos.y - 1), Quaternion.identity);
            Obj_h.transform.parent = this.transform;
        }
    }
}
