using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IDController : MonoBehaviour
{

    public OrderList order;
    public StatesManager states;
    public GameObject[] IDOrder;

    // Update is called once per frame
    void Update()
    {
        if (states.state == 1)
        {
            
           ActivateID();
            
        }
        else
        {
            IDOrder[order.activeVoter].SetActive(false);
        }
    }

    public void ActivateID()
    {
        IDOrder[order.activeVoter].SetActive(true);
    }
}
