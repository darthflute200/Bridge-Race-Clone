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
            if (PlayerColor.CurrentColor == global::Colors.Color.Blue)
            {


                if (PlayerBricks.Brick.Count > 0 & StairColor.CurrentColor != global::Colors.Color.Blue)
                {
                    StairColor.CurrentColor = global::Colors.Color.Blue;
                    GameObject LastGameObject = PlayerBricks.Brick[PlayerBricks.Brick.Count - 1];
                    PlayerBricks.Brick.Remove(PlayerBricks.Brick[PlayerBricks.Brick.Count - 1]);
                    Destroy(LastGameObject);
                    meshRenderer.material.color = StairColors[0];
                    meshRenderer.enabled = true;
                }


            }



        }

    }
}
