using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unlockCupboardDoors : MonoBehaviour
{

    [SerializeField] private HingeJoint Door1;
    [SerializeField] private HingeJoint Door2;
    void Start()
    {
        lockDoors();
    }

    public void unlockDoors()
    {
        MusicManager.Instance.PlaySound(AppSounds.OPEN_FURNITURE);
        JointLimits limit = Door1.limits;
        limit.max = 100.0f;
        
        Door1.limits = limit;

        limit = Door2.limits;
        limit.max = 100.0f;
        
        Door1.limits = limit;
    }

    void lockDoors()
    {
        JointLimits limit = Door1.limits;
        limit.max = 0.0f;

        Door1.limits = limit;

        limit = Door2.limits;
        limit.max = 0.0f;

        Door1.limits = limit;
    }
}
