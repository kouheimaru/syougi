using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TraslateColor : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Awake()
    {
        this.spriteRenderer = GetComponent<SpriteRenderer>();
        ChangeTransparency(0); // 完全に透明にする
    }
    void ChangeTransparency(float alpha)
    {
        this.spriteRenderer.color = new Color(1, 1, 1, alpha);
    }
}
