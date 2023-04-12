using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour, iInteractable
{
    public bool pickedUp;

    public void interact()
    {
        if (pickedUp == false)
        {
            Inventory.inventory.AddInventory(gameObject);
            pickedUp = true;
            gameObject.SetActive(false);
        }

        Debug.Log("Pick Up");
       
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
