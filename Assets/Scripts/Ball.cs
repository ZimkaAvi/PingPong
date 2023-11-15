using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] float speedX, speedY;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(speedX, speedY);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name.Equals("RightBorder"))
        {
            Time.timeScale = 0;
        }
    }
}
