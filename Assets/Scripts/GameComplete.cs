using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameComplete : MonoBehaviour
{
    //Moves to main menu
    public void playGame()
    {
        SceneManager.LoadScene(0);
    }
}
