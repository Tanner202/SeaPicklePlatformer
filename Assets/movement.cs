using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float jumpstrength;
    public float waterMoveSpeed = 2f;
    public float landMoveSpeed = 4;
    public float defaultGravityScale;
    public float waterGravityScale = 0.2f;
    
    private WaterChecker waterChecker;

    public LayerMask ground;

    // Start is called before the first frame update
    void Start()
    {
        waterChecker = GetComponent<WaterChecker>();
        defaultGravityScale = myRigidbody.gravityScale;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A) == true)
        {
            myRigidbody.velocity = new Vector2(-landMoveSpeed, myRigidbody.velocity.y);
        }
        else if (Input.GetKey(KeyCode.D) == true)
        {
            myRigidbody.velocity = new Vector2(landMoveSpeed, myRigidbody.velocity.y);
        }
        else
        {
            myRigidbody.velocity = new Vector2(0, myRigidbody.velocity.y);
        }

        if (waterChecker.IsInWater())
        {
            myRigidbody.gravityScale = waterGravityScale;
            if (Input.GetKey(KeyCode.W))
            {
                myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, waterMoveSpeed);
            }
            
            if (Input.GetKey(KeyCode.S))
            {
                myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, -waterMoveSpeed);
            }
        }
        else
        {
            myRigidbody.gravityScale = defaultGravityScale;
            RaycastHit2D raycastHit2D = Physics2D.Raycast(transform.position, Vector2.down, 1f, ground);
            if (raycastHit2D.collider != null)
            {
                Debug.Log(raycastHit2D.collider.name);
                if (Input.GetKeyDown(KeyCode.W) == true)
                {
                    myRigidbody.velocity = Vector2.up * jumpstrength;
                }
            }
        }
    }
}
