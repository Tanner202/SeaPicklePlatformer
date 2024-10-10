using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oxygen : MonoBehaviour
{
    [SerializeField] private float maxOxygen;
    [SerializeField] private float oxygenRegenerationSpeed;
    private float remainingOxygen;

    private WaterChecker waterChecker;

    private void Awake()
    {
        remainingOxygen = maxOxygen;
        waterChecker = GetComponent<WaterChecker>();
    }

    private void Update()
    {
        if (waterChecker.IsInWater())
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

    public float GetRemainingOxygen()
    {
        return remainingOxygen;
    }

    public float GetMaxOxygen()
    {
        return maxOxygen;
    }
}
