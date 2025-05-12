using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public static class DIManager
{
    private static DiContainer _container;

    // ����� ��� ��������� ����������
    public static void SetContainer(DiContainer container)
    {
        _container = container;
    }

    // ����� ��� ��������� ����������
    public static DiContainer GetContainer()
    {
        if (_container == null)
        {
            throw new System.Exception("DiContainer is not initialized.");
        }
        return _container;
    }
}
