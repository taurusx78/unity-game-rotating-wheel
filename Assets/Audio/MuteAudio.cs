using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MuteAudio : MonoBehaviour
{
    public GameObject soundBtn;
    public Sprite soundOn;
    public Sprite soundOff;

    void Start()
    {
        if (AudioListener.volume == 1) {
            soundBtn.GetComponent<Image>().sprite = soundOn;
        } else {
            soundBtn.GetComponent<Image>().sprite = soundOff;
        }
    }

    public void MuteBtnDown()
    {
        if (AudioListener.volume == 1) {
            AudioListener.volume = 0;
            soundBtn.GetComponent<Image>().sprite = soundOff;
        } else {
            AudioListener.volume = 1;
            soundBtn.GetComponent<Image>().sprite = soundOn;
        }
    }
}
