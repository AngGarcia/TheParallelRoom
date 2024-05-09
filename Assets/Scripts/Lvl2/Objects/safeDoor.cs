using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class safeDoor : MonoBehaviour
{
    private ConfigurableJoint doorJoint;

    public Animator wheelAnimator;
    public float openAngle = 20f;

    void Start()
    {
        doorJoint = this.gameObject.GetComponent<ConfigurableJoint>();
    }


    public void OpenDoor()
    {
        Debug.Log("Abriendo puerta...");
        doorJoint.xMotion = ConfigurableJointMotion.Limited;
        doorJoint.angularXMotion = ConfigurableJointMotion.Limited;
        doorJoint.targetRotation = Quaternion.Euler(20f, 0f, 0f);
        wheelAnimator.SetInteger("openSafe", 0);
    }
}
