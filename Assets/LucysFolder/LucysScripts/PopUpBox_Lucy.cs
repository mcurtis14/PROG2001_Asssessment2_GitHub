using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpBox_Lucy : MonoBehaviour
{
    public GameObject popupBox;

    public void TogglePopup()
    {
        popupBox.SetActive(!popupBox.activeSelf);
    }
}
