using System.Collections;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Transform playerTransform; // 플레이어의 위치
    private Vector3 offset; // 플레이어와 카메라 간 거리
    private bool offsetReady = false; // offset이 설정되었는지 여부

    private void Start()
    {
        StartCoroutine(InitOffsetAfterDelay());
    }

    private IEnumerator InitOffsetAfterDelay()
    {
        yield return new WaitForSeconds(1f); // 1초 대기
        offset = transform.position - playerTransform.position; // offset 설정
        offsetReady = true;
    }

    void LateUpdate()
    {
        if (offsetReady)
        {
            transform.position = playerTransform.position + offset; // 카메라 위치 업데이트
        }
    }
}
