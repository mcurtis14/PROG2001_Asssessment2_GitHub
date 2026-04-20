using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager_Lucy : MonoBehaviour
{
    public void ToggleAllSound()
    {
        AudioListener.pause = !AudioListener.pause;
    }  
}
