using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Text nameText;
    public Text dialogueText;

    public Animator animator;

    private Queue<string> sentences;

    public Canvas Inventorygui;

    private BossScript bossScript;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
        bossScript = GameObject.Find("Boss").GetComponent<BossScript>();
        
    }

    public void StartDialogue(Dialogue dialogue, int startFrom, int endAt) 
    {
        Inventorygui.enabled = false;

        animator.SetBool("IsOpen", true);
        
        nameText.text = dialogue.name;

        sentences.Clear();

        for (int i = startFrom; i < endAt + 1; i++) 
        {
            sentences.Enqueue(dialogue.sentences[i]);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence() 
    {
        if (sentences.Count == 0) 
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
        
    
    }

    IEnumerator TypeSentence(string sentence) 
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray()) 
        {
            dialogueText.text += letter;
            yield return null;
        }
    
    }

    void EndDialogue() 
    {
        animator.SetBool("IsOpen", false);
        Inventorygui.enabled = true;
        bossScript.notimes = 0;
    }

}
