using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGame : MonoBehaviour
{
    public void Exit()
    {
#if UNITY_EDITOR // ����Ƽ �����Ϳ��� ����Ǵ� ���� 
            UnityEditor.EditorApplication.isPlaying = false;
#else // �� �� ȯ�濡�� ����Ǵ� ���� �ڵ�
        Application.Quit();
#endif
    }
}
