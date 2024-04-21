using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class CopycatGrab : MonoBehaviour
{
    public GameObject menu1;
    public GameObject menu2;
    public InputActionProperty grabButton;
    public Transform attachPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.GetComponent<GrabCheck>()!=null && grabButton.action.IsPressed() && !menu1.activeSelf && !menu2.activeSelf)
        {
            other.gameObject.transform.position = attachPoint.position;
        }
    }
}
