using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex9 : MonoBehaviour
{
    [SerializeField] private Transform aPoint, bPoint;
    private float timeTravel = 3f;
    private float spentTime;
    private bool isMovingToTarget = true;
    private void Start()
    {
        transform.position = aPoint.position;
        spentTime = 0;
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        spentTime += Time.deltaTime;
        float percent = spentTime / timeTravel;
        if (isMovingToTarget)
        {
            Vector3 targetPos = bPoint.position;
            transform.position = Vector3.Lerp(transform.position, targetPos, percent);
        }
        else
        {
            Vector3 targetPos = aPoint.position;
            transform.position = Vector3.Lerp(transform.position, targetPos, percent);
        }

        if (percent >= 1)
        {
            spentTime = 0;
            isMovingToTarget = !isMovingToTarget;
        }
    }
}
