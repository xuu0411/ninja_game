using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    GameObject gameManager;
    bool IsIncreaseScore = false;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager");
        Destroy(gameObject, 3); // 3秒後，刪除自己
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -6.5 && IsIncreaseScore == false)
        {
            gameManager.GetComponent<GameManager>().IncreaseScore();

        }
    }

    // 當箭頭碰到其他有碰撞體的東西時
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Increase Score")
        {
            gameManager.GetComponent<GameManager>().IncreaseScore();
       
        }
        Destroy(gameObject);
    }
}
