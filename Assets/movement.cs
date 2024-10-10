using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float jumpstrength;
    
    private WaterChecker waterChecker;

    void Awake()
    {
        waterChecker = GetComponent<WaterChecker>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A) == true)
        {
            myRigidbody.velocity = Vector2.left * 6;
        }

        if (Input.GetKey(KeyCode.D) == true)
        {
            myRigidbody.velocity = Vector2.right * 6;
        }

        if (waterChecker.IsInWater())
        {
            if (Input.GetKey(KeyCode.W))
            {
                myRigidbody.velocity = Vector2.up * 6;
            }
            else if (Input.GetKey(KeyCode.S))
            {
                myRigidbody.velocity = Vector2.down * 6;
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.W) == true)
            {
                myRigidbody.velocity = Vector2.up * jumpstrength;
            }
        }
    }
}
