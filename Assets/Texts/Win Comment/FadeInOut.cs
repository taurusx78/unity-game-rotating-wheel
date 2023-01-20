using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeInOut : MonoBehaviour
{
    SpriteRenderer sr;
    public GameObject[] comments;
    int n;
    int len;

    void Start()
    {
        n = 0;
        len = comments.Length;
        sr = comments[n].GetComponent<SpriteRenderer>();
        StartCoroutine("FadeIn");
    }

    IEnumerator FadeIn() {
        Color color = sr.material.color;

        for (int i = 0; i < 10; i++) {
            color.a = i / 10.0f;
            sr.material.color = color;
            yield return new WaitForSeconds(0.1f);
        }

        if (n < len - 1) {
            yield return new WaitForSeconds(3.0f);
            StartCoroutine("FadeOut");
        }
    }

    IEnumerator FadeOut() {
        Color color = sr.material.color;        

        for (int i = 10; i >= 0; i--) {
            color.a = i / 10.0f;
            sr.material.color = color;
            yield return new WaitForSeconds(0.1f);
        }

        yield return new WaitForSeconds(0.5f);
        n++;
        if (n < len) {
            if (n == 3) {
                yield return new WaitForSeconds(2f);
            }
            comments[n].SetActive(true);
            sr = comments[n].GetComponent<SpriteRenderer>();
            StartCoroutine("FadeIn");
        }
    }
}
