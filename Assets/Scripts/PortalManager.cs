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
    public GameObject player;
    //
    // public Transform blueScreen;
    // public Transform yellowScreen;

    public RaycastHit blueHit, yellowHit;

    public float test;
    
    // Portal Init
    public GameObject bluePortalPrefeb;
    public GameObject yellowPortalPrefeb;

    public GameObject bluePortal;
    public GameObject yellowPortal;
    
    public GameObject blueScreenPrefeb;
    public GameObject yellowScreenPrefeb;

    public GameObject blueScreen;
    public GameObject yellowScreen;

    // public RenderTexture blueRenderTex;
    // public RenderTexture yellowRenderTex;
    
    void Start()
    {
        // blueRenderTex.width = Screen.width;
        // blueRenderTex.height = Screen.height;
        // yellowRenderTex.width = Screen.width;
        // yellowRenderTex.height = Screen.height;
        
        bluePortal = Instantiate(bluePortalPrefeb, new Vector3(0f, -10f, 0f),Quaternion.identity);
        yellowPortal = Instantiate(yellowPortalPrefeb, new Vector3(0f, -10f, 0f),Quaternion.identity);
        blueScreen = Instantiate(blueScreenPrefeb, new Vector3(0f, -10f, 0f),Quaternion.identity);
        yellowScreen = Instantiate(yellowScreenPrefeb, new Vector3(0f, -10f, 0f),Quaternion.identity);

        
        
    }

    void Update()
    {
        // // Vector3 yellowScreenLookdir = yellowScreen.transform.position - playerCam.position;
        // // int xChangeYellow = 1, yChangeYellow = 1, zChangeYellow = 1;
        // // if (yellowHit.normal.x != 0) xChangeYellow = -1;
        // // if (yellowHit.normal.y != 0) yChangeYellow = -1;
        // // if (yellowHit.normal.z != 0) zChangeYellow = -1;
        // // Vector3 normalYellowDir = new Vector3(yellowScreenLookdir.x*xChangeYellow, yellowScreenLookdir.y*yChangeYellow, yellowScreenLookdir.z*zChangeYellow).normalized;
        // // yellowPortal.transform.Find("CameraPedestal").gameObject.transform.rotation = Quaternion.LookRotation(normalYellowDir);
        // // Debug.DrawRay(yellowPortal.transform.position,normalYellowDir*20f, Color.yellow);
        //
        // Vector3 normalYellowDir = playerCam.position - blueHit.normal + yellowHit.normal;
        // //yellowPortal.transform.Find("CameraPedestal").gameObject.transform.rotation = Quaternion.LookRotation(normalYellowDir);
        //
        // // Vector3 yellowscreenPosition = yellowScreen.transform.position;
        // // Quaternion yellowscreenRotation = yellowScreen.transform.rotation;
        // // Vector3 targetYellowPosition = yellowscreenPosition + yellowscreenRotation * (yellowScreen.transform.position - playerCam.position);
        // Debug.DrawRay(yellowPortal.transform.position ,normalYellowDir, Color.green);
        //
        // // GameObject aCopy = Instantiate(A오브젝트, A오브젝트.transform.position + (B오브젝트.transform.position - A오브젝트.transform.position), A오브젝트.transform.rotation * Quaternion.Inverse(B오브젝트.transform.rotation));
        //
        // // int xChangeYellow = 1, yChangeYellow = 1, zChangeYellow = 1;
        // // if (yellowHit.normal.x != 0) xChangeYellow = -1;
        // // if (yellowHit.normal.y != 0) yChangeYellow = -1;
        // // if (yellowHit.normal.z != 0) zChangeYellow = -1;
        // // Vector3 normalYellowDir = new Vector3(yellowScreenLookdir.x*xChangeYellow, yellowScreenLookdir.y*yChangeYellow, yellowScreenLookdir.z*zChangeYellow).normalized;
        // // yellowPortal.transform.Find("CameraPedestal").gameObject.transform.rotation = Quaternion.LookRotation(normalYellowDir);
        // // Debug.DrawRay(yellowPortal.transform.position,normalYellowDir*20f, Color.yellow);
        //
        // Vector3 blueScreenLookdir = blueScreen.transform.position - playerCam.position;
        // int xChangeBlue = 1, yChangeBlue = 1, zChangeBlue = 1;
        // if (blueHit.normal.x != 0) xChangeBlue = -1;
        // if (blueHit.normal.y != 0) yChangeBlue = -1;
        // if (blueHit.normal.z != 0) zChangeBlue = -1;
        // Vector3 normalBlueDir = new Vector3(blueScreenLookdir.x*xChangeBlue, blueScreenLookdir.y*yChangeBlue, blueScreenLookdir.z*zChangeBlue).normalized;
        // bluePortal.transform.Find("CameraPedestal").gameObject.transform.rotation = Quaternion.LookRotation(normalBlueDir);
        // Debug.DrawRay(bluePortal.transform.position,normalBlueDir*20f, Color.blue);
        
    }

    public void blueTeleport()
    {
        player.transform.position = yellowPortal.transform.position + yellowHit.normal * 1.5f;
    }
    public void yellowTeleport()
    {
        player.transform.position = bluePortal.transform.position + blueHit.normal * 1.5f;
    }
}
// Vector3 targetOffset = yellowPortal.transform.position+yellowHit.normal;//playerLookDir.x + 법선벡터
// Vector3 playerOffset = playerCam.position - yellowScreen.transform.position; // new Vector3(1f ,0f, 0f); // 000 -90,0, 0
// yellowPortal.transform.Find("CameraPedestal").gameObject.transform.rotation = Quaternion.LookRotation(Vector3.up, normalPlayerDir);//-1*
//1. pedes 안쪽의 카메라 y rotat가 어떻게든 하늘을 바라보게 만들기
//y는 중력만 신경
// Debug.Log(playerOffset);
// Debug.Log(yellowHit.normal);
// Debug.DrawRay(playerCam.position,playerLookDir, Color.blue);
// Debug.DrawRay(yellowPortal.transform.position,-1*playerLookDir, Color.yellow); //월드는 이게 맞고 면의 법선벡터가 기준으로 시작
