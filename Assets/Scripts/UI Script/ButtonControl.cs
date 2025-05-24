using SimplePrefs;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonControl : MonoBehaviour
{
   
    public void ButtonScensStart(string sceneName)//метод для запуска любой сцены на выбор
    {
        SceneManager.LoadScene(sceneName);//запуск сцены по ее имени
    }

    public void ButtonExitGame()//метод для закрытия игры в целом
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
