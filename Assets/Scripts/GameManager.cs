using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
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
    //盤面の情報設定
    public int[,] grid = new int[5, 5] 
    { { 0, 0, 0, 0, 0 },
      { 0, 0, 0, 0, 0 },
      { 0, 0, 0, 0, 0 }, 
      { 0, 0, 0, 0, 0 }, 
      { 0, 0, 0, 0, 0 }, };
void Start()
    {

        //プレイヤー0の駒を生成
        //上段
        Instantiate(Porn, new Vector2(-2, -1), Quaternion.identity);
        grid[3,0] = 1;
        Instantiate(Porn, new Vector2(-1, -1), Quaternion.identity);
        grid[3, 1] = 1;
        Instantiate(Porn, new Vector2(0, -1), Quaternion.identity);
        grid[3, 2] = 1;
        Instantiate(Porn, new Vector2(1, -1), Quaternion.identity);
        grid[3, 3] = 1;
        Instantiate(Porn, new Vector2(2, -1), Quaternion.identity);
        grid[3, 4] = 1;
        //下段
        Instantiate(Porngin, new Vector2(-2, -2), Quaternion.identity);
        grid[4, 0] = 1;
        Instantiate(Pornknight, new Vector2(-1, -2), Quaternion.identity);
        grid[4, 1] = 1;
        Instantiate(Pornking, new Vector2(0, -2), Quaternion.identity);
        grid[4, 2] = 1;
        Instantiate(Pornknight, new Vector2(1, -2), Quaternion.identity);
        grid[4, 3] = 1;
        Instantiate(Pornhisya, new Vector2(2, -2), Quaternion.identity);
        grid[4, 4] = 1;

        //プレイヤー1の駒を生成
        //上段
        Instantiate(Porn_other, new Vector2(-2, 1), Quaternion.identity);
        grid[1, 0] = 1;
        Instantiate(Porn_other, new Vector2(-1, 1), Quaternion.identity);
        grid[1, 1] = 1;
        Instantiate(Porn_other, new Vector2(0, 1), Quaternion.identity);
        grid[1, 2] = 1;
        Instantiate(Porn_other, new Vector2(1, 1), Quaternion.identity);
        grid[1, 3] = 1;
        Instantiate(Porn_other, new Vector2(2, 1), Quaternion.identity);
        grid[1, 4] = 1;
        //下段
        Instantiate(Pornhisya_other, new Vector2(-2, 2), Quaternion.identity);
        grid[0, 0] = 1;
        Instantiate(Pornknight_other, new Vector2(-1, 2), Quaternion.identity);
        grid[0, 1] = 1;
        Instantiate(Pornking_other, new Vector2(0, 2), Quaternion.identity);
        grid[0, 2] = 1;
        Instantiate(Pornknight_other, new Vector2(1, 2), Quaternion.identity);
        grid[0, 3] = 1;
        Instantiate(Porngin_other, new Vector2(2, 2), Quaternion.identity);
        grid[0, 4] = 1;
    }
}
