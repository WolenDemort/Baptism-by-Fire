using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent (typeof(Image))]
public class ButtonMask : MonoBehaviour
{
    [Range(0f, 1f)]
    [SerializeField] float _aplhalevel = 1f;
    private Image imageButton;

    void Start()
    {
        imageButton = gameObject.GetComponent<Image>();
        imageButton.alphaHitTestMinimumThreshold = _aplhalevel;
    }
}
