using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToWin : MonoBehaviour
{
    public GameObject background;

    void OnTriggerExit2D(Collider2D other) {
        if (background.transform.position.y >= 43.76) {
            SceneManager.LoadScene("WinScene");
        }
    }
}
