using UnityEngine;
using UnityEngine.UI;

[RequireComponent (typeof(Image))]
public class ButtonMask : MonoBehaviour
{
    [Range(0f, 1f)]
    [SerializeField] float _alphalevel = 1f;
    private Image imageButton;

    void Start()
    {
        imageButton = gameObject.GetComponent<Image>();
        imageButton.alphaHitTestMinimumThreshold = _alphalevel;
    }
}
