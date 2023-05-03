using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Talking : NPC, iInteractable
{
    public static GameObject dialogueBox;
    public List<string> Dialogue = new List<string>();
    public int DialogueNumber;
    public static GameObject dialogueText;
    public void interact()
    {
        dialogueBox.SetActive(true);
        dialogueText.GetComponent<TextMeshProUGUI>().text = Dialogue[DialogueNumber];
        DialogueNumber += 1;
        if (DialogueNumber == Dialogue.Count) 
        {
            dialogueBox.SetActive(false);
        }
      
        //show a dialogue
        //There are arrows to move on to the next dialogue
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
