using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishmovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    private Vector3 startingPosition;
    [SerializeField] private float distance = 5;
    [SerializeField] private float speed = 1;

    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        startingPosition = transform.position;
        rb.velocity = new Vector2(speed, 0);
        spriteRenderer.flipX = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (startingPosition.x - distance > transform.position.x)
        {
            rb.velocity = new Vector2(speed, 0);
            spriteRenderer.flipX = true;
        }
        else if (startingPosition.x + distance < transform.position.x)
        {
            rb.velocity = new Vector2(-speed, 0);
            spriteRenderer.flipX = false;
        }

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        death_script death = other.GetComponent<death_script>();
        death.Death();
    }
}