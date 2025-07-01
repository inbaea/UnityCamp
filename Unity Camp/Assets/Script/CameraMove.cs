using System.Collections;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Transform playerTransform; // �÷��̾��� ��ġ
    private Vector3 offset; // �÷��̾�� ī�޶� �� �Ÿ�
    private bool offsetReady = false; // offset�� �����Ǿ����� ����

    private void Start()
    {
        StartCoroutine(InitOffsetAfterDelay());
    }

    private IEnumerator InitOffsetAfterDelay()
    {
        yield return new WaitForSeconds(1f); // 1�� ���
        offset = transform.position - playerTransform.position; // offset ����
        offsetReady = true;
    }

    void LateUpdate()
    {
        if (offsetReady)
        {
            transform.position = playerTransform.position + offset; // ī�޶� ��ġ ������Ʈ
        }
    }
}
