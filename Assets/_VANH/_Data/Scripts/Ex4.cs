using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class Ex4 : MonoBehaviour
{
    [SerializeField] private Transform p1, p2, p3;
    private float travelTime = 2f; // thoi gian di chuyen
    private float spentTime;
    private bool isMovingToTarget = true;

    private void Start()
    {
        spentTime = 0;
        transform.position = p1.position;
    }

    private void Update()
    {
        CurveMoveByLerp();
    }

    private void CurveMoveByLerp()
    {
        spentTime += Time.deltaTime;
        float percent = spentTime / travelTime;
        
        Vector3 p12 = new Vector3();
        Vector3 p23 = new Vector3();
        
        if (isMovingToTarget)
        {
            Vector3 targetPos = p3.position;
            p12 = Vector3.Lerp(p1.position, p2.position, percent);
            p23 = Vector3.Lerp(p2.position, targetPos, percent);
        }
        else
        {
            Vector3 targetPos = p1.position;
            p12 = Vector3.Lerp(p3.position, p2.position, percent);
            p23 = Vector3.Lerp(p2.position, targetPos, percent);
        }

        transform.position = Vector3.Lerp(p12, p23, percent);

        if (percent >= 1)
        {
            spentTime = 0;
            isMovingToTarget = !isMovingToTarget;
        }
    }
}
