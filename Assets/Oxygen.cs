using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Oxygen : MonoBehaviour
{
    [SerializeField] private float maxOxygen;
    [SerializeField] private float oxygenRegenerationSpeed;
    private float remainingOxygen;
    private death_script death;

    private WaterChecker waterChecker;

    private void Awake()
    {
        death = GetComponent<death_script>();
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
                death.Death();
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
