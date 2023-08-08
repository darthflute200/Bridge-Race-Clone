using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{ 
    public Vector3 Direction;
    [SerializeField] float speed;
    Animator PlayerAnimator;
    
    private void Start()
    {
        PlayerAnimator = GetComponent<Animator>();
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {

        Direction = Input.GetAxisRaw("Vertical") * Vector3.forward + Input.GetAxisRaw("Horizontal") * Vector3.right;
        transform.position += Direction * speed * Time.deltaTime;
        PlayerAnimator.SetFloat("Speed", speed);

        if (Direction != Vector3.zero)
        {
            Quaternion targetRotation = Quaternion.LookRotation(Direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * 10f);
        }


        }
    

}
