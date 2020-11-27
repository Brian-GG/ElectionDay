using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Fraudaccpet : MonoBehaviour
{

    public ScoreTracker score;
    Text txt;
    string story;
    public int totalScore;
    public bool HorO;
   
    // Start is called before the first frame update
    void Start()
    {
        txt = GetComponent<Text>();
        story = txt.text;
        txt.text = "";
        for(int i = 0; i < score.Score.Length; i++)
        {
            totalScore += score.Score[i];
        }
        if (HorO) {

            txt.text = "Fraud Voters Accepted: " + (int)(totalScore/100);
        }
        else
        {
            txt.text = "Innocents Rejected: " + (int)(totalScore % 100);
        }
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
