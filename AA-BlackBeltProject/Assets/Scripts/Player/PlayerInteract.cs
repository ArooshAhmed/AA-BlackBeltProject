using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    public float InteractingDis;
    static public GameObject PersonTalking;

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
                    if (hit.collider.gameObject.GetComponent<Talking>() != null)
                    {
                        PersonTalking = hit.collider.gameObject;
                    }
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            RaycastHit hit;
            if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, InteractingDis))
            {
                if (hit.collider.gameObject.GetComponent<iInteractable>() != null)
                {
       
                    if (hit.collider.gameObject.GetComponent<Talking>() != null)
                    {
                        PersonTalking = hit.collider.gameObject;
                        //hit.collider.gameObject.GetComponent<Talking>().Give();
                    }
                }
            }
        }
    }

}
