using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CheckGrabPressed : MonoBehaviour
{
    [SerializeField] private InputActionProperty grabButton;
    public bool isInPokeArea;
    public bool isGrabbing;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (grabButton.action.IsPressed() && !isInPokeArea)
        {
            isGrabbing = true;
            this.gameObject.GetComponent<Animator>().SetInteger("Hand", 1);
        }
        else if(!grabButton.action.IsPressed() && !isInPokeArea)
        {
            isGrabbing = false;
            this.gameObject.GetComponent<Animator>().SetInteger("Hand", 0);
        }
        
    }
}
