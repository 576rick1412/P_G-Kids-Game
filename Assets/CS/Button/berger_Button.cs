using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class berger_Button : MonoBehaviour
{
    public GameObject UI_Window;
    public bool on_off = false;

    void Start()
    {
        on_off = false;
        UI_Window.SetActive(false);
    }

    public void MakeWindow()
    {
        if (on_off == false)
        {
            on_off = true;
            UI_Window.SetActive(true);
            Debug.Log("Ã¢ ÄÑÁü");
            return;
        }
        else
        {
            on_off = false;
            UI_Window.SetActive(false);
            Debug.Log("Ã¢ ²¨Áü");
            return;
        }
    }
}
