using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockerDoor : MonoBehaviour
{
    private ConfigurableJoint doorJoint;

    public float openAngle = 20f;

    void Start()
    {
        doorJoint = this.gameObject.GetComponent<ConfigurableJoint>();
    }


    public void OpenDoor()
    {
        Debug.Log("Abriendo puerta...");
        doorJoint.targetRotation = Quaternion.Euler(20f, 0f, 0f);
    }
}
