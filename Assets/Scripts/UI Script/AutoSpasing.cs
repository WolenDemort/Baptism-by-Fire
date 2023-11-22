using UnityEngine;
using UnityEngine.UI;

public class AutoSpasing : MonoBehaviour
{
    
    public float maxParentWidth ; // Максимальная ширина родительского объекта

    // Вызывается в редакторе Unity и при изменении дочерних объектов
    //void OnValidate()
    //{
    //    UpdateSpacing();

    //    RectTransform rectTransform = GetComponent<RectTransform>();
    //    maxParentWidth = rectTransform.rect.width;
        
    //}

    // Вызывается в редакторе Unity и при изменении дочерних объектов
    void OnTransformChildrenChanged()
    {
        UpdateSpacing();
    }

    // Обновляет расстояние между объектами в зависимости от их количества
    void UpdateSpacing()
    {
        int childCount = transform.childCount;

        if (childCount > 1)
        {
            HorizontalLayoutGroup layoutGroup = GetComponent<HorizontalLayoutGroup>();

            if (layoutGroup != null)
            {
                // Получаем ширину первого дочернего объекта (предполагается, что все объекты имеют одинаковую ширину)
                RectTransform firstChild = transform.GetChild(0).GetComponent<RectTransform>();
                float childWidth = firstChild.rect.width;

                // Рассчитываем доступную ширину для дочерних объектов
                float availableWidth = maxParentWidth;

                // Рассчитываем новое значение spacing (может быть отрицательным)
                float newSpacing = (availableWidth - childWidth) / (childCount);

                // Устанавливаем новое значение spacing (отрицательное)
                layoutGroup.spacing = newSpacing;
            }
        }
    }
}


    
   

   