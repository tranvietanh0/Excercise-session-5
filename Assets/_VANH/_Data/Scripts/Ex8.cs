using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex8 : MonoBehaviour
{
    [SerializeField] private Transform aPoint, bPoint;
    private float moveSpeed = 100f;
    private bool isMovingToTarget = true;

    private void Start()
    {
        transform.position = aPoint.position;
        StartCoroutine(Moving());
    }

    

    IEnumerator Moving()
    {
        while (true)
        {
            Vector3 targetPos = new Vector3();
            if (isMovingToTarget)
            {
                targetPos = bPoint.position;
                transform.position = Vector3.MoveTowards(transform.position, targetPos, moveSpeed * Time.deltaTime);
                yield return new WaitForSeconds(1f);
            }
            else
            {
                targetPos = aPoint.position;
                transform.position = Vector3.MoveTowards(transform.position, targetPos, moveSpeed * Time.deltaTime);
                yield return new WaitForSeconds(1f);
            }

            if (Vector3.Distance(transform.position, targetPos) < 0.1f)
            {
                isMovingToTarget = !isMovingToTarget;
            }

        }
    }
}
