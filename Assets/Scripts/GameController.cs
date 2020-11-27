using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    Rigidbody2D rb;
    public float maxSpeed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb = GetComponent<Rigidbody2D>();
        Vector3 position = this.transform.position;
        if (Input.GetKeyDown(KeyCode.C) && position.x <= 0)
        {
            Debug.Log("Start");
            rb.velocity = new Vector2(maxSpeed, rb.velocity.y);

        }
        if (position.x >= 0)
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }
    }


}
