using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool Up = false;
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
        if (Input.GetKey(KeyCode.UpArrow))
        {
            if(Up == true)
            {
                Direction = Vector3.up;
                PlayerAnimator.SetBool("IsRunning", true);
            }
            else
            {
                Direction = Vector3.forward;
                PlayerAnimator.SetBool("IsRunning", true);
            }
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            Direction = Vector3.right;
            PlayerAnimator.SetBool("IsRunning", true);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            Direction = Vector3.left;
            PlayerAnimator.SetBool("IsRunning", true);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            Direction = Vector3.back;
            PlayerAnimator.SetBool("IsRunning", true);
        }
        else
        {
            Direction = Vector3.zero;
            PlayerAnimator.SetBool("IsRunning", true);
        }

        transform.position += Direction * speed * Time.deltaTime;

        if (Direction != Vector3.zero)
        {
            Quaternion targetRotation = Quaternion.LookRotation(Direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * 10f);
        }
        if ( Direction == Vector3.zero)
        {
            PlayerAnimator.SetBool("IsRunning", false);

        }
    }

}
