using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScenes : MonoBehaviour
{
    private int level;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (level > 3)
        {
            level = 0;
        }
        SceneManager.LoadScene(5);
        level ++;
    }
}
