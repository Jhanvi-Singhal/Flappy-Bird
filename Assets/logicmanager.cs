using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class logicmanager : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject Over;

   public void addScore(){
        playerScore++;
        scoreText.text = playerScore.ToString();
    }
    public void Reset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver()
    {

        Over.SetActive(true);


    }
}
