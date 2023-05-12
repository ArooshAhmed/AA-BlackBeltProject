using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Talking : NPC, iInteractable
{
    public static GameObject dialogueBox;

    public enum DialogueMode {Normal, Incorrect, Correct }
    public DialogueMode mode;
    public List<string> Dialogue = new List<string>();
    public List<string> correctDialogue = new List<string>();
    public List<string> incorrectDialogue = new List<string>();

    public string WhatNeeded;
    public int DialogueNumber;
    public static GameObject dialogueText;
    public void interact()
    {
        PlayerCam.canMove = false;
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
        dialogueBox.SetActive(true);

        if (mode == DialogueMode.Normal)
        {
            if (DialogueNumber >= Dialogue.Count)
            {
                dialogueBox.SetActive(false);
            }
            else
            {
                dialogueText.GetComponent<TextMeshProUGUI>().text = Dialogue[DialogueNumber];
                DialogueNumber += 1;
            }

        }

        if (mode == DialogueMode.Correct)
        {
            if (DialogueNumber >= correctDialogue.Count)
            {
                dialogueBox.SetActive(false);
            }
            else
            {
                dialogueText.GetComponent<TextMeshProUGUI>().text = correctDialogue[DialogueNumber];
                DialogueNumber += 1;
            }
        }

        if (mode == DialogueMode.Incorrect)
        {
            if (DialogueNumber >= incorrectDialogue.Count)
            {
                dialogueBox.SetActive(false);
            }
            else
            {
                dialogueText.GetComponent<TextMeshProUGUI>().text = incorrectDialogue[DialogueNumber];
                DialogueNumber += 1;
            }
        }
        //show a dialogue
        //There are arrows to move on to the next dialogue
    }

    public void Give(Object thingtogive)
    {
        dialogueBox.SetActive(true);


        if (WhatNeeded == thingtogive.GetComponent<Object>().WhatWanted)
        {
            mode = DialogueMode.Correct;
            dialogueText.GetComponent<TextMeshProUGUI>().text = correctDialogue[0];
            Inventory.inventory.RemoveInventory(Inventory.inventory.slotNumber);
            DialogueNumber = 1;
        }
        else
        {
            mode = DialogueMode.Incorrect;
            dialogueText.GetComponent<TextMeshProUGUI>().text = incorrectDialogue[0];
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        dialogueText = GameObject.Find("Canvas/DialogueBox/Dialogue");
        dialogueBox = GameObject.Find("Canvas/DialogueBox");
        dialogueBox.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
