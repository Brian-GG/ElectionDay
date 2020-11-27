using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoterController : MonoBehaviour
{

    public OrderList order;
    public StatesManager states;
    public GameObject[] VoterOrder;


    // Start is called before the first frame update
    void Start()
    {
        ActivateVoter();
    }

    // Update is called once per frame
    void Update()
    {
        if(VoterOrder[order.activeVoter].activeSelf == false)
        {
            if (order.activeVoter < VoterOrder.Length - 1)
            {
                order.nextVoter();
                VoterOrder[order.activeVoter].SetActive(true);
            }
            
        }

    }

    public void ActivateVoter()
    {
        VoterOrder[order.activeVoter].SetActive(true);
    }
}
