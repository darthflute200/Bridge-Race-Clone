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
            StartingPosition BrickPosition = other.GetComponent<StartingPosition>();
            Transform BrickLocation = other.GetComponent<Transform>();
            Colors Brickcolor = other.GetComponent<Colors>();
            Colors PlayerColor = GetComponent<Colors>();
            if (Brickcolor.CurrentColor == PlayerColor.CurrentColor)
            { 
                other.transform.SetParent(gameObject.transform);
                other.transform.localScale = new Vector3(0.8116774f, 0.1291429f, 0.21195f);
    
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
                StartCoroutine(BrickSpawn());
                StopCoroutine(BrickSpawn());

            }
            IEnumerator BrickSpawn()
            {
                yield return new WaitForSeconds(5f);
                Instantiate(other.gameObject, BrickPosition.StartingPoint, Quaternion.identity);

            }
         
        }
            

        
    }


}
