using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KingDeleteOther : MonoBehaviour
{
    private bool canJudge = true;
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other)
    {
        if (canJudge)
        {
            // 衝突判定時のアクションをここに書く
            GameObject GameController = GameObject.FindGameObjectWithTag("Player");
            if (GameController.GetComponent<GameManager>().currentPlayer == 1)
            {
                if (other.CompareTag("me"))
                {
                    //負けたとき
                    Destroy(this.gameObject);

                }
            }
            canJudge = false;
        }
        if (other.CompareTag("king")||other.CompareTag("tilepre"))
        {
            canJudge = true;
        }

    }
    private void OnDestroy()
    {
        GameObject GameController = GameObject.FindGameObjectWithTag("Player");
        if (GameController.GetComponent<GameManager>().currentPlayer == 1)
        {
            Debug.Log("otherがまけた");
            //UIのゲームオブジェクトを取得する
            GameObject parent = GameObject.FindGameObjectWithTag("cavas");
            GameObject child = parent.transform.Find("Text").gameObject;
            GameObject child_button = parent.transform.Find("Button").gameObject;
            child.SetActive(true);
            child_button.SetActive(true);
            //UIのテキストの値を変更して、表示する
            Text _text = child.GetComponent<Text>();
            _text.text = "black win";
        }
 
    }
}
