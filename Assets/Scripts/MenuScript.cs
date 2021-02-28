using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MenuScript : MonoBehaviour
{
    public static int NumOfLives = 0;
    public Dropdown LivesDropDown;
    public void PlayGame()
    {
        SceneManager.LoadScene("Main");
    }

    public void ShowCredits()
    {
        SceneManager.LoadScene("GameOver");
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void PickLives()
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch(LivesDropDown.value)
        {
            default:
                NumOfLives = 3;
                break;
            case 1:
                NumOfLives = 1;
                break;
            case 2:
                NumOfLives = 2;
                break;

        }
    }

    

}
