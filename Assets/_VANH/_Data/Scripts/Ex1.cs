using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex1 : MonoBehaviour
{
    
    void Start()
    {
        Check();
    }

    private void Check()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log('A');
        }

        if (Input.GetKey(KeyCode.B))
        {
            Debug.Log('B');
        }

        if (Input.GetKey(KeyCode.C))
        {
            Debug.Log('C');
        }
    }
    
}
