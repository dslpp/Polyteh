using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueAnimator : MonoBehaviour
{
    public Animator animat;
    public DialogueManager dm;
    public void OnTriggerEnter2D(Collider2D other)
    {

        animat.SetBool("IsClose", true);


    }
    public void OnTriggerExit2D(Collider2D other)
    {


        animat.SetBool("IsClose", false);
        dm.EndDialogue();




    }
}
