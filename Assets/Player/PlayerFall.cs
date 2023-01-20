using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerFall : MonoBehaviour
{
    AudioSource[] audioArray;

    void Start() {
        audioArray = GetComponents<AudioSource>();
    }

    void OnCollisionEnter2D(Collision2D collision) {
        if (Score.score < 300) {
            if (collision.gameObject.name == "Bottom Wall" || collision.gameObject.name == "Left Wall" || collision.gameObject.name == "Right Wall") {
                audioArray[0].Play();
                Count.count--;

                if (Count.count < 0) {
                    Score.currentScore = Score.score;

                    if (Score.currentScore > Score.highScore) {
                        Score.highScore = Score.currentScore;
                        PlayerPrefs.SetFloat("highScore", Score.highScore);
                    }

                    SceneManager.LoadScene("GameOverScene");
                } else {
                    this.gameObject.transform.position = new Vector3(0, 0, 0);
                }
            }
        }
    }
}
