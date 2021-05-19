using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Animator catAnimationController;
    public AudioClip meowSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Fish"))
            catAnimationController.SetBool("FishTrigger", true);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Fish"))

            catAnimationController.SetBool("FishTrigger", false);

    }
}
