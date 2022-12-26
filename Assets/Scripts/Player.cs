using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    GameObject gameManager; //置放GameManager物件的公開變數
    AudioSource audioSource;
    public AudioClip Walk;
    public AudioClip Hurt;
    void Start()
    {
        gameManager = GameObject.Find("GameManager");
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        // 點擊左方向鈕時
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            audioSource.PlayOneShot(Walk);
            transform.Translate(-3, 0, 0); // 往左移動「3」
        }

        // 點擊左方向鈕時
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            audioSource.PlayOneShot(Walk);
            transform.Translate(3, 0, 0); // 往右移動「3」
        }
    }

    // 當貓咪碰到其他有碰撞體的東西時
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Arrow")
        {
            audioSource.PlayOneShot(Hurt);
            gameManager.GetComponent<GameManager>().DecreaseHp();
            
        }
        if (collision.tag == "catfood")
        {
            gameManager.GetComponent<GameManager>().AddHp();
            audioSource.PlayOneShot(Hurt);
        }

    }
   

    // 當玩家按下畫面左按鍵時，貓咪往左移動「3」
    public void LButtonDown()
    {
        audioSource.PlayOneShot(Walk);
        transform.Translate(-3, 0, 0);
    }

    // 當玩家按下畫面右按鍵時，貓咪往右移動「3」
    public void RButtonDown()
    {
        audioSource.PlayOneShot(Walk);
        transform.Translate(3, 0, 0);
    }

}
