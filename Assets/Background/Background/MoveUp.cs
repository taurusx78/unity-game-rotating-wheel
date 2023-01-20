using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUp : MonoBehaviour
{
    public float speed = 0.2842f;

    void FixedUpdate()
    {
        if (this.transform.position.y < 43.76) {
            this.transform.Translate(0, speed / 50, 0);
        }
    }
}
