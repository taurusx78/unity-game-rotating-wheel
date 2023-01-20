using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    public float timer = 65;

    void Start()
    {
        Destroy(this.gameObject, timer);
    }
}
