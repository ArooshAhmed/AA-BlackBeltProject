using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    static public Inventory inventory;
    //public GameObject[] slots;
    public List<GameObject> slots = new List<GameObject>();
    int slotNumber;

    void Start()
    {
        inventory = this;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            slotNumber = 0;
        }
        
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            slotNumber = 1;
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            slotNumber = 2;
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            slotNumber = 3;
        }

        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            slotNumber = 4;
        }
    }
    public void AddInventory(GameObject item)
    {
        slots.Add(item);
    }

    public void RemoveInventory(GameObject item)
    {
        slots.Remove(item);
    }
}
