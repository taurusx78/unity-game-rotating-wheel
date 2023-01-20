using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelRotate : MonoBehaviour
{
    float angle = 30;  // 각도 범위가 커질수록 어려움
    float timer = 5;  // 시간이 짧을수록 어려움
    float pastAngle;

    void FixedUpdate()
    {
        if (Score.score < 300) {
            this.transform.Rotate(0, 0, angle / 50);
            timer -= Time.deltaTime;
            pastAngle = angle;
            
            if (timer <= 0.0f) {
                if (Score.score < 50) {  // 180도, 1.5초
                    angle = UnityEngine.Random.Range(-180, 180);

                    if (pastAngle * angle < -1) {
                        GetComponent<AudioSource>().Play();
                    }

                    timer = UnityEngine.Random.Range(1.5f, 3f);
                } else if (Score.score >= 50 && Score.score < 100) {  // 180도, 0.5초
                    angle = UnityEngine.Random.Range(-180, 180);

                    if (pastAngle * angle < -1) {
                        GetComponent<AudioSource>().Play();
                    }

                    timer = UnityEngine.Random.Range(0.5f, 2f);
                } else if (Score.score >= 100 && Score.score < 140) {  // 270도, 1.5초
                    angle = UnityEngine.Random.Range(-270, 270);

                    if (pastAngle * angle < -1) {
                        GetComponent<AudioSource>().Play();
                    }

                    timer = UnityEngine.Random.Range(1.5f, 3f);
                } else if (Score.score >= 140 && Score.score < 190) {  // 180도, 1.5초 (in cloud)
                    angle = UnityEngine.Random.Range(-180, 180);

                    if (pastAngle * angle < -1) {
                        GetComponent<AudioSource>().Play();
                    }

                    timer = UnityEngine.Random.Range(1.5f, 3f);
                } else if (Score.score >= 190 && Score.score < 240) {  // 270도, 0.5초
                    angle = UnityEngine.Random.Range(-270, 270);

                    if (pastAngle * angle < -1) {
                        GetComponent<AudioSource>().Play();
                    }

                    timer = UnityEngine.Random.Range(0.5f, 2f);
                } else if (Score.score >= 240 && Score.score < 280) {  // 360도, 1.5초
                    angle = UnityEngine.Random.Range(-360, 360);

                    if (pastAngle * angle < -1) {
                        GetComponent<AudioSource>().Play();
                    }

                    timer = UnityEngine.Random.Range(1.5f, 3f);
                } else {  // 360도, 0.5초
                    angle = UnityEngine.Random.Range(-360, 360);

                    if (pastAngle * angle < -1) {
                        GetComponent<AudioSource>().Play();
                    }

                    timer = UnityEngine.Random.Range(0.5f, 2f);
                }
            }
        } else {
            Vector3 rotation = this.transform.eulerAngles;
            
            if (rotation.z < 29.5) {
                this.transform.Rotate(0, 0, 90 / 50);
            } else if (rotation.z > 30.5) {
                this.transform.Rotate(0, 0, -90 / 50);
            } else {
                this.transform.Rotate(0, 0, 0);
            }
        }
    }
}
