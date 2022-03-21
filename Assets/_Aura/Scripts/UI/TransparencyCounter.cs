using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Component allows button components overlaid atop of images to ignore clicks over
/// transparent parts of the image
/// </summary>
public class TransparencyCounter : MonoBehaviour
{
    //a slider value to determine the transparency
    [Header("Transparency value")]
    [Range(0, 1)]
    [SerializeField] float _transparencyValue = 0f;

    [Header("Image component to affect")]
    [SerializeField] Image _imageToAffect;

    private void Start()
    {
        //specifies the minimum threshold a pixel must have in order to respond to clicks.
        _imageToAffect.alphaHitTestMinimumThreshold = _transparencyValue;
    }

    public void OnlyVisiblePartClicked()
    {
        Debug.Log("We have a hit!");
    }
}
