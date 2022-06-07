using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger : MonoBehaviour
{



    void Start()
    {
        var obj = FindObjectsOfType<GameManger>();
        if (obj.Length == 1) 
        {
            DontDestroyOnLoad(gameObject); 
        } 
        else
        { 
            Destroy(gameObject); 
        }
    }
}