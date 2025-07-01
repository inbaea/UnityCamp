using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public int itemCount;
    public GameManager manager; // GameManager �� ���� �ν��Ͻ�
    public GameObject finish; // Finish�� ���� �ν��Ͻ�

    private void Awake()
    {
        itemCount = 0;
    }
    private void Update()
    {
        if (itemCount == manager.totalItemCount)
        {
            finish.SetActive(true);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Item") // ������ ������Ʈ�� Tag �� Item �̶�� true
        {
            itemCount++;
            other.gameObject.SetActive(false); // ������ �������� ��Ȱ��ȭ
            manager.GetItem(itemCount); // ���� ������ ī��Ʈ�� GameManager ���� ����
        }
        else if (other.tag == "Finish")
        {
#if UNITY_EDITOR // ����Ƽ �����Ϳ��� ����Ǵ� ���� �ڵ�
            UnityEditor.EditorApplication.isPlaying = false;
#else // �׿� ȯ�濡�� ����Ǵ� ���� �ڵ�
            Application.Quit();
#endif
        }
    }
}
