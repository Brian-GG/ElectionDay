using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionObjects2 : MonoBehaviour
{

    public OrderList election1list;
    public ScoreTracker scoretracker;
    public StatesManager statesmanager;

    void Start()
    {
        election1list.IsImposter = new bool[8] { false, false, false, false, true, false, true, false };
        statesmanager.state = 0;
        election1list.activeVoter = 0;
    }

}