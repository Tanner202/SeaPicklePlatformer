using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishmovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    private Vector3 startingPosition;
    private float distance = 5;

    // Start is called before the first frame update
    void Start()
    {
        startingPosition = transform.position;
        rb.velocity = new Vector2(1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (startingPosition.x - distance > transform.position.x)
        {
            rb.velocity = new Vector2(1, 0);
        }
        else if (startingPosition.x + distance < transform.position.x)
        {
            rb.velocity = new Vector2(-1, 0);
        }
    }
}
