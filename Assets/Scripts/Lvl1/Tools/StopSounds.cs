using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopSounds : MonoBehaviour
{
    void Start()
    {
        MusicManager.Instance.StopBackgroundMusic();
    }

}
