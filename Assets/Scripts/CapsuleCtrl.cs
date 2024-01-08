using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleCtrl : MonoBehaviour
{
    public float speed;
    public float rotateSpeed;
    void Start()
    {
        
    }

    void Update()
    {
        var x = Input.GetAxis("Horizontal");
        var z = Input.GetAxis("Vertical");
        transform.Translate( new Vector3(0, 0, z)*speed*Time.deltaTime);
        transform.Rotate(0,x*rotateSpeed*Time.deltaTime,0);
    }
}
