using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public float rand;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        Invoke("GoBall",2);
    }

    void GoBall()
    {
        rand = Random.RandomRange(2,10);
        if (rand < 1) rb2d.AddForce(new Vector2(20, -15));
        else rb2d.AddForce(new Vector2(-20, -15));
    }

    void ResetBall()
    {
        rb2d.velocity = Vector2.zero;
        transform.position = Vector2.zero;
    }

    void RestartGame()
    {
        //Debug.Log("dua");
        ResetBall();
        Invoke("GoBall", 1);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
