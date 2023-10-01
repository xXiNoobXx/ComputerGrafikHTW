using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform Target;
    public float Distance = 7;
    public float CameraY = 4;

    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z = Target.position.z - Distance;
        newPosition.x = Target.position.x;
        transform.position = newPosition;
    }

    void LateUpdate()
    {
        Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, CameraY, Camera.main.transform.position.z);
    }
}
