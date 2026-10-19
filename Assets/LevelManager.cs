using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LevelManager : MonoBehaviour
{
     public GameObject CurrentCheckpoint; 

    
    void Start()
    {
        CurrentCheckpoint = null;
    }

    void Update()
    {
    }

    public void RespawnPlayer()
    {
        FindObjectOfType<behaviors>().transform.position = CurrentCheckpoint.transform.position;
        
    }
}