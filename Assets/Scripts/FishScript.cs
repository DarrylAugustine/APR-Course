using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishScript : MonoBehaviour
{


    [SerializeField] private Animator fishAnimationController;
    public AudioClip meowSound;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Cat"))
        fishAnimationController.SetBool("CatTrigger", true);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Cat"))
           
        fishAnimationController.SetBool("CatTrigger", false);
        
    }
   

}


