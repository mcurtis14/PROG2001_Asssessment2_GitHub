using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class ButtonControllerScript : MonoBehaviour
{
    public TextMeshProUGUI buttonText; // Assign the Text component here
    public string textState1 = "Sound: on";
    public string textState2 = "Sound: off";
    
    private bool isStateOne = true;

    public void ToggleText()
    {
        if (isStateOne)
        {
            buttonText.text = textState2;
        }
        else
        {
            buttonText.text = textState1;
        }
        
        // Flip the state for the next click
        isStateOne = !isStateOne;
    }
}
