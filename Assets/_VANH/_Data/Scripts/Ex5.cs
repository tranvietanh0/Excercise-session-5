using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex5 : MonoBehaviour
{
    [SerializeField] private Transform aPoint, bPoint;
    private float travelTime = 2f;
    private float timeSpent;
    private bool isMovingToTarget;

    private void Start()
    {
        timeSpent = 0;
        transform.position = aPoint.position;
    }

    private void Update()
    {
        MovingOverTwoPoints();
    }

    private void MovingOverTwoPoints()
    {
        timeSpent += Time.deltaTime;
        float percent = timeSpent / travelTime;
        Vector3 targetPos = new Vector3();
        if (isMovingToTarget)
        {
            targetPos = bPoint.position;
            transform.position = Vector3.Lerp(aPoint.position, targetPos, percent);
        }
        else
        {
            targetPos = aPoint.position;
            transform.position = Vector3.Lerp(bPoint.position, targetPos, percent);
        }

        if (percent >= 1)
        {
            timeSpent = 0;
            isMovingToTarget = !isMovingToTarget;
        }
    }
}
