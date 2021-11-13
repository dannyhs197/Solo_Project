using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robot : MonoBehaviour
{
    public bool right = false;
    public bool left = false;
    public float speed = 7.0f;
    public Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        CharacterMove(); 
    }

    void CharacterMove()
    {
        //Right
        if (Input.GetKey(KeyCode.D))
        {
            animator.SetBool("left", false);
            animator.SetBool("right", true);
            left = false;
            right = true;
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
        //Left
        if (Input.GetKey(KeyCode.A))
        {
            animator.SetBool("left", true);
            animator.SetBool("right", false);
            left = true;
            right = false;
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        //Jump
        if (Input.GetKey(KeyCode.Space))
        {
            animator.SetBool("jump", true);
        }
        else
        {
            animator.SetBool("jump", true);
        }
    }
}
