using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Knight : MonoBehaviour
{
    private float speed = 2.0f;
    //Animation
    private bool Right = false;
    private bool Left = false;
    private bool Up = false;
    private bool Down = false;
    private Animator animator;
    //Array for jewels
    public GameObject[] gameObjects;
    //Audio
    private AudioSource jewel;
    private AudioSource damage;

    void Start()
    {
        //Get Animator
        animator = GetComponent<Animator>();
        //Get Jewel Audio
        jewel = GetComponent<AudioSource>();
    }

    void Update(){}

    private void FixedUpdate()
    {
        Movement();
        Animation();
    }

    //Movement
    private void Movement()
    {
        //Right
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        //Left
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        //Up
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }
        //Down
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
        }
    }
    
    //Animations
    private void Animation()
    {
        //Right
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            animator.SetBool("Left", false);
            animator.SetBool("Up", false);
            animator.SetBool("Down", false);
            animator.SetBool("Right", true);
            Down = false;
            Up = false;
            Left = false;
            Right = true;
        }
        //Left
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            animator.SetBool("Left", true);
            animator.SetBool("Up", false);
            animator.SetBool("Down", false);
            animator.SetBool("Right", false);
            Down = false;
            Up = false;
            Left = true;
            Right = false;
        }
        //Up
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            animator.SetBool("Left", false);
            animator.SetBool("Up", true);
            animator.SetBool("Down", false);
            animator.SetBool("Right", false);
            Down = false;
            Up = true;
            Left = false;
            Right = false;
        }
        //Down
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            animator.SetBool("Left", false);
            animator.SetBool("Up", false);
            animator.SetBool("Down", true);
            animator.SetBool("Right", false);
            Down = true;
            Up = false;
            Left = false;
            Right = false;
        }
    }

    //Destroys Jewel
    private void RemovalJewel()
    {
        gameObjects = GameObject.FindGameObjectsWithTag("Jewel");
        for (var i = 0; i < gameObjects.Length; i++)
        {
            Destroy(gameObjects[i]);
        }
    }
    //Destroys CannonBall
    private void RemovalCannonBall()
    {
        gameObjects = GameObject.FindGameObjectsWithTag("CannonBall");
        for (var i = 0; i < gameObjects.Length; i++)
        {
            Destroy(gameObjects[i]);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        //Hits CannonBall
        if (other.gameObject.tag == "CannonBall")
        {
            Controller.lives -= 1;
            Destroy(other.gameObject);
            if (Controller.lives == 0)
            {
                RemovalJewel();
                RemovalCannonBall();
                SceneManager.LoadScene(0);
            }
        }
        //Hits Jewel
        if (other.gameObject.tag == "Jewel")
        {
            Controller.score += 50;
            jewel.Play();
            Destroy(other.gameObject);
        }
    }
}
