using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    public float InteractingDis;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            RaycastHit hit;
            if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, InteractingDis))
            {
                if(hit.collider.gameObject.GetComponent<iInteractable>() != null)
                {
                    hit.collider.gameObject.GetComponent<iInteractable>().interact();
                }
            }
        }
    }

}
