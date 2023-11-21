using UnityEngine;
using UnityEngine.UI;

public class AutoSpasing : MonoBehaviour
{
    public float desiredSpacing = 10f; // Желаемое расстояние между объектами

    // Вызывается в редакторе Unity и при изменении дочерних объектов
    void OnValidate()
    {
        UpdateSpacing();
    }

    // Вызывается в редакторе Unity и при изменении дочерних объектов
    void OnTransformChildrenChanged()
    {
        UpdateSpacing();
    }

    // Обновляет расстояние между объектами в зависимости от их количества
    void UpdateSpacing()
    {
        HorizontalLayoutGroup layoutGroup = GetComponent<HorizontalLayoutGroup>();

        if (layoutGroup != null)
        {
            int childCount = transform.childCount;

            // Создаем временный контейнер и устанавливаем его в качестве родителя для дочерних объектов
            GameObject container = new GameObject("Container");
            container.transform.SetParent(transform);

            // Устанавливаем LayoutElement для контейнера, чтобы он управлял шириной
            LayoutElement containerLayoutElement = container.AddComponent<LayoutElement>();
            containerLayoutElement.ignoreLayout = true;

            // Устанавливаем размеры контейнера так, чтобы все объекты влезли с учетом желаемого расстояния
            float containerWidth = (desiredSpacing + layoutGroup.preferredWidth) * childCount - desiredSpacing;
            containerLayoutElement.preferredWidth = containerWidth;

            // Устанавливаем расстояние в компоненте HorizontalLayoutGroup
            layoutGroup.spacing = desiredSpacing;

            // Перемещаем дочерние объекты в контейнер
            for (int i = 0; i < childCount; i++)
            {
                transform.GetChild(i).SetParent(container.transform, false);
            }
        }
    }
}
