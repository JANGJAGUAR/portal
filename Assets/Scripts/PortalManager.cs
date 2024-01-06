using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class PortalManager : MonoBehaviour
{
    // public Transform land1, land2;
    // public Transform playerRoot;
    // public Transform playerCam;
    // public Transform portalCam;
    //
    // public Transform blueScreen;
    // public Transform yellowScreen;

    // public float test;
    
    // Portal Init
    public GameObject bluePortalPrefeb;
    public GameObject yellowPortalPrefeb;

    public GameObject bluePortal;
    public GameObject yellowPortal;
    
    public GameObject blueScreenPrefeb;
    public GameObject yellowScreenPrefeb;

    public GameObject blueScreen;
    public GameObject yellowScreen;
    void Start()
    {
        bluePortal = Instantiate(bluePortalPrefeb, new Vector3(0f, -10f, 0f),Quaternion.identity);
        yellowPortal = Instantiate(yellowPortalPrefeb, new Vector3(0f, -10f, 0f),Quaternion.identity);
        blueScreen = Instantiate(blueScreenPrefeb, new Vector3(0f, -10f, 0f),Quaternion.identity);
        yellowScreen = Instantiate(yellowScreenPrefeb, new Vector3(0f, -10f, 0f),Quaternion.identity);
    }

    void Update()
    {
        // Vector3 playerOffset = playerCam.position - yellowScreen.position;
        // Vector3 zeroOffset = new Vector3(1f ,0f, 0f); // 000 -90,0, 0
        //yellowPortal.transform.Find("CameraPedestal").gameObject.transform.rotation = Quaternion.Euler(test ,0f, 0f);
        //1. pedes 안쪽의 카메라 y rotat가 어떻게든 하늘을 바라보게 만들기
        //y는 중력만 신경
        // Debug.Log(playerOffset);
    }
}
