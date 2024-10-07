using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float jumpstrength;
    // Start is called before the first frame update
    void Start()
    {
        
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


        if (Input.GetKeyDown(KeyCode.W) == true)
        {
            myRigidbody.velocity = Vector2.up * jumpstrength;
        }
    }
}
