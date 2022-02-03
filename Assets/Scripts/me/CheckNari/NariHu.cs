using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NariHu : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {

        //自分の座標を取得する
        Transform myTransform = this.transform;
        Vector2 pos = myTransform.position;
        //check postion for enemyare
        if (pos.y>=1)
        {
            //画面中央に成りの確認テキストを表示する

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
