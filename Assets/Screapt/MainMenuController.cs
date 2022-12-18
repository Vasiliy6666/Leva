using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public GameObject MainMenuContaiener;
    
    public void StartGame()
    {
        SceneManager.LoadScene(0);
    }
}
