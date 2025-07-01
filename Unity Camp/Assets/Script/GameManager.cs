using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int totalItemCount;
    public TMP_Text scoreText;

    void Awake()
    {
        scoreText.text = "0 / " + totalItemCount; // 현재 스테이지의 총 아이템 개수
    }
    public void GetItem(int count)
    {
        scoreText.text = count.ToString() + " / " + totalItemCount.ToString(); // 현재 습득한 총 아이템 개수
    }
}
