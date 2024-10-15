using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float jumpstrength;
<<<<<<< Updated upstream
    
    private WaterChecker waterChecker;

    void Awake()
=======
    public LayerMask ground;

    // Start is called before the first frame update
    void Start()
>>>>>>> Stashed changes
    {
        waterChecker = GetComponent<WaterChecker>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A) == true)
        {
            myRigidbody.velocity = new Vector2(-6, myRigidbody.velocity.y);
        }

        if (Input.GetKey(KeyCode.D) == true)
        {
            myRigidbody.velocity = new Vector2(6, myRigidbody.velocity.y);
        }

<<<<<<< Updated upstream
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
=======

        RaycastHit2D raycastHit2D = Physics2D.Raycast(transform.position, Vector2.down, 1f, ground);
        if (raycastHit2D.collider != null)
        {
            Debug.Log(raycastHit2D.collider.name);
>>>>>>> Stashed changes
            if (Input.GetKeyDown(KeyCode.W) == true)
            {
                myRigidbody.velocity = Vector2.up * jumpstrength;
            }
        }
    }
}
