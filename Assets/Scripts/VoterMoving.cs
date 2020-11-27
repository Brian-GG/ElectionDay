using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class VoterMoving : MonoBehaviour
{

    Rigidbody2D rb;
    public float Speed = 5.0f;
    public StatesManager state;
    public OrderList order;
    public bool Transition_statesA = false;
    public bool Transition_statesB = false;
    public Button Accept, Reject;

    void Start()
    {
        Accept.onClick.AddListener(Accept_Voter);
        Reject.onClick.AddListener(Reject_Voter);
        
    }

    void Accept_Voter()
    {
        Transition_statesA = true;
        Debug.Log("You have clicked the accept button!");
    }

    void Reject_Voter()
    {
        Transition_statesB = true;
        Debug.Log("You have clicked the reject button!");
    }

    void Update()
    {
        rb = GetComponent<Rigidbody2D>();
        Vector3 position = this.transform.position;
        if (state.state == 0 && position.x <= 0)
        {
            rb.velocity = new Vector2(Speed, rb.velocity.y);
        }
        else if ((position.x >= 0 && state.state == 0))
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
            state.state = 1;
        }
        else if (position.x >= 0 && state.state == 1 && Transition_statesA == true)
        {
            rb.velocity = new Vector2(Speed, rb.velocity.y);
            state.state = 2;
        }
        else if (position.x >= 16 && state.state == 2)
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
            state.state = 0;
            if (order.activeVoter == order.IsImposter.Length - 1)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            this.gameObject.SetActive(false);
        }
        else if (position.x >= 0 && state.state == 1 && Transition_statesB == true)
        {
            rb.velocity = new Vector2(-Speed, rb.velocity.y);
            state.state = 3;
        }
        else if (position.x <= -14 && state.state == 3)
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
            state.state = 0;
            if(order.activeVoter == order.IsImposter.Length - 1)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            this.gameObject.SetActive(false);
        }
    }
}
