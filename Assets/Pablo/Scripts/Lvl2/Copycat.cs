using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Copycat : MonoBehaviour
{

    public Transform reference;
    public Transform toCopy;
    private Vector3 distance;

    [SerializeField] private bool isCopycatCharacter;
    [SerializeField] private Transform cameraToCopy;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distance = reference.position - toCopy.position;

        this.gameObject.transform.position = new Vector3(-distance.x, -distance.y, distance.z);
        //this.gameObject.transform.localEulerAngles = new Vector3(this.gameObject.transform.localEulerAngles.x, -(toCopy.localEulerAngles.y), this.gameObject.transform.localEulerAngles.z);

        if(isCopycatCharacter)
        {
            this.gameObject.transform.localEulerAngles = new Vector3(-cameraToCopy.localEulerAngles.x, 180-(cameraToCopy.localEulerAngles.y), cameraToCopy.localEulerAngles.z);
        }
        else
        {
            this.gameObject.transform.localEulerAngles = new Vector3(toCopy.localEulerAngles.x, -(toCopy.localEulerAngles.y), -toCopy.localEulerAngles.z);
        }
        
    }
}
