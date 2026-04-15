using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickSoundScript : MonoBehaviour
{
    public AudioSource mySound;
     public void PlayClickSound() {
        mySound.Play();
    }
}