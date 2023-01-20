using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KeepHomeBGM : MonoBehaviour
{
    GameObject homeBGM;
    AudioSource source;

    void Awake()
    {
        homeBGM = GameObject.Find("Home BGM");
        source = homeBGM.GetComponent<AudioSource>();

        if (source.isPlaying) {
            return;
        } else {
            source.Play();
            DontDestroyOnLoad(homeBGM);
        }
    }

    void Update()
    {
        if (SceneManager.GetActiveScene().name == "PlayScene") {
            Destroy(homeBGM);
        }
    }
}