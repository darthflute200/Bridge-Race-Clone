using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingPosition : MonoBehaviour
{
    
    public Vector3 StartingPoint;
    private void Start()
    {
        StartingPoint = transform.position;
    }
}
