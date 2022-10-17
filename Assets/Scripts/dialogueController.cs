using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogueController : MonoBehaviour
{
    public Dialogue dialogue;
    public dialogueObject dialogueObject;
    public int currentLine;

    // Start is called before the first frame update
    
    public void getDialogue()
    {
        dialogueObject = Mouse_Cursor.selected.GetComponent<interactableObject>().dialogue;
        dialogue.dialogue = dialogueObject;
    }
    public void printLine(int currentLine)
    {
        dialogue.printLine(currentLine);
    }
    public void printCurrentLine()
    {
        dialogue.printLine(currentLine);
    }
    public void clear()
    {
        if (dialogue.gameObject.transform.childCount > 0)
        {
            GameObject.Destroy(dialogue.gameObject.transform.GetChild(0).gameObject);
        }   
    }
    public void nextLine()
    {
        currentLine++;
        if (currentLine < dialogue.dialogue.textLines.Count)
        {
            GameObject.Destroy(dialogue.gameObject.transform.GetChild(0).gameObject);
            dialogue.printLine(currentLine);
        }
        else
        {
            GameObject.Destroy(dialogue.gameObject.transform.GetChild(0).gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Submit"))
        {
            clear();
        }
    }
}
