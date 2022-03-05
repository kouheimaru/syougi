using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KingDelete : MonoBehaviour
{
    // Start is called before the first frame update

    private void OnDestroy()
    {
        GameObject GameController = GameObject.FindGameObjectWithTag("Player");
        if (GameController.GetComponent<GameManager>().currentPlayer == 0)
        {
        Debug.Log("meがまけた");
        //UIのゲームオブジェクトを取得する
        GameObject parent = GameObject.FindGameObjectWithTag("cavas");
            GameObject child = parent.transform.Find("Text").gameObject;
            GameObject child_button = parent.transform.Find("Button").gameObject;
            child.SetActive(true);
            child_button.SetActive(true);
            //UIのテキストの値を変更して、表示する
            Text _text = child.GetComponent<Text>();
            _text.text = "白が勝利";
        }
        Debug.Log("meがmovve");
    }

}
