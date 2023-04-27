using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitButton : MonoBehaviour
{
    public GameObject Screen;
    
    public void HideScreen()
    {
        Screen.SetActive(false);
    }
}
