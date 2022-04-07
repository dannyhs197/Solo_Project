using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //Moves to level one
    public void playGame()
    {
        SceneManager.LoadScene(1);
    }
}
