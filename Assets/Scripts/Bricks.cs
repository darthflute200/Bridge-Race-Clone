using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Bricks : MonoBehaviour
{
    [SerializeField] Transform StartPoint;
    [SerializeField] GameObject Player;
    public List<GameObject> Brick = new List<GameObject>();
    
    
    
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Brick"))
        {

            Colors Brickcolor = other.GetComponent<Colors>();
            Colors PlayerColor = GetComponent<Colors>();
            if (Brickcolor.CurrentColor == PlayerColor.CurrentColor)
            { 
                other.transform.parent = Player.transform;
                if (Brick.Count <= 0) // brick yoksa
                {
                    
                    other.transform.DOLocalMove(StartPoint.transform.localPosition, 2f);
                    
                    
                }
                else //brick varsa
                {
                    GameObject LastGameObject = Brick[Brick.Count - 1];
                    other.transform.DOLocalMove(new Vector3(StartPoint.localPosition.x, LastGameObject.transform.localPosition.y + 0.25f, StartPoint.localPosition.z), 2f);
                }

                Brick.Add(other.gameObject);
                other.transform.rotation = StartPoint.rotation;
                Debug.Log("Triggerd");
            }
        }
            

        
    }


}
