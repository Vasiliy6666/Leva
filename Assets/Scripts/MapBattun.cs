using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class MapBattun : MonoBehaviour
{
    public GameObject mapContainer;


    private void Start()
    {
        mapContainer.SetActive(false);
    }


    public void MapController()
    {
        
        mapContainer.SetActive(!mapContainer.activeSelf);
    }
    

   
    

}
