using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Frog : MonoBehaviour
{
    public float turnSpeed;
    public int health;
    int score;

    public TMP_Text healthDisplay;
    public TMP_Text scoreDisplay;

    void Start()
    {
        
        healthDisplay.text = "Health: " + health;
        scoreDisplay.text = "Score: " + score;
    }

    void Update()
    {
        transform.Rotate(
            Vector3.forward *
            turnSpeed *
            Input.GetAxisRaw("Horizontal") *
            Time.deltaTime
        );
    }

    public void TakeDamage()
    {
        health--;
        healthDisplay.text = "Health: " + health;

        if (health <= 0)
        {
            GameOverManager.Instance.GameOver();
        }
    

}

public void AddScore()
    {
        score++;
        scoreDisplay.text = "Score: " + score;
    }
}
