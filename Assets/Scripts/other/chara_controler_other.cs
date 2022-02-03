using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chara_controler_other : MonoBehaviour
{
    public GameObject tile;
    GameObject Obj;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //自分の座標を取得する
        //Transform myTransform = this.transform;
        //Vector2 pos = myTransform.position;

        //クリックされたとき動ける範囲を表示する


        //範囲を表示中のときに、自身をクリックしたときを、範囲を消す

    }

    public void OnClickporn()
    {
        GameObject[] GameController = GameObject.FindGameObjectsWithTag("Player");
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
            Obj = (GameObject)Instantiate(tile, new Vector2(pos.x, pos.y - 1), Quaternion.identity);
            Obj.transform.parent = this.transform;

        }
    }
}
