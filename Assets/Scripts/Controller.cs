using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
{
    //Global Variables
    public static int score = 0;
    public static int lives = 3;

    //GUI
    private void OnGUI()
    {
        GUI.Box(new Rect(10, 10, 100, 30), "Time: " + Time.time);
        GUI.Box(new Rect(10, 40, 100, 30), "Score: " + Controller.score);
        GUI.Box(new Rect(10, 70, 100, 30), "Lives: " + Controller.lives);
    }
}
