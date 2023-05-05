using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextButton : MonoBehaviour
{
    public void Next()
    {
        PlayerInteract.PersonTalking.GetComponent<Talking>().interact();
    }
}
