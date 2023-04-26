using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideButtons : MonoBehaviour
{
    public GameObject Menu;
    // Start is called before the first frame update
    void Start()
    {
        Menu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Mouse()
    {
        Menu.SetActive(true);
        Debug.Log("IT WORKSSS");
    }
}
