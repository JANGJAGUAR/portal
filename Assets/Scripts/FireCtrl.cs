using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class FireCtrl : MonoBehaviour
{
    public Transform firePos;

    public GameObject portalManager;
    
    

    private RaycastHit hit;
    void Start()
    {
        // bluePortal = Instantiate(bluePortalPrefeb, new Vector3(0f, -10f, 0f),Quaternion.identity);
        // yellowPortal = Instantiate(yellowPortalPrefeb, new Vector3(0f, -10f, 0f),Quaternion.identity);
        // bluePortal.SetActive(true);
        // yellowPortal.SetActive(true);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1) )
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        
            Debug.DrawRay(Camera.main.transform.position, ray.direction * 100.0f, Color.red, 1.0f);
        
            if (Physics.Raycast(ray, out hit, 100.0f, 1<<7))
            {
                if (Input.GetMouseButtonDown(0)) LeftFire(hit);
                if (Input.GetMouseButtonDown(1)) RightFire(hit);
                Debug.Log($"Raycast Camera  {hit.transform.name}");
            }
        }
        
    }

    void LeftFire(RaycastHit hitPoint)
    {
        portalManager.GetComponent<PortalManager>().blueHit = hitPoint; 
        portalManager.GetComponent<PortalManager>().bluePortal.transform.position = hitPoint.point;
        portalManager.GetComponent<PortalManager>().bluePortal.transform.rotation = hitPoint.transform.rotation;
        portalManager.GetComponent<PortalManager>().bluePortal.GetComponent<PortalCtrl>().isPortalOn = true;

        portalManager.GetComponent<PortalManager>().yellowScreen.transform.position = hitPoint.point+hitPoint.normal*0.05f;
        portalManager.GetComponent<PortalManager>().yellowScreen.transform.rotation = hitPoint.transform.rotation;
        portalManager.GetComponent<PortalManager>().yellowScreen.GetComponent<PortalCtrl>().isPortalOn = true;
        
    }
    void RightFire(RaycastHit hitPoint)
    {
        portalManager.GetComponent<PortalManager>().yellowHit = hitPoint; 
        portalManager.GetComponent<PortalManager>().yellowPortal.transform.position = hitPoint.point;
        portalManager.GetComponent<PortalManager>().yellowPortal.transform.rotation = hitPoint.transform.rotation;
        portalManager.GetComponent<PortalManager>().yellowPortal.GetComponent<PortalCtrl>().isPortalOn = true;

        portalManager.GetComponent<PortalManager>().blueScreen.transform.position = hitPoint.point+hitPoint.normal*0.05f;
        portalManager.GetComponent<PortalManager>().blueScreen.transform.rotation = hitPoint.transform.rotation;
        portalManager.GetComponent<PortalManager>().blueScreen.GetComponent<PortalCtrl>().isPortalOn = true;
        
    }
}
