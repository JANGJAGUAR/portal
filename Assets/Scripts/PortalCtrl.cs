using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalCtrl : MonoBehaviour
{
    public bool isPortalOn;

    public float openDelay;
    private float openTime;
    private Vector3 originalScale;
    void Start()
    {
        isPortalOn = false;
        originalScale = transform.localScale;
        openTime = openDelay;
    }

    void Update()
    {
        openTime += Time.deltaTime;
        
        if (isPortalOn)
        {
            openTime = 0f;
            isPortalOn = false;
        }

        if (openTime < openDelay) transform.localScale = originalScale * (openTime / openDelay);
        else transform.localScale = originalScale;
    }
}
