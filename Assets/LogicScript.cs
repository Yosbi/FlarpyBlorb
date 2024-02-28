using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public AudioSource pingSFX;
    public AudioSource wahwahSFX;
    public PipeMoveScript pipeMoveScript;
    public bool wahwahPlayed = false;

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd) {
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
        pingSFX.Play();

    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        gameOverScreen.SetActive(false);

        if (wahwahSFX.isPlaying){
            wahwahSFX.Stop();
        }
    }

    public void gameOver()
    {
        if (!wahwahSFX.isPlaying && !wahwahPlayed){
            wahwahSFX.Play();
            wahwahPlayed = true;
        }
            

        gameOverScreen.SetActive(true);
    }

}
