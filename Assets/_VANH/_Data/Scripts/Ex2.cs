using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex2 : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Transform APoint, BPoint;
    private bool isMovingToB = true;
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        MovingOverTwoPoints();
    }
    // cach1
    // private void MovingOverTwoPoints()
    // {
    //     Vector3 targetPos = new Vector3();
    //     if (isMovingToB)
    //     {
    //         targetPos = BPoint.position;
    //     }
    //     else
    //     {
    //         targetPos = APoint.position;
    //     }
    //
    //     transform.position = Vector3.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
    //     if (Vector3.Distance(transform.position, targetPos) <= 0.1f)
    //     {
    //         isMovingToB = !isMovingToB;
    //     }
    // }
    
    //cach2
    // private void MovingOverTwoPoints()
    // {
    //     Vector3 targetPos = new Vector3();
    //     if (isMovingToB)
    //     {
    //         targetPos = BPoint.position;
    //     }
    //     else
    //     {
    //         targetPos = APoint.position;
    //     }
    //     transform.Translate((targetPos - transform.position).normalize * speed * Time.deltaTime);
    //     if (Vector3.Distance(transform.position, targetPos) <= 0.1f)
    //     {
    //         isMovingToB = !isMovingToB;
    //     }
    // }
    //cach3
    private void MovingOverTwoPoints()
    {
        Vector3 targetPos = new Vector3();
        if (isMovingToB)
        {
            targetPos = BPoint.position;
        }
        else
        {
            targetPos = APoint.position;
        }

        rb.velocity = (targetPos - transform.position).normalized * speed;
        
        if (Vector3.Distance(transform.position, targetPos) <= 0.1f)
        {
            isMovingToB = !isMovingToB;
        }
    }
}
