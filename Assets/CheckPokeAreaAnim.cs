using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPokeAreaAnim : MonoBehaviour
{
    [SerializeField] private BoxCollider leftControllerCollider;
    [SerializeField] private BoxCollider rightControllerCollider;
    [SerializeField] private Transform button1;
    [SerializeField] private Transform button2;

    private Vector3 leftControllerPos;
    private Vector3 rightControllerPos;
    private Vector3 buttonPos1;
    private Vector3 buttonPos2;
    private float distance;
    [SerializeField] private bool isRightHand;
    private CheckGrabPressed checkGrabPressed;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = this.gameObject.GetComponent<Animator>();
        checkGrabPressed = this.gameObject.GetComponent<CheckGrabPressed>();
        buttonPos1 = button1.GetComponent<Transform>().position;
        buttonPos2 = button2.GetComponent<Transform>().position;
        distance = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        
        leftControllerPos = leftControllerCollider.gameObject.GetComponent<Transform>().position;
        rightControllerPos = rightControllerCollider.gameObject.GetComponent<Transform>().position;

        if (isRightHand )
        {
            if (Vector3.Distance(buttonPos1, rightControllerPos) <= distance || Vector3.Distance(buttonPos2, rightControllerPos) <= distance)
            {
                checkGrabPressed.isInPokeArea = true;
                animator.SetInteger("Hand", 2);
            }
            else
            {
                checkGrabPressed.isInPokeArea = false;
                animator.SetInteger("Hand", 0);
            }
        }

        else
        {
            if (Vector3.Distance(buttonPos1, leftControllerPos) <= distance || Vector3.Distance(buttonPos2, leftControllerPos) <= distance)
            {
                Debug.Log("ENTRO");
                checkGrabPressed.isInPokeArea = true;
                animator.SetInteger("Hand", 2);
            }
            else
            {
                checkGrabPressed.isInPokeArea = false;
                animator.SetInteger("Hand", 0);
            }
        }
    }
}
