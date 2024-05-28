using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tableMarcos : MonoBehaviour
{
    
    private ConfigurableJoint joint;
    [SerializeField] private GameObject key;
    void Start()
    {
        joint = GetComponent<ConfigurableJoint>();
        joint.zMotion = ConfigurableJointMotion.Locked;
        key.SetActive(false);
    }

    public void unlockTableMarcos()
    {
        joint.zMotion = ConfigurableJointMotion.Limited;
        MusicManager.Instance.PlaySound(AppSounds.OPEN_FURNITURE);
        key.SetActive(true);
    }
}
