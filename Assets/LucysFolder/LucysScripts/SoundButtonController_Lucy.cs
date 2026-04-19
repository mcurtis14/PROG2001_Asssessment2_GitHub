using System.Collections;
using System.Collections.Generic;
using UnityEngine;using TMPro;

public class SoundButtonController_Lucy : MonoBehaviour
{
    public TextMeshProUGUI buttonText;
    public string textState1 = "Sound: ON";
    public string textState2 = "Sound: OFF";

    private bool isStateOne = true;

    public void ToggleText()
    {
        if(isStateOne)
        {
            buttonText.text = textState2;
        }
        else
        {
          buttonText.text = textState1;  
        }
        //Flip the state for the next click
        isStateOne = !isStateOne;
    }
}
