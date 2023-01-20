using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingStar : MonoBehaviour
{
    public float speed = 8;

    void FixedUpdate()
    {
        this.transform.Translate(-speed / 50, -speed / 50, 0);
    }
}
