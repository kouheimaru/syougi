using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileCheck : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject GetSprite;
    public GameObject UpgradeSprite;
    GameObject Obj;
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("設置");
        GameObject[] GameController = GameObject.FindGameObjectsWithTag("Player");

        if (other.CompareTag("enemy"))
        {
            Debug.Log("プレイヤー1enemyの駒を確認");
            if (GameController[0].GetComponent<GameManager>().currentPlayer == 0)
            {
                //自分の座標を取得する
                Transform myTransform = this.transform;
                Vector2 pos = myTransform.position;
                //同じ場所にplayer1なら赤色を生成する
                //Instantiate(GetSprite, new Vector2(pos.x, pos.y), Quaternion.identity);
                Obj = (GameObject)Instantiate(GetSprite, new Vector2(pos.x, pos.y), Quaternion.identity);
                Obj.transform.parent = this.transform.parent;
                //自身を削除しておく
                Destroy(this.gameObject);
               
            }
            else
            {
                //player0なら表示しない
                //自分の座標を取得する
                Transform myTransform = this.transform;
                Vector2 pos = myTransform.position;
                Obj = (GameObject)Instantiate(UpgradeSprite, new Vector2(pos.x, pos.y), Quaternion.identity);
                Obj.transform.parent = this.transform.parent;
                Destroy(this.gameObject);
            }
        }
        if (other.CompareTag("me"))
        {
            Debug.Log("プレイヤー0meの駒を確認");
            if (GameController[0].GetComponent<GameManager>().currentPlayer == 0)
            {
                //自分の座標を取得する
                Transform myTransform = this.transform;
                Vector2 pos = myTransform.position;
                Obj = (GameObject)Instantiate(UpgradeSprite, new Vector2(pos.x, pos.y), Quaternion.identity);
                Obj.transform.parent = this.transform.parent;
                //player0なら表示しない
                Destroy(this.gameObject);
                
            }
            else
            {
                //自分の座標を取得する
                Transform myTransform = this.transform;
                Vector2 pos = myTransform.position;
                //同じ場所にplayer1なら赤色を生成する
                //Instantiate(GetSprite, new Vector2(pos.x, pos.y), Quaternion.identity);
                Obj = (GameObject)Instantiate(GetSprite, new Vector2(pos.x, pos.y), Quaternion.identity);
                Obj.transform.parent = this.transform.parent;
                //自身を削除しておく
                Destroy(this.gameObject);

            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
