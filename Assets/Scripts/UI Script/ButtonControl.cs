using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonControle : MonoBehaviour
{
    public void ButtonScensStart(string sceneName)//метод для запуска любой сцены на выбор
    {
        SceneManager.LoadScene(sceneName);//запуск сцены по ее имени
    }

    public void ButtonExitGame()//метод для закрытия игры в целом
    {
        Application.Quit();
    }

    
}
