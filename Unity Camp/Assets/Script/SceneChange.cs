using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems; // �̺�Ʈ �ý��� ���

public class SceneChange : MonoBehaviour, IPointerClickHandler
{
    // UIȭ�鿡�� Ŭ�� �� ȣ��Ǵ� �Լ�
    public void OnPointerClick(PointerEventData eventData)
    {
        SceneManager.LoadScene("SampleScene");
    }
}
