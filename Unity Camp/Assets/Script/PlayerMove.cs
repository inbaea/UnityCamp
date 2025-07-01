using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 0.5f; // 속도 변수
    public float jumpPower = 5; // 점프의 강도를 나타내는 변수

    private Rigidbody2D rigid; // 물리 법칙을 적용하는 Rigidbody 인스턴스
    private SpriteRenderer spriteRenderer; // 좌우 반전을 위한 스프라이트 렌더러
    bool isJump; // 현재 점프 상태를 나타내는 boolean 값 -> 땅에 닿고 있을 때 false

    void Awake()
    {
        isJump = false; // 최초 점프 상태를 정의
        rigid = GetComponent<Rigidbody2D>(); // Rigidbody2D 컴포넌트 가져오기
        spriteRenderer = GetComponent<SpriteRenderer>(); // SpriteRenderer 컴포넌트 가져오기
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isJump)
        {
            isJump = true;
            rigid.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
        }
    }

    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal"); // 좌우 방향키

        rigid.AddForce(new Vector3(h, 0, 0) * speed, ForceMode2D.Impulse);

        // 플립 처리
        if (h != 0)
        {
            spriteRenderer.flipX = h < 0;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "Floor") // 접촉하는 오브젝트의 이름이 Floor 일때
        {
            isJump = false;
        }
    }
}
