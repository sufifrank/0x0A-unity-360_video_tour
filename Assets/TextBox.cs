using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBox : MonoBehaviour
{
    public Canvas textCanvas;

    public void Popup()
    {
        textCanvas.gameObject.SetActive(!textCanvas.gameObject.activeInHierarchy);
    }
}
