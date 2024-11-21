using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;

    private void LateUpdate()
    {

        transform.position = Vector3.Lerp(transform.position, target.position, Time.deltaTime);
    }

}