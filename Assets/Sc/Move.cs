using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Move : MonoBehaviour
{
    public Transform RC;
    public float R = 5f;
    public float RS = 50f;

    private float angle = 0f;

    void Update()
    {
        angle += RS * Time.deltaTime;

        float radians = angle * Mathf.Deg2Rad;

        float x = RC.position.x + R * Mathf.Cos(radians);
        float z = RC.position.z + R * Mathf.Sin(radians);

        transform.position = new Vector3(x, transform.position.y, z);

        transform.LookAt(RC);
    }
}
