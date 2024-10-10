using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OxygenBar : MonoBehaviour
{
    [SerializeField] Oxygen oxygen;

    private Image fillImage;

    private void Awake()
    {
        fillImage = GetComponent<Image>();
    }

    private void Update()
    {
        fillImage.fillAmount = oxygen.GetRemainingOxygen()/oxygen.GetMaxOxygen();
    }
}
