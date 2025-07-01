using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotate : MonoBehaviour
{
    public float rotSpeed = 100f; // 회전 속도 변수

    void Update()
    {
        transform.Rotate(new Vector3(0, 0, rotSpeed * Time.deltaTime));
        // 회전 함수, Time.deltaTime 사용
    }
}
