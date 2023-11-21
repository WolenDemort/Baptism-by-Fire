using UnityEngine;
using UnityEngine.UI;

public class AutoSpasing : MonoBehaviour
{
    public float desiredSpacing = 10f; // �������� ���������� ����� ���������

    // ���������� � ��������� Unity � ��� ��������� �������� ��������
    void OnValidate()
    {
        UpdateSpacing();
    }

    // ���������� � ��������� Unity � ��� ��������� �������� ��������
    void OnTransformChildrenChanged()
    {
        UpdateSpacing();
    }

    // ��������� ���������� ����� ��������� � ����������� �� �� ����������
    void UpdateSpacing()
    {
        HorizontalLayoutGroup layoutGroup = GetComponent<HorizontalLayoutGroup>();

        if (layoutGroup != null)
        {
            int childCount = transform.childCount;

            // ������� ��������� ��������� � ������������� ��� � �������� �������� ��� �������� ��������
            GameObject container = new GameObject("Container");
            container.transform.SetParent(transform);

            // ������������� LayoutElement ��� ����������, ����� �� �������� �������
            LayoutElement containerLayoutElement = container.AddComponent<LayoutElement>();
            containerLayoutElement.ignoreLayout = true;

            // ������������� ������� ���������� ���, ����� ��� ������� ������ � ������ ��������� ����������
            float containerWidth = (desiredSpacing + layoutGroup.preferredWidth) * childCount - desiredSpacing;
            containerLayoutElement.preferredWidth = containerWidth;

            // ������������� ���������� � ���������� HorizontalLayoutGroup
            layoutGroup.spacing = desiredSpacing;

            // ���������� �������� ������� � ���������
            for (int i = 0; i < childCount; i++)
            {
                transform.GetChild(i).SetParent(container.transform, false);
            }
        }
    }
}
