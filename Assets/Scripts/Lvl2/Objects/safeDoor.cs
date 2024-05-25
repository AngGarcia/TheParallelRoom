using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class safeDoor : MonoBehaviour
{
    [SerializeField]
    private GameObject blueFlower;

    private ConfigurableJoint doorJoint;

    public Animator wheelAnimator;
    public float openAngle = 20f;

    void Start()
    {
        // doorJoint = this.gameObject.GetComponent<HingeJoint>();
        blueFlower.SetActive(false);
        doorJoint = this.gameObject.GetComponent<ConfigurableJoint>();
    }


    public void OpenDoor()
    {
        /*if (this.gameObject.GetComponent<HingeJoint>() == null)
        {
            Debug.Log("Abriendo puerta...");
            MusicManager.Instance.PlaySound(AppSounds.UNLOCK_SAFE);

            doorJoint = this.gameObject.AddComponent<HingeJoint>();
            doorJoint.anchor = new Vector3(-0.3f, 0.03f, 0.32f);
            doorJoint.axis = new Vector3(0, 1, 0);
            doorJoint.useSpring = true;
            doorJoint.useLimits = true;
            // Obtener el componente JointLimits para establecer los límites de rotación
            JointLimits limits = doorJoint.limits;
            // Establecer los límites de rotación en grados
            limits.min = -100f;
            limits.max = 10f;
            // Aplicar los límites al HingeJoint
            doorJoint.limits = limits;
            //doorJoint.xMotion = ConfigurableJointMotion.Limited;
            //doorJoint.angularXMotion = ConfigurableJointMotion.Limited;
            //doorJoint.targetRotation = Quaternion.Euler(20f, 0f, 0f);
            wheelAnimator.SetInteger("openSafe", 0);
        }*/
        doorJoint.xMotion = ConfigurableJointMotion.Limited;
        doorJoint.angularXMotion = ConfigurableJointMotion.Limited;
        //doorJoint.targetRotation = Quaternion.Euler(20f, 0f, 0f);
        doorJoint.targetAngularVelocity = new Vector3(2f, 0f, 0f);
        wheelAnimator.SetInteger("openSafe", 0);

        blueFlower.SetActive(true);

    }
}
