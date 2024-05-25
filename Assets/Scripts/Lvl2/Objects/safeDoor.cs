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
        MusicManager.Instance.PlaySound(AppSounds.UNLOCK_SAFE);
        doorJoint.xMotion = ConfigurableJointMotion.Limited;
        doorJoint.angularXMotion = ConfigurableJointMotion.Limited;
        //doorJoint.targetRotation = Quaternion.Euler(20f, 0f, 0f);
        doorJoint.targetAngularVelocity = new Vector3(2f, 0f, 0f);
        wheelAnimator.SetInteger("openSafe", 0);

        blueFlower.SetActive(true);

    }
}
