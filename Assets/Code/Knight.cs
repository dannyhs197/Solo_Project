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
    public GUIStyle myStyle;
    public GameObject[] gameObjects;
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

    void RemovalJewel()
    {
        gameObjects = GameObject.FindGameObjectsWithTag("Jewel");
        for (var i = 0; i < gameObjects.Length; i++)
        {
            Destroy(gameObjects[i]);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Jewel")
        {
            Controller.score += 50;
            Destroy(other.gameObject);
        }
    }


    void OnGUI()
    {
        GUI.Box(new Rect(10, 10, 100, 30), "Time: " + Time.time, myStyle);
        GUI.Box(new Rect(10, 40, 100, 30), "Score: " + Controller.score);
        GUI.Box(new Rect(10, 70, 100, 30), "Lives: " + Controller.lives);
    }
}
