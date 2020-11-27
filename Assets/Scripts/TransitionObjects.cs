﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionObjects : MonoBehaviour
{

    public OrderList election1list;
    public ScoreTracker scoretracker;
    public StatesManager statesmanager;
    


    void Start()
    {
        election1list.IsImposter = new bool[8] {false, false, false, false, true, false, false, true};
        statesmanager.state = 0;
        election1list.activeVoter = 0;
        scoretracker.CurrentLevel = 0;
        for (int i = 0; i < scoretracker.Score.Length; i++)
        {
            scoretracker.Score[i] = 0;
            
        }

    }

}
