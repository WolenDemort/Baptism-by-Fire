using SimplePrefs;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonControl : MonoBehaviour
{
   
    public void ButtonScensStart(string sceneName)//����� ��� ������� ����� ����� �� �����
    {
        SceneManager.LoadScene(sceneName);//������ ����� �� �� �����
    }

    public void ButtonExitGame()//����� ��� �������� ���� � �����
    {
        Application.Quit();
    }

    public void ScrollReturnOnHorizontal(GameObject gameObject)
    {
        ScrollRect _scroll = gameObject.GetComponent<ScrollRect>();

        _scroll.horizontalNormalizedPosition = 0;

    }

    public void ScrollReturnOnVertical(GameObject gameObject)
    {
        ScrollRect _scroll = gameObject.GetComponent<ScrollRect>();

        _scroll.verticalNormalizedPosition = 1;

    }

   


}
