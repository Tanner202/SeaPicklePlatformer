using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oxygen : MonoBehaviour
{
    [SerializeField] private float maxOxygen;
    [SerializeField] private float oxygenRegenerationSpeed;
    private float remainingOxygen;

    private bool isInWater = false;

    private void Awake()
    {
        remainingOxygen = maxOxygen;
    }

    private void Update()
    {
        if (isInWater)
        {
            remainingOxygen -= Time.deltaTime;
            if (remainingOxygen <= 0)
            {
                Debug.Log("You died!");
            }
        }
        else if (remainingOxygen < maxOxygen)
        {
            remainingOxygen += oxygenRegenerationSpeed * Time.deltaTime;
            if (remainingOxygen > maxOxygen)
            {
                remainingOxygen = maxOxygen;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Water"))
        {
            isInWater = true;
            Debug.Log("Entered Water");
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Water"))
        {
            isInWater = false;
            Debug.Log("Exited Water");
        }
    }
}
