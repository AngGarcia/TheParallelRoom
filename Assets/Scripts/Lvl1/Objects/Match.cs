using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Match : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rigidbody;

    public void activateGravity()
    {
        rigidbody.isKinematic = false;
    }

    public void deactivateGravity()
    {
        rigidbody.isKinematic = true;
    }
}
