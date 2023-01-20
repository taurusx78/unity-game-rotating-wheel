using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonEvent : MonoBehaviour
{
    public void LeftBtnDown() {
        PlayerMove.leftMove = true;
    }

    public void LeftBtnUp() {
        PlayerMove.leftMove = false;
    }

    public void RightBtnDown() {
        PlayerMove.rightMove = true;
    }

    public void RightBtnUp() {
        PlayerMove.rightMove = false;
    }
}
