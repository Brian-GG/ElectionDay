using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "States Manager")]

public class StatesManager : ScriptableObject
{
    public int state = 0;
    
    public void UpdateState(int n)
    {
        state = n;
    }

    public int GetState()
    {
        return state;
    }

}
