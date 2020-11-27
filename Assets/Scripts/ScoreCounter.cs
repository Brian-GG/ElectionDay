using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{

    public OrderList order;
    public StatesManager states;
    public ScoreTracker Tracker;
    public int Score = 0;
    public Button Accept, Reject;
    


    // Start is called before the first frame update
    void Start()
    {
        Accept.onClick.AddListener(Accept_Voter);
        Reject.onClick.AddListener(Reject_Voter);
        Tracker.flag = true;
    }

    void Accept_Voter()
    {
        if (order.IsImposter[order.activeVoter] == true && states.state == 1)
        {
            Score += 100;
            Debug.Log("You accepted an imposter!");
        }
        else if (order.IsImposter[order.activeVoter] == false && states.state == 1)
        {
            Debug.Log("You did your job!");
        }
    }

    void Reject_Voter()
    {
        if (order.IsImposter[order.activeVoter] == true && states.state == 1)
        { 
            Debug.Log("You caught an imposter!");
        }
        else if (order.IsImposter[order.activeVoter] == false && states.state == 1)
        {
            Score++;
            Debug.Log("That was an innocent!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(order.activeVoter == order.IsImposter.Length - 1 && (states.state == 3 || states.state == 2) && Tracker.flag == true)
        {
            Tracker.Score[Tracker.CurrentLevel] = Score;
            if (Tracker.CurrentLevel != 3)
            {
                Tracker.nextLevel();
            }
            Tracker.flag = false;
        }
    }
}
