using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class gameender : MonoBehaviour
{

    public Button MainMenu;

    // Start is called before the first frame update
    void Start()
    {
        MainMenu.onClick.AddListener(menu);
    }

    void menu()
    {
        SceneManager.LoadScene(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
