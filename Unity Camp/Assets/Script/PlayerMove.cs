using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 0.5f; // �ӵ� ����
    public float jumpPower = 5; // ������ ������ ��Ÿ���� ����

    private Rigidbody2D rigid; // ���� ��Ģ�� �����ϴ� Rigidbody �ν��Ͻ�
    private SpriteRenderer spriteRenderer; // �¿� ������ ���� ��������Ʈ ������
    bool isJump; // ���� ���� ���¸� ��Ÿ���� boolean �� -> ���� ��� ���� �� false

    void Awake()
    {
        isJump = false; // ���� ���� ���¸� ����
        rigid = GetComponent<Rigidbody2D>(); // Rigidbody2D ������Ʈ ��������
        spriteRenderer = GetComponent<SpriteRenderer>(); // SpriteRenderer ������Ʈ ��������
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
        float h = Input.GetAxisRaw("Horizontal"); // �¿� ����Ű

        rigid.AddForce(new Vector3(h, 0, 0) * speed, ForceMode2D.Impulse);

        // �ø� ó��
        if (h != 0)
        {
            spriteRenderer.flipX = h < 0;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "Floor") // �����ϴ� ������Ʈ�� �̸��� Floor �϶�
        {
            isJump = false;
        }
    }
}
