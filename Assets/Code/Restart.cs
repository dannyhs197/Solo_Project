using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public void mainMenu()
    {
        SceneManager.LoadScene(0);
        Controller.score = 0;
        Controller.lives = 3;

    }
}
