using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class PortalCtrl : MonoBehaviour
{
    public bool isPortalOn;

    public float openDelay;
    private float openTime;
    private Vector3 originalScale;
    
    public GameObject potalManager;
    public bool isBlue;
    void Start()
    {
        potalManager = GameObject.Find("PortalManager");
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
    
    private void OnTriggerEnter(Collider other)
    {
        if (isBlue) potalManager.GetComponent<PortalManager>().blueTeleport(); 
        else potalManager.GetComponent<PortalManager>().yellowTeleport();
    }
}
