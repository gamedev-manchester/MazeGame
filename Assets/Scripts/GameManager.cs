using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //by storing the instance of this class we dont need to make public 
    //variables whenever we want to access this class
    public static GameManager Instance; 
    
    public GameObject ball;
    public Transform startPoint;
    public Transform endPoint;

    private void Awake()
    {
        Instance = this;
        StartLevel();
    }

    public void StartLevel()
    {
        ball.transform.position = startPoint.position;
    }

    public void EndLevel()
    {
        StartLevel();
    }
}
