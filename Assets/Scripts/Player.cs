using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject gameManager; //置放GameManager物件的公開變數

    void Start()
    {
    }

    void Update()
    {
        // 點擊左方向鈕時
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            GetComponent<AudioSource>().Play();
            transform.Translate(-3, 0, 0); // 往左移動「3」
        }

        // 點擊左方向鈕時
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            GetComponent<AudioSource>().Play();
            transform.Translate(3, 0, 0); // 往右移動「3」
        }
    }

    // 當貓咪碰到其他有碰撞體的東西時
    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameManager.GetComponent<GameManager>().DecreaseHp(); // 扣血
    }

    // 當玩家按下畫面左按鍵時，貓咪往左移動「3」
    public void LButtonDown()
    {
        GetComponent<AudioSource>().Play();
        transform.Translate(-3, 0, 0);
    }

    // 當玩家按下畫面右按鍵時，貓咪往右移動「3」
    public void RButtonDown()
    {
        GetComponent<AudioSource>().Play();
        transform.Translate(3, 0, 0);
    }

}
