using System.Collections;
using UnityEngine;

public class humsterswark : MonoBehaviour
{
    // 移動速度
    public float speed = 2.0f;

    // Rigidbody
    private Rigidbody2D rb;

    // Use this for initialization
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {

        // 移動
        move();

    }

    private void move()
    {
        rb.velocity = new Vector2(speed, rb.velocity.y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if ("Side" == collision.gameObject.tag)
        {
            speed = speed * -1;

        }
    }
}