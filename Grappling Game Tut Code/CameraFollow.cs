using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject target;
    private float _smoothTime = 0.3f;
    private Vector3 _vel = Vector3.zero;

    private void Update()
    {
        Vector3 targetPos = target.transform.TransformPoint(new Vector3(0, 0, -10));
        targetPos = new Vector3(targetPos.x,targetPos.y,-10);
        transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref _vel, _smoothTime * Time.deltaTime);
    }
}
