using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static float score;
    public static float currentScore;
    public static float highScore;

    public GameObject score300;
    public GameObject leftKey;
    public GameObject rightKey;

    void Start()
    {
        score300.SetActive(false);
        score = 0;
        highScore = PlayerPrefs.GetFloat("highScore");
    }

    void Update()
    {
        if (score < 300) {
            score += Time.deltaTime;
            GetComponent<Text>().text = ((int)score).ToString() + " / 300";
        } else {
            GetComponent<Text>().text = "";
            score300.SetActive(true);
            leftKey.SetActive(false);
            rightKey.SetActive(false);
            PlayerPrefs.SetFloat("highScore", 300);
        }
    }
}
