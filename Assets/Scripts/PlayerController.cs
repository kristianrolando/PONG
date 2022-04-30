using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 2f;

    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        float inputY = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector2(rb.velocity.x, speed * inputY);
    }

}
