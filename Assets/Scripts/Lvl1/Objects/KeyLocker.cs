using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyLocker : MonoBehaviour
{
    private ConfigurableJoint joint;

    void Start()
    {
        joint = GetComponent<ConfigurableJoint>();
        joint.angularXMotion = ConfigurableJointMotion.Locked;
    }

    public void setOpen()
    {
        joint.angularXMotion = ConfigurableJointMotion.Limited;
    }
}
