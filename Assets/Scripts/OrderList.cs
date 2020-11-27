using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Voter List")]

public class OrderList : ScriptableObject
{
    public GameObject[] VoterOrder;
    public bool[] IsImposter;
    public int activeVoter = 0;
    
    public void nextVoter()
    {
        activeVoter++;
    }

    public int GetActiveVoter()
    {
        return activeVoter;
    }

    public void SetActiveVoter(int n)
    {
        activeVoter = n;
    }

    public bool CheckImposter()
    {
        return IsImposter[activeVoter];
    }

    public void ActivateVoter()
    {
        VoterOrder[activeVoter].SetActive(true);
    }

}
