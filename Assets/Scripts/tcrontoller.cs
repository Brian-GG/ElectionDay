using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class tcrontoller : MonoBehaviour
{

    public Image black;
    public Animator anim;
    public int count;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        count += 1;


        if (count == 400)
        {
            Debug.Log("ifstatement");
            StartCoroutine(Fading());

        }
        Debug.Log(black.color.a);
    }

    IEnumerator Fading()
    {
        Debug.Log("routine");
        anim.SetBool("fade", true);

        yield return new WaitUntil(() => black.color.a == 1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);



    }



}
