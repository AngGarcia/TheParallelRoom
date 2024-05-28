using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Copycat : MonoBehaviour
{

    [SerializeField] private Transform reference;
    [SerializeField] private Transform toCopy;
    private Vector3 distance;

    [SerializeField] private bool isCopycatCharacter;
    [SerializeField] private Transform cameraToCopy;

    [SerializeField] private float heightModifier;

    [SerializeField] private Transform ghostParent;
    

    void Update()
    {
        distance = reference.position - toCopy.position;

        this.gameObject.transform.position = new Vector3(-distance.x, -distance.y, distance.z);

        if(isCopycatCharacter)
        {
            this.gameObject.transform.position = new Vector3(-distance.x, -distance.y+heightModifier, distance.z);
            this.gameObject.transform.localEulerAngles = new Vector3(cameraToCopy.localEulerAngles.x, -(cameraToCopy.localEulerAngles.y), -cameraToCopy.localEulerAngles.z);
            ghostParent.localEulerAngles = new Vector3(toCopy.localEulerAngles.x, -(toCopy.localEulerAngles.y), toCopy.localEulerAngles.z);
        }
        else
        {
            this.gameObject.transform.localEulerAngles = new Vector3(toCopy.localEulerAngles.x, -(toCopy.localEulerAngles.y), -toCopy.localEulerAngles.z);
        }
        
    }
}
