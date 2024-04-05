using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tape : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject fixedCable1;
    [SerializeField]
    private GameObject brokenCable1;

    [SerializeField]
    private GameObject fixedCable2;
    [SerializeField]
    private GameObject brokenCable2;

    private bool canFix;
    private int cablePack;
    void Start()
    {
        canFix = false;
        cablePack = 0;
    }

    public void fixCable()
    {
        if (canFix)
        {
            if (cablePack == 1)
            {
                fixedCable1.SetActive(true);
                brokenCable1.SetActive(false);
            }
            else if(cablePack == 2)
            {
                fixedCable2.SetActive(true);
                brokenCable2.SetActive(false);
            }
        }
    }

    public void canBeFixed()
    {
        canFix = true;
    }

    public void canNotBeFixed()
    {
        canFix = false;
    }

    public void stateCable(int num)
    {
        cablePack = num;
    }
}
