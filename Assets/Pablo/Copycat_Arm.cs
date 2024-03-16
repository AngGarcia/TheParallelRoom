using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;


public class Copycat_Arm : MonoBehaviour
{
    public CharacterController playerRb;
    public Transform player;
    public Transform firstArmPosition;
    public Transform secondArmPosition;

    public InputDevice firstArm;
    public InputDevice secondArm;

    Vector3 firstArmVelocity;
    Vector3 secondArmVelocity;

    public bool copyLeftHand;

    //private bool copyLeftHandAux;

    // Start is called before the first frame update
    void Start()
    {
        firstArm = InputDevices.GetDeviceAtXRNode(XRNode.LeftHand);
        secondArm = InputDevices.GetDeviceAtXRNode(XRNode.RightHand);
        //copyLeftHandAux = copyLeftHand;
    }

    ////Vector3 dirToarm = arm.position - enemy.position;
    ////dirToarm.Normalize(); // the normal vector should have magnitude 1 so the distance between the enemy and the arm won't affect the reflection results.
    //Vector3 reflectedVector = Vector3.Reflect(armRigidBody.velocity, dirToarm);
    //enemyRigidBody.velocity = reflectedVector;

    // Update is called once per frame
    void Update()
    {
       
    }

    private void FixedUpdate()
    {
        
        firstArm.TryGetFeatureValue(CommonUsages.deviceVelocity, out firstArmVelocity);
        secondArm.TryGetFeatureValue(CommonUsages.deviceVelocity, out secondArmVelocity);

        Debug.Log("Rotacion en Y: "+player.localEulerAngles.y);
        Debug.Log(firstArmVelocity);
        if(playerRb.velocity!=Vector3.zero)
        {
            if (copyLeftHand)
            {
                Vector3 dirToarm = firstArmPosition.position - this.gameObject.transform.position;
                dirToarm.Normalize();
                //Vector3 reflectedVector = Vector3.Reflect(firstArmVelocity, dirToarm);
                Vector3 reflectedVector = Vector3.Reflect(playerRb.velocity, dirToarm);
                this.gameObject.GetComponent<Rigidbody>().velocity = reflectedVector;
            }
            else
            {
                Vector3 dirToarm = secondArmPosition.position - this.gameObject.transform.position;
                dirToarm.Normalize();
                //Vector3 reflectedVector = Vector3.Reflect(secondArmVelocity, dirToarm);
                Vector3 reflectedVector = Vector3.Reflect(playerRb.velocity, dirToarm);
                this.gameObject.GetComponent<Rigidbody>().velocity = reflectedVector;
            }
        }
        else
        {
            if (copyLeftHand)
            {
                Vector3 dirToarm = firstArmPosition.position - this.gameObject.transform.position;
                dirToarm.Normalize();
                //Vector3 reflectedVector = Vector3.Reflect(firstArmVelocity, dirToarm);
                Vector3 reflectedVector = Vector3.Reflect(firstArmVelocity, dirToarm);
                this.gameObject.GetComponent<Rigidbody>().velocity = reflectedVector;
            }
            else
            {
                Vector3 dirToarm = secondArmPosition.position - this.gameObject.transform.position;
                dirToarm.Normalize();
                //Vector3 reflectedVector = Vector3.Reflect(secondArmVelocity, dirToarm);
                Vector3 reflectedVector = Vector3.Reflect(secondArmVelocity, dirToarm);
                this.gameObject.GetComponent<Rigidbody>().velocity = reflectedVector;
            }
        }   
    }
}
