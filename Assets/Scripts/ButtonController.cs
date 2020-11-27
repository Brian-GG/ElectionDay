using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public Button Accept, Reject;
    public StatesManager states;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(states.state == 1)
        {
            Accept.interactable = true;
            Reject.interactable = true;
        }
        else
        {
            Accept.interactable = false;
            Reject.interactable = false;
        }
        
    }
}
