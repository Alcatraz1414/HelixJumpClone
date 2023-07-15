using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ring : MonoBehaviour
{

    public Transform ball;
    private GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y + 12.5f > ball.position.y)  // 12.5f yazmamýzýn sebebi ringlerin pozisyonu 0 iken top onlara göre +12f> civarý daha yüksekten baþlýyor
        {
            Destroy(gameObject);
            gameManager.GameScore(25);
        }
    }
}
