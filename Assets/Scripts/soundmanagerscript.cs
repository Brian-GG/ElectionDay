using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundmanagerscript : MonoBehaviour
{

    public static AudioClip button, passport, driver, county;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {

        button = Resources.Load<AudioClip>("Button");
        passport = Resources.Load<AudioClip>("passport");
        driver = Resources.Load<AudioClip>("driverid");
        county = Resources.Load<AudioClip>("county");

        audioSrc = GetComponent<AudioSource>();


    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public static void Playsound(string clip)
    {
        switch (clip)
        {
            case "Button":
                audioSrc.PlayOneShot(button);
                break;

            case "passport":
                audioSrc.PlayOneShot(passport);
                break;

            case "driverid":
                audioSrc.PlayOneShot(driver);
                break;
            case "county":
                audioSrc.PlayOneShot(county);
                break;




        }




    }








}
