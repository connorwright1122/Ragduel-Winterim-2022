using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public Text scoreText;
    
    public void Setup(int score)
    {
        gameObject.SetActive(true);
        scoreText.text = "KILLED " + score.ToString() + " ENEMIES";
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void RestartButton()
    {
        SceneManager.LoadScene("Base Scene");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            //gameOverScreen.RestartButton();
            Debug.Log("R");
            //SceneManager.LoadScene("Base Scene");
            SceneManager.LoadScene("Arena");
        }
    }
}
