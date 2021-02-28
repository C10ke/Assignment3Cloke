using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Score : MonoBehaviour
{
    public static int CurrentScore = 0;
    public static int finalScore;

    public Text scoreText;


    void Start()
    {
        scoreText.text = CurrentScore.ToString();
        
    }

    private void Update()
    {
        if (CurrentScore >= 500)
        {
            finalScore = CurrentScore;
            SceneManager.LoadScene("GameOver");
            CurrentScore = 0;
        }
        
    }

    public void CompleteLevel()
    {
       
    }
}
