using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorDetector : MonoBehaviour
{
    private Colors ColorDetectorColor;
    private void Start()
    {
        ColorDetectorColor = GetComponent<Colors>();
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Transform PlayerTransform = other.GetComponent<Transform>();
            Debug.Log("ColorDetector");
            GameManager PlayerMove = other.GetComponent<GameManager>();
            Bricks PlayerBricks = other.GetComponent<Bricks>();
            Colors PlayerColor = other.GetComponent<Colors>();
            if (PlayerBricks.Brick.Count > 0)
            {
                ColorDetectorColor.CurrentColor = PlayerColor.CurrentColor;
            }
            if (ColorDetectorColor.CurrentColor == PlayerColor.CurrentColor & PlayerMove.Direction == Vector3.forward)
            {
                PlayerTransform.position = new Vector3(PlayerTransform.position.x, PlayerTransform.position.y + 1f, PlayerTransform.position.z);
            }

        }
    }

}
