using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Puzzle : MonoBehaviour
{
    
    public GameObject puzzleContainer;
    public GameObject inventoryContainer;
    public Player player;

    public void ActivePuzzle(bool state)
    {
        puzzleContainer.SetActive(state);
        inventoryContainer.SetActive(!state);
        player.enabled = !player.enabled;
    }

}
