using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinalScore : MonoBehaviour
{

    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = Score.finalScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
