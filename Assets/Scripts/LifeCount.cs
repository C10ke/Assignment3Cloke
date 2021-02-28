using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LifeCount : MonoBehaviour
{
    public Image[] lives;
    public int livesRemaing;

    public void LoseLife()
    {
        livesRemaing--;

        lives[livesRemaing].enabled = false;

        if(livesRemaing==0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }





   void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
