using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Frog : MonoBehaviour
{
    public Rigidbody2D rb;
    public Image[] lives;
    public int livesRemaing;


    void Update()
    {
        //Frog movement with arrowkeys
        if (Input.GetKeyDown(KeyCode.RightArrow))
            rb.MovePosition(rb.position + Vector2.right);
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
            rb.MovePosition(rb.position + Vector2.left);
        else if (Input.GetKeyDown(KeyCode.UpArrow))
            rb.MovePosition(rb.position + Vector2.up);
        else if (Input.GetKeyDown(KeyCode.DownArrow))
            rb.MovePosition(rb.position + Vector2.down);

        //Frog movement with the wasd keys
        if (Input.GetKeyDown(KeyCode.D))
            rb.MovePosition(rb.position + Vector2.right);
        else if (Input.GetKeyDown(KeyCode.A))
            rb.MovePosition(rb.position + Vector2.left);
        else if (Input.GetKeyDown(KeyCode.W))
            rb.MovePosition(rb.position + Vector2.up);
        else if (Input.GetKeyDown(KeyCode.S))
            rb.MovePosition(rb.position + Vector2.down);


    }

    void OnTriggerEnter2D (Collider2D col)
    {
        if(col.tag == "Car")
        {
            
            //Currentlives--; //deducted live upon impact
            Score.CurrentScore = 0;
            LoseLife();
            
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);

            
        }

    }
    public void LoseLife()
    {
        livesRemaing--;

        lives[livesRemaing].enabled = false;

        if (livesRemaing == 0)
        {
            Score.finalScore = Score.CurrentScore;
            SceneManager.LoadScene("GameOver");
        }
    }
}
