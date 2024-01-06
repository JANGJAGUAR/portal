using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleCtrl : MonoBehaviour
{
    public float speed;
    void Start()
    {
        
    }

    void Update()
    {
        var x = Input.GetAxis("Horizontal");
        var z = Input.GetAxis("Vertical");
        transform.Translate( new Vector3(x, 0, z)*speed*Time.deltaTime);
    }
}
