using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{
    public float speed;

    public static bool leftMove;  // 왼쪽 버튼 눌렸는지
    public static bool rightMove;  // 오른쪽 버튼 눌렸는지

    float vx = 0;
    bool leftFlag = false;  // 왼쪽 방향인지
    bool groundFlag = false;  // 바닥에 닿았는지
    string nowState = "Stop";
    Rigidbody2D rb;

    public GameObject background;
    AudioSource[] audioArray;

    void Start() {
        rb = GetComponent<Rigidbody2D>();
        audioArray = GetComponents<AudioSource>();
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;  // 충돌 시 회전하지 않도록 설정
        leftMove = false;
        rightMove = false;
    }

    void Update() {
        vx = 0;
        if (this.transform.position.x > -1.6 && this.transform.position.x < 1.6 && this.transform.position.y > -1.5 && this.transform.position.y < 0.5) {
            rb.rotation = this.transform.position.x * 37f;
        }
        nowState = "Stop";

        if (Score.score < 300) {
            if (leftMove) {  // leftMove
                vx = -speed;
                leftFlag = true;
                nowState = "Run";
            } else if (rightMove) {  // Input.GetKey("right")
                vx = speed;
                leftFlag = false;
                nowState = "Run";
            }
        }

        if (groundFlag == false) {
            rb.rotation = 0;
            nowState = "Jump";
        }

        if (background.transform.position.y >= 43.76) {
            vx = 5;
            leftFlag = false;
            nowState = "Run";
        }
    }

    void FixedUpdate() {
        rb.velocity = new Vector2(vx, rb.velocity.y);
        this.GetComponent<SpriteRenderer>().flipX = leftFlag;
        this.GetComponent<Animator>().Play(nowState);
    }

    // Player가 바닥에 착지했을 때
    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.name == "Wheel" || other.gameObject.name == "Ground Bottom") {
            audioArray[1].Play();
        }
    }

    // Player가 바닥에 닿아 있을 때
    void OnTriggerStay2D(Collider2D other) {
        groundFlag = true;
    }

    // Player가 바닥 닿지 않았을 때
    void OnTriggerExit2D(Collider2D other) {
        audioArray[1].Stop();
        groundFlag = false;
    }
}
