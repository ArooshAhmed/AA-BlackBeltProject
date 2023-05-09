using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    static public Inventory inventory;
    //public GameObject[] slots;
    public List<GameObject> slots = new List<GameObject>();
    public List<Image> InventoryImages = new List<Image>();
    public int slotNumber;
    public GameObject b1;
    public GameObject b2;
    public GameObject b3;
    public GameObject b4;
    public GameObject b5;

    void Start()
    {
        inventory = this;
        GameObject[] bordersArr = {b1, b2, b3, b4, b5};
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            slotNumber = 0;
            b1.SetActive(true);
            b2.SetActive(false);
            b3.SetActive(false);
            b4.SetActive(false);
            b5.SetActive(false);
        }
        
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            slotNumber = 1;
            b2.SetActive(true);
            b1.SetActive(false);
            b3.SetActive(false);
            b4.SetActive(false);
            b5.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            slotNumber = 2;
            b3.SetActive(true);
            b2.SetActive(false);
            b1.SetActive(false);
            b4.SetActive(false);
            b5.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            slotNumber = 3;
            b4.SetActive(true);
            b2.SetActive(false);
            b3.SetActive(false);
            b1.SetActive(false);
            b5.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            slotNumber = 4;
            b5.SetActive(true);
            b2.SetActive(false);
            b3.SetActive(false);
            b4.SetActive(false);
            b1.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            RemoveInventory(slotNumber);
        }
    }
    public void AddInventory(GameObject item , Sprite IS)
    {

        slots.Add(item);
        InventoryImages[slots.IndexOf(item)].sprite = IS;

    }

    public void RemoveInventory(int item)
    {
        slots.RemoveAt(item);
        for (int i = 0; i < InventoryImages.Count; i++)
        {
            if (i < slots.Count)
            {
                InventoryImages[i].sprite = slots[i].GetComponent<Object>().ImageSprite;
            }
            else
            {
                InventoryImages[i].sprite = null;
            }
        }
    }
}
