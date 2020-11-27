using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoverScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private float duration = 1.0f;

    // Update is called once per frame
    void Update()
    {
        Color textureColor = GetComponent<Renderer>().material.color;
        textureColor.a = Mathf.PingPong(Time.time, duration) / duration;
        GetComponent<Renderer>().material.color = textureColor;
    }
}
