using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MoveOne : MonoBehaviour
{
    public Rigidbody rig;

    public float F1 = 10;
 
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            rig.AddForce(Vector3.forward * F1, ForceMode.Force);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rig.AddForce(Vector3.left * F1, ForceMode.Force);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rig.AddForce(Vector3.right * F1, ForceMode.Force);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rig.AddForce(Vector3.back * F1, ForceMode.Force);
        }
    }
}
