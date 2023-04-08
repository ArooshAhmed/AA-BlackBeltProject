using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    static public Inventory inventory;
    //public GameObject[] slots;
    List<GameObject> slots = new List<GameObject>();

    void Start()
    {
        
    }

    void Update()
    {
        
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
