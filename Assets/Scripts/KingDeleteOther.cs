using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KingDeleteOther : MonoBehaviour
{
    GameObject GameController;
    // Start is called before the first frame update
    private void OnDestroy()
    {
        GameController = GameObject.FindGameObjectWithTag("Player");
        if (GameController.GetComponent<GameManager>().currentPlayer == 1)
        {
            Debug.Log("otherがまけた");
            //UIを取得して、そこのテキストを変更する
            GameObject parent = GameObject.FindGameObjectWithTag("cavas");

            GameObject child_text = parent.transform.Find("Text").gameObject;
            GameObject child_button = parent.transform.Find("Button").gameObject;
            child_button.SetActive(true);
            child_text.SetActive(true);
            //UIのテキストの値を変更して、表示する
            Text _text = child_text.GetComponent<Text>();
            _text.text = "黒が勝利";

        }
        Debug.Log("otherがmovve");
    }
}
