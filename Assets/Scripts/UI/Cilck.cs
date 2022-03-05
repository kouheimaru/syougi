using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cilck : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    public void ButtonClick()
    {
        Debug.Log("ボタンがクリックされた");
        GameObject GameController = GameObject.FindGameObjectWithTag("Player");
        GameController.GetComponent<GameManager>().Restart();
        //画面に駒を全削除
        //駒を再配置する
        
        //配列情報の初期化
        //GameController.GetComponent<GameManager>().grid
    }
}
