using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Score Tracker")]

public class ScoreTracker : ScriptableObject
{
    public int[] Score;

    public int CurrentLevel = 0;

    public bool flag = false;

    public void nextLevel()
    {

        CurrentLevel++;

    }


}
