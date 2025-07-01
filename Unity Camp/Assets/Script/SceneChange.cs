using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems; // 이벤트 시스템 사용

public class SceneChange : MonoBehaviour, IPointerClickHandler
{
    // UI화면에서 클릭 시 호출되는 함수
    public void OnPointerClick(PointerEventData eventData)
    {
        SceneManager.LoadScene("SampleScene");
    }
}
