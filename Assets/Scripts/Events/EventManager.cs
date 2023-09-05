using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public delegate void ClickAction();
    public static event ClickAction OnClicked;

    private void OnGUI()
    {
        if(GUI.Button(new(Screen.width / 2 - 50, 5, 100, 30), "Click"))
        {
            if (OnClicked != null) OnClicked();
        }
    }
}
