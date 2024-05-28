using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CheckGrabPressed : MonoBehaviour
{
    [SerializeField] private InputActionProperty grabButton;
    public bool isInPokeArea;
    public bool isGrabbing;
 
    void Update()
    {
        if (grabButton.action.IsPressed() && !isInPokeArea)
        {
            this.gameObject.GetComponent<Animator>().SetInteger("Hand", 1);
        }
        else if(!grabButton.action.IsPressed() && !isInPokeArea)
        {
            this.gameObject.GetComponent<Animator>().SetInteger("Hand", 0);
        }
        
    }
}
