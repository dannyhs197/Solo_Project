using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    //Cameras
    public GameObject mainCamera;
    public GameObject mapCamera;

    void Start()
    {
        //Sets main camera as active
        mainCamera.SetActive(true);
        mapCamera.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            //On trigger switch to secondary camera
            mainCamera.SetActive(false);
            mapCamera.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            //Exit trigger switch to main camera
            mainCamera.SetActive(true);
            mapCamera.SetActive(false);
        }
    }

}
