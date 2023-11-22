using UnityEngine;
using UnityEngine.UI;

public class AutoSpasing : MonoBehaviour
{
    
    public float maxParentWidth ; // ������������ ������ ������������� �������

    // ���������� � ��������� Unity � ��� ��������� �������� ��������
    //void OnValidate()
    //{
    //    UpdateSpacing();

    //    RectTransform rectTransform = GetComponent<RectTransform>();
    //    maxParentWidth = rectTransform.rect.width;
        
    //}

    // ���������� � ��������� Unity � ��� ��������� �������� ��������
    void OnTransformChildrenChanged()
    {
        UpdateSpacing();
    }

    // ��������� ���������� ����� ��������� � ����������� �� �� ����������
    void UpdateSpacing()
    {
        int childCount = transform.childCount;

        if (childCount > 1)
        {
            HorizontalLayoutGroup layoutGroup = GetComponent<HorizontalLayoutGroup>();

            if (layoutGroup != null)
            {
                // �������� ������ ������� ��������� ������� (��������������, ��� ��� ������� ����� ���������� ������)
                RectTransform firstChild = transform.GetChild(0).GetComponent<RectTransform>();
                float childWidth = firstChild.rect.width;

                // ������������ ��������� ������ ��� �������� ��������
                float availableWidth = maxParentWidth;

                // ������������ ����� �������� spacing (����� ���� �������������)
                float newSpacing = (availableWidth - childWidth) / (childCount);

                // ������������� ����� �������� spacing (�������������)
                layoutGroup.spacing = newSpacing;
            }
        }
    }
}


    
   

   