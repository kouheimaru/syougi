using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject floor;
    public GameObject Porn;
    public GameObject Pornking;
    public GameObject Pornknight;
    public GameObject Pornhisya;
    public GameObject Porngin;

    public GameObject Porn_other;
    public GameObject Pornking_other;
    public GameObject Pornknight_other;
    public GameObject Pornhisya_other;
    public GameObject Porngin_other;

    public int currentPlayer = 0;
    public int currentPorn = 0;
    //盤面の情報設定
    public int[,] grid = new int[7, 5] 
    { { 0, 0, 0, 0, 0 },
      { 0, 0, 0, 0, 0 },
      { 0, 0, 0, 0, 0 }, 
      { 0, 0, 0, 0, 0 },
      { 0, 0, 0, 0, 0 },
      { 0, 0, 0, 0, 0 },
      { 0, 0, 0, 0, 0 }, };
void Start()
    {
        for (int i= 0; i < 5; i++)
        {
            for(int j=0; j < 7; j++)
            {
                Instantiate(floor, new Vector2(i - 2, j - 3), Quaternion.identity);
            }

        }
        
        //プレイヤー0の駒を生成
        //上段
        Instantiate(Porn, new Vector2(-2, -2), Quaternion.identity);
        grid[5, 0] = 1;
        Instantiate(Porn, new Vector2(-1, -2), Quaternion.identity);
        grid[5, 1] = 1;
        Instantiate(Porn, new Vector2(0, -2), Quaternion.identity);
        grid[5, 2] = 1;
        Instantiate(Porn, new Vector2(1, -2), Quaternion.identity);
        grid[5, 3] = 1;
        Instantiate(Porn, new Vector2(2, -2), Quaternion.identity);
        grid[5, 4] = 1;
        //下段
        Instantiate(Porngin, new Vector2(-2, -3), Quaternion.identity);
        grid[6, 0] = 1;
        Instantiate(Pornknight, new Vector2(-1, -3), Quaternion.identity);
        grid[6, 1] = 1;
        Instantiate(Pornking, new Vector2(0, -3), Quaternion.identity);
        grid[6, 2] = 1;
        Instantiate(Pornknight, new Vector2(1, -3), Quaternion.identity);
        grid[6, 3] = 1;
        Instantiate(Pornhisya, new Vector2(2, -3), Quaternion.identity);
        grid[6, 4] = 1;

        //プレイヤー1の駒を生成
        //上段
        Instantiate(Porn_other, new Vector2(-2, 2), Quaternion.identity);
        grid[1, 0] = 1;
        Instantiate(Porn_other, new Vector2(-1, 2), Quaternion.identity);
        grid[1, 1] = 1;
        Instantiate(Porn_other, new Vector2(0, 2), Quaternion.identity);
        grid[1, 2] = 1;
        Instantiate(Porn_other, new Vector2(1, 2), Quaternion.identity);
        grid[1, 3] = 1;
        Instantiate(Porn_other, new Vector2(2, 2), Quaternion.identity);
        grid[1, 4] = 1;
        //下段
        Instantiate(Pornhisya_other, new Vector2(-2, 3), Quaternion.identity);
        grid[0, 0] = 1;
        Instantiate(Pornknight_other, new Vector2(-1, 3), Quaternion.identity);
        grid[0, 1] = 1;
        Instantiate(Pornking_other, new Vector2(0, 3), Quaternion.identity);
        grid[0, 2] = 1;
        Instantiate(Pornknight_other, new Vector2(1, 3), Quaternion.identity);
        grid[0, 3] = 1;
        Instantiate(Porngin_other, new Vector2(2, 3), Quaternion.identity);
        grid[0, 4] = 1;
    }
    //初期化関数を用意する
    public void Restart()
    {
        //画面上のすべての駒を破棄する
        GameObject [] me_porns = GameObject.FindGameObjectsWithTag("me");
        GameObject[] enemy_porns = GameObject.FindGameObjectsWithTag("enemy");
        foreach (GameObject porn in me_porns)
        {
            // 消す！
            Destroy(porn);
        }
        foreach (GameObject porn in enemy_porns)
        {
            // 消す！
            Destroy(porn);
        }
        //駒を配置する
        //プレイヤー0の駒を生成
        //上段
        Instantiate(Porn, new Vector2(-2, -2), Quaternion.identity);
        grid[5, 0] = 1;
        Instantiate(Porn, new Vector2(-1, -2), Quaternion.identity);
        grid[5, 1] = 1;
        Instantiate(Porn, new Vector2(0, -2), Quaternion.identity);
        grid[5, 2] = 1;
        Instantiate(Porn, new Vector2(1, -2), Quaternion.identity);
        grid[5, 3] = 1;
        Instantiate(Porn, new Vector2(2, -2), Quaternion.identity);
        grid[5, 4] = 1;
        //下段
        Instantiate(Porngin, new Vector2(-2, -3), Quaternion.identity);
        grid[6, 0] = 1;
        Instantiate(Pornknight, new Vector2(-1, -3), Quaternion.identity);
        grid[6, 1] = 1;
        Instantiate(Pornking, new Vector2(0, -3), Quaternion.identity);
        grid[6, 2] = 1;
        Instantiate(Pornknight, new Vector2(1, -3), Quaternion.identity);
        grid[6, 3] = 1;
        Instantiate(Pornhisya, new Vector2(2, -3), Quaternion.identity);
        grid[6, 4] = 1;

        //プレイヤー1の駒を生成
        //上段
        Instantiate(Porn_other, new Vector2(-2, 2), Quaternion.identity);
        grid[1, 0] = 1;
        Instantiate(Porn_other, new Vector2(-1, 2), Quaternion.identity);
        grid[1, 1] = 1;
        Instantiate(Porn_other, new Vector2(0, 2), Quaternion.identity);
        grid[1, 2] = 1;
        Instantiate(Porn_other, new Vector2(1, 2), Quaternion.identity);
        grid[1, 3] = 1;
        Instantiate(Porn_other, new Vector2(2, 2), Quaternion.identity);
        grid[1, 4] = 1;
        //下段
        Instantiate(Pornhisya_other, new Vector2(-2, 3), Quaternion.identity);
        grid[0, 0] = 1;
        Instantiate(Pornknight_other, new Vector2(-1, 3), Quaternion.identity);
        grid[0, 1] = 1;
        Instantiate(Pornking_other, new Vector2(0, 3), Quaternion.identity);
        grid[0, 2] = 1;
        Instantiate(Pornknight_other, new Vector2(1, 3), Quaternion.identity);
        grid[0, 3] = 1;
        Instantiate(Porngin_other, new Vector2(2, 3), Quaternion.identity);
        grid[0, 4] = 1;
        //ゲームのUIも初期化する
        GameObject parent = GameObject.FindGameObjectWithTag("cavas");

        GameObject child_text = parent.transform.Find("Text").gameObject;
        GameObject child_button = parent.transform.Find("Button").gameObject;
        child_button.SetActive(false);
        child_text.SetActive(false);

        //グリッド情報の初期化
        grid[2, 0] = 0;
        grid[2, 1] = 0;
        grid[2, 2] = 0;
        grid[2, 3] = 0;
        grid[2, 4] = 0;

        grid[3, 0] = 0;
        grid[3, 1] = 0;
        grid[3, 2] = 0;
        grid[3, 3] = 0;
        grid[3, 4] = 0;

        grid[4, 0] = 0;
        grid[4, 1] = 0;
        grid[4, 2] = 0;
        grid[4, 3] = 0;
        grid[4, 4] = 0;

        Debug.Log("初期化する");

    }
}
