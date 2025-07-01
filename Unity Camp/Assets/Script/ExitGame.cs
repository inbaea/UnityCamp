using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGame : MonoBehaviour
{
    public void Exit()
    {
#if UNITY_EDITOR // 유니티 에디터에서 실행되는 종료 
            UnityEditor.EditorApplication.isPlaying = false;
#else // 그 외 환경에서 실행되는 종료 코드
        Application.Quit();
#endif
    }
}
