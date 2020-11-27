using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InstuctionController : MonoBehaviour
{
    // Start is called before the first frame update

    public Image black;
    public Animator anim;
    public int count;
    



    // Start is called before the first frame update
    void FixedUpdate()
    {

        count += 1;


        if (count == 1200)
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
