using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class OrganList : MonoBehaviour
{

    public Image brainIcon;
    public Image heartIcon;
    public Image bladderIcon;
    public Image lungIcon;
    public Image stomachIcon;

    /*public UnityEvent findOrgan;

    public void OnOrganFound()
    {
        findOrgan.Invoke();
    }
    */

    public void ChangeButtonColor()
    {

        //GetComponent<Image>().color = Color.white;




    }
    public void OnBrainFound()
    {
        brainIcon.color = Color.white;
    }

    public void OnLungFound()
    {
        lungIcon.color = Color.white;
    }

    public void OnBladderFound()
    {
        bladderIcon.color = Color.white;
    }

    public void OnHeartFound()
    {
        heartIcon.color = Color.white;
    }

    public void OnStomachFound()
    {
        stomachIcon.color = Color.white;
    }
}
