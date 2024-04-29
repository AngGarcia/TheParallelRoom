using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyLocker : MonoBehaviour
{
    private ConfigurableJoint joint;
    [SerializeField]
    private GameObject Lock;

    void Start()
    {
        joint = GetComponent<ConfigurableJoint>();
        joint.angularXMotion = ConfigurableJointMotion.Locked;
    }

    public void setOpen()
    {
        joint.angularXMotion = ConfigurableJointMotion.Limited;
        Lock.GetComponent<Rigidbody>().isKinematic = false;
        Lock.GetComponent<BoxCollider>().isTrigger = false;
    }
}
