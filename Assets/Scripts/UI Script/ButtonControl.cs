using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonControle : MonoBehaviour
{
    public void ButtonScensStart(string sceneName)//����� ��� ������� ����� ����� �� �����
    {
        SceneManager.LoadScene(sceneName);//������ ����� �� �� �����
    }

    public void ButtonExitGame()//����� ��� �������� ���� � �����
    {
        Application.Quit();
    }

    
}
