using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateFirework : MonoBehaviour
{
    public GameObject[] firework;

    void Start()
    {
        InvokeRepeating("CreateBlue", 0f, 0.5f);
        InvokeRepeating("CreateGreen", 0.2f, 0.5f);
        InvokeRepeating("CreateRed", 0.1f, 0.5f);
        InvokeRepeating("CreateYellow", 0.3f, 0.5f);
    }
    
    void CreateBlue()
    {
        Instantiate(firework[0], new Vector3(Random.Range(-2.5f, 2.5f), Random.Range(-3f, 3f), 0), Quaternion.identity);
    }

    void CreateGreen()
    {
        Instantiate(firework[1], new Vector3(Random.Range(-2.5f, 2.5f), Random.Range(-3f, 3f), 0), Quaternion.identity);
    }

    void CreateRed()
    {
        Instantiate(firework[2], new Vector3(Random.Range(-2.5f, 2.5f), Random.Range(-3f, 3f), 0), Quaternion.identity);
    }

    void CreateYellow()
    {
        Instantiate(firework[3], new Vector3(Random.Range(-2.5f, 2.5f), Random.Range(-3f, 3f), 0), Quaternion.identity);
    }
}
