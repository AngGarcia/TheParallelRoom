using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DestructableHinge : MonoBehaviour
{
    private ConfigurableJoint joint;
    [SerializeField]
    private Rigidbody rb;
    private XRGrabInteractable GI;
    [SerializeField]
    private GameObject itemInside;

    private static int numberOfHinges = 2;

    private void Start()
    {
        joint = GetComponent<ConfigurableJoint>();
        GI = GetComponent<XRGrabInteractable>();
    }

    public void restaNOH()
    {
        //Debug.Log(numberOfHinges);
        numberOfHinges--;
        if(numberOfHinges <= 0)
        {
            joint.breakForce = 0.001f;
            rb.useGravity = true;
            GI.movementType = XRBaseInteractable.MovementType.Instantaneous;
            itemInside.SetActive(true);
        }
    }
}
