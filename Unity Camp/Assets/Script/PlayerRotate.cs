using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotate : MonoBehaviour
{
    public float rotSpeed = 100f; // ȸ�� �ӵ� ����

    void Update()
    {
        transform.Rotate(new Vector3(0, 0, rotSpeed * Time.deltaTime));
        // ȸ�� �Լ�, Time.deltaTime ���
    }
}
