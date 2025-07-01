using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public int itemCount;
    public GameManager manager; // GameManager 에 대한 인스턴스
    public GameObject finish; // Finish에 대한 인스턴스

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
        if (other.tag == "Item") // 접촉한 오브젝트의 Tag 가 Item 이라면 true
        {
            itemCount++;
            other.gameObject.SetActive(false); // 접촉한 아이템의 비활성화
            manager.GetItem(itemCount); // 현재 아이템 카운트를 GameManager 에게 전달
        }
        else if (other.tag == "Finish")
        {
#if UNITY_EDITOR // 유니티 에디터에서 실행되는 종료 코드
            UnityEditor.EditorApplication.isPlaying = false;
#else // 그외 환경에서 실행되는 종료 코드
            Application.Quit();
#endif
        }
    }
}
