using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public static class DIManager
{
    private static DiContainer _container;

    // Метод для установки контейнера
    public static void SetContainer(DiContainer container)
    {
        _container = container;
    }

    // Метод для получения контейнера
    public static DiContainer GetContainer()
    {
        if (_container == null)
        {
            throw new System.Exception("DiContainer is not initialized.");
        }
        return _container;
    }
}
