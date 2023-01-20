using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Count : MonoBehaviour
{
    public static float count;

    void Start()
    {
        count = 5;
    }

    void Update()
    {
        if (count >= 0) {
            GetComponent<Text>().text = "x " + count.ToString();
        }
    }
}
