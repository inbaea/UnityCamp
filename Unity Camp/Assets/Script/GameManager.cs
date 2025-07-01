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
        scoreText.text = "0 / " + totalItemCount; // ���� ���������� �� ������ ����
    }
    public void GetItem(int count)
    {
        scoreText.text = count.ToString() + " / " + totalItemCount.ToString(); // ���� ������ �� ������ ����
    }
}
