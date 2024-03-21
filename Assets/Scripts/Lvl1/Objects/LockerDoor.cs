using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockerDoor : MonoBehaviour
{
    private ConfigurableJoint doorJoint;

    public float openAngle = 90f;
    public float openSpeed = 2f;

    private float currentAngle;
    private float targetAngle;

    private bool openDoor;

    void Start()
    {
        doorJoint = this.gameObject.GetComponent<ConfigurableJoint>();
        // establecemos el �ngulo original de la puerta
        currentAngle = doorJoint.targetRotation.eulerAngles.y;
        targetAngle = currentAngle;
        openDoor = false;
    }

    void Update()
    {
        // Si la puerta no est� completamente abierta, seguir abri�ndola gradualmente
        if (openDoor && currentAngle < openAngle)
        {
            currentAngle = Mathf.MoveTowards(currentAngle, targetAngle, openSpeed * Time.deltaTime);
            doorJoint.targetRotation = Quaternion.Euler(0f, currentAngle, 0f);
        }
    }

    public void OpenDoor()
    {
        // Establecer el �ngulo objetivo de apertura de la puerta
        targetAngle = openAngle;
        openDoor = true;
    }
}
