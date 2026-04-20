using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ClickSound_Lucy : MonoBehaviour
{
    public AudioSource mySound;
     public void PlayOnClickSound() {
        mySound.Play();
    }
}