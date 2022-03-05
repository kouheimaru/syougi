using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrade : MonoBehaviour
{
    //敵の駒
    public GameObject UpObj_hisya_other;
    public GameObject UpObj_gin_other;
    public GameObject UpObj_hu_other;
    public GameObject UpObj_kei_other;

    //自分の駒
    public GameObject UpObj_hisya;
    public GameObject UpObj_gin;
    public GameObject UpObj_hu;
    public GameObject UpObj_kei;

    public GameObject Audio_Object;

    public Vector2 AdjustUnit(Vector2 vec)
    {

        return new Vector2((int)(vec.x + 0.5f * Mathf.Sign(vec.x)), (int)(vec.y + 0.5f * Mathf.Sign(vec.y)));
    }

    private void Awake()
    {
        GameObject[] GameController = GameObject.FindGameObjectsWithTag("Player");

        if(GameController[0].GetComponent<GameManager>().currentPorn == 1)
        {
            Destroy(this.gameObject);
        }
    }

    

    public void OnClicktile()
    {
        Debug.Log("進化しますよ");
        GameObject[] GameController = GameObject.FindGameObjectsWithTag("Player");
        Instantiate(Audio_Object, transform.position, transform.rotation);
        //自分の座標を取得する
        Transform myTransform = this.transform;
        Vector2 _pos = myTransform.position;
        Vector2 pos = AdjustUnit(_pos);
        //親のオブジェクトを取得
        GameObject parentGameObject = transform.parent.gameObject;


        if (GameController[0].GetComponent<GameManager>().currentPlayer == 1)
        {
        //敵の駒のとき
        //girdを設定する
        GameController[0].GetComponent<GameManager>().grid[3 - Mathf.FloorToInt(pos.y), Mathf.FloorToInt(pos.x) + 2] = 1;
            //Instantiate(UpObj_hisya, new Vector2(pos.x, pos.y), Quaternion.identity);
            //それぞれ親の情報を基にして、進化先を指定する。
            switch (GameController[0].GetComponent<GameManager>().currentPorn)
            {
                //歩のとき
                case 6:
                    Instantiate(UpObj_hu_other, new Vector2(pos.x, pos.y), Quaternion.identity);
                    break;
                //槍のとき
                case 5:
                    Instantiate(UpObj_hisya_other, new Vector2(pos.x, pos.y), Quaternion.identity);
                    break;
                //馬
                case 4:
                    Instantiate(UpObj_kei_other, new Vector2(pos.x, pos.y), Quaternion.identity);
                    break;
                //銀のとき
                case 2:
                    Instantiate(UpObj_gin_other, new Vector2(pos.x, pos.y), Quaternion.identity);
                    break;

            }


        }
        else
        {
        //自分の駒の時
        //girdを設定する
        GameController[0].GetComponent<GameManager>().grid[3 - Mathf.FloorToInt(pos.y), Mathf.FloorToInt(pos.x) + 2] = 1;
            //それぞれ親の情報を基にして、進化先を指定する。
            switch (GameController[0].GetComponent<GameManager>().currentPorn)
            {
                //歩のとき
                case 6:
                    Instantiate(UpObj_hu, new Vector2(pos.x, pos.y), Quaternion.identity);
                    break;
                //槍のとき
                case 5:
                    Instantiate(UpObj_hisya, new Vector2(pos.x, pos.y), Quaternion.identity);
                    break;
                //馬
                case 4:
                    Instantiate(UpObj_kei, new Vector2(pos.x, pos.y), Quaternion.identity);
                    break;
                //銀のとき
                case 2:
                    Instantiate(UpObj_gin, new Vector2(pos.x, pos.y), Quaternion.identity);
                    break;

            }
            

        }
        //もとの駒の座標を取得する
        Vector2 pos_p = parentGameObject.transform.position;
        //gridの指定を0になおす
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
        if (GameController[0].GetComponent<GameManager>().currentPlayer == 1)
        {
            Debug.Log("プレイヤー切り替え");
            GameController[0].GetComponent<GameManager>().currentPlayer = 0;
            GameController[0].GetComponent<GameManager>().currentPorn = 0;

        }
        else
        {
            Debug.Log("プレイヤー切り替え");
            GameController[0].GetComponent<GameManager>().currentPlayer = 1;
            GameController[0].GetComponent<GameManager>().currentPorn = 0;

        }

    }
}