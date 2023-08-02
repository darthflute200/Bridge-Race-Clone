using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] Transform PlayerTransform;
    void Update()
    {
        transform.position = new Vector3(PlayerTransform.position.x, PlayerTransform.position.y + 5f, PlayerTransform.position.z - 4f);
    }
}
