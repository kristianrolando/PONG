using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] PlayerScore score;

    public float x = 1f;
    public float y = 1f;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ResetBall();
    }

    public void ResetBall()
    {
        rb.velocity = Vector2.zero;
        transform.position = Vector2.zero;
        Invoke("PushBall", 2f);
    }
    void PushBall()
    {
        int ranDirection = Random.Range(0, 1);
        if(ranDirection == 0)
        {
            rb.AddForce(new Vector2(-x, y));
        }
        else
        {
            rb.AddForce(new Vector2(x, y));
        }


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Goal 1")
            score.scoreIncrement(1);
        else if(collision.tag == "Goal 2")
            score.scoreIncrement(2);
        ResetBall();
    }
}
