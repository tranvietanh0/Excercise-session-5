
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class Ex7 : MonoBehaviour
{
    [SerializeField] private Transform[] points;
    private bool isMovingToTarget = true;
    private int indexPoint = 0;
    private float moveSpeed = 3f;
    private void Update()
    {
        RandomMoveOverThreePoints();
    }

    private void RandomMoveOverThreePoints()
    {
        Vector3 targetPos = points[indexPoint].position;
        transform.position = Vector3.MoveTowards(transform.position, targetPos, moveSpeed * Time.deltaTime);
        if (Vector3.Distance(transform.position, targetPos) < 0.1f)
        {
            int val = indexPoint;
            while (val == indexPoint)
            {
                indexPoint = Random.Range(0, points.Length);
            }
        }
    }
}
