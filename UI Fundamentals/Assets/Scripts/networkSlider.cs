using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class networkSlider : MonoBehaviour
{
    public Text onText;
    public Text offText;

    public void setText (float sliderValue)
    {
        if(sliderValue < 0.5f)
        {
            onText.color = Color.white;
            offText.color = Color.red;
        } else
        {
            onText.color = Color.green;
            offText.color = Color.white;
        }
    }
}
