using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex3 : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Transform[] Points;
    private int indexPoint = 0;

    private void Update()
    {
        MoveOverThreePoints();
    }

    private void MoveOverThreePoints()
    {
        Vector3 targetPos = Points[indexPoint].position;
        transform.position = Vector3.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
        if (Vector3.Distance(transform.position, targetPos) < 0.1f)
        {
            if (indexPoint == Points.Length - 1)
            {
                indexPoint = 0;
            }

            else
            {
                ++indexPoint;
            }
        }
    }
}
