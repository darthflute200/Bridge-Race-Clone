using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stairs : MonoBehaviour
{
    public Colors StairColor;
    public MeshRenderer meshRenderer;
    public List<Color> StairColors;
    private void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        Colors StairColor = GetComponent<Colors>();

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameManager PlayerMove = collision.gameObject.GetComponent<GameManager>();
            Bricks PlayerBricks = collision.gameObject.GetComponent<Bricks>();
            Colors PlayerColor = collision.gameObject.GetComponent<Colors>();
            if (PlayerColor.CurrentColor != StairColor.CurrentColor & PlayerBricks.Brick.Count > 0)
            {
                StairColor.CurrentColor = PlayerColor.CurrentColor;
                GameObject Lastbrick = PlayerBricks.Brick[PlayerBricks.Brick.Count - 1];
                PlayerBricks.Brick.Remove(Lastbrick);
                Destroy(Lastbrick);
                meshRenderer.enabled = true;
                meshRenderer.material.color = StairColors[(int)PlayerColor.CurrentColor];
            }



        }

    }
}
