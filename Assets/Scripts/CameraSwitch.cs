using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public GameObject mainCamera;
    public GameObject mapCamera;

    void Start()
    {
        mainCamera.SetActive(true);
        mapCamera.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            mainCamera.SetActive(false);
            mapCamera.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            mainCamera.SetActive(true);
            mapCamera.SetActive(false);
        }
    }

}
