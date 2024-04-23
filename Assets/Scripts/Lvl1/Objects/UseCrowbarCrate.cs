using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseCrowbarCrate : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    private GameObject crowbar;
    [SerializeField]
    private GameObject caja;

    private bool estaEnganchada = false;

    // Update is called once per frame
    void Update()
    {
        
    }

    public void joinCrowbar()
    {
        Rigidbody cajaRigidBody = caja.GetComponent<Rigidbody>();
        if (cajaRigidBody != null && !estaEnganchada)
        {
            // Añade un FixedJoint para unir la palanca a la caja
            FixedJoint joint = crowbar.AddComponent<FixedJoint>();
            joint.connectedBody = cajaRigidBody;

            estaEnganchada = true;

        }
    }
}
