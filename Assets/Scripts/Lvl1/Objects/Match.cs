using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Match : MonoBehaviour
{
    [SerializeField]
    private GameObject kinematicMatch;
    [SerializeField]
    private GameObject gravityMatch;
    public void activateGravity()
    {
        kinematicMatch.SetActive(false);
        gravityMatch.SetActive(true);
    }

    public void deactivateGravity()
    {
        kinematicMatch.SetActive(true);
        gravityMatch.SetActive(false);
    }
}
