using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrophyMove : MonoBehaviour
{
    float speed = 1;
    int count = 0;

    void FixedUpdate()
    {
        this.transform.Translate(0, speed / 50, 0);
        count++;

        if (count < 25) {
            speed *= 0.9f;
        } else if (count == 25) {
            speed = -0.09437f;
        } else if (count > 25 && count < 50) {
            speed *= 1.1f;
        } else if (count == 50) {
            speed = 1;
            count = 0;
        }
    }
}
