using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight : MonoBehaviour
{
    public bool Right = false;
    public bool Left = false;
    public bool Up = false;
    public bool Down = false;
    public float speed = 2.0f;
    public Animator animator;
    public Camera cam;
    void Start()
    {
        animator = GetComponent<Animator>();
        cam = Camera.main;
    }

    void Update(){}

    private void FixedUpdate()
    {
        MoveCharacter();
    }

    void MoveCharacter()
    {
        if(Input.GetKey(KeyCode.D))
        {
            animator.SetBool("Left", false);
            animator.SetBool("Up", false);
            animator.SetBool("Down", false);
            animator.SetBool("Right", true);
            Down = false;
            Up = false;
            Left = false;
            Right = true;
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
        if(Input.GetKey(KeyCode.A))
        {
            animator.SetBool("Left", true);
            animator.SetBool("Up", false);
            animator.SetBool("Down", false);
            animator.SetBool("Right", false);
            Down = false;
            Up = false;
            Left = true;
            Right = false;
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        if(Input.GetKey(KeyCode.W))
        {
            animator.SetBool("Left", false);
            animator.SetBool("Up", true);
            animator.SetBool("Down", false);
            animator.SetBool("Right", false);
            Down = false;
            Up = true;
            Left = false;
            Right = false;
            transform.Translate(Vector3.up * Time.deltaTime * speed);
        }
        if(Input.GetKey(KeyCode.S))
        {
            animator.SetBool("Left", false);
            animator.SetBool("Up", false);
            animator.SetBool("Down", true);
            animator.SetBool("Right", false);
            Down = true;
            Up = false;
            Left = false;
            Right = false;
            transform.Translate(Vector3.down * Time.deltaTime * speed);
        }
    }
}
