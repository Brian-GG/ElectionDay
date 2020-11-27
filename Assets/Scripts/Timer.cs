using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    Text txt;
    string story;
    public int maxTime;
    public float time = 0f;
    

    // Start is called before the first frame update
    void Start()
    {
        txt = GetComponent<Text>();
        story = txt.text;
        txt.text = "";

    }


    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (time < maxTime)
        {
            txt.text = "Timer: " + (int)(maxTime - time);
        }
        if (time > maxTime)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }
}
