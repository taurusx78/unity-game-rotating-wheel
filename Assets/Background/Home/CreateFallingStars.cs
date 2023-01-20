using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateFallingStars : MonoBehaviour
{
    public GameObject[] fallingStars;

    void Start()
    {
        InvokeRepeating("CreateStars", 1f, 5f);
    }
    
    void CreateStars()
    {
        Instantiate(fallingStars[0], new Vector3(9, 9, 0), Quaternion.identity);
        Instantiate(fallingStars[1], new Vector3(12, 14, 0), Quaternion.identity);
    }
}
