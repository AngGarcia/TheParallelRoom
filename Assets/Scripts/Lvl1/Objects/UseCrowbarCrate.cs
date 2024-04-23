using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseCrowbarCrate : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    private GameObject crowbar;
    [SerializeField]
    private GameObject tapaCaja;
    [SerializeField]
    private Animator animatorCrowbar;

    public void openCrateAnim()
    {
        animatorCrowbar.SetInteger("openCrate", 1);
    }

    public void abrirTapa()
    {
        tapaCaja.SetActive(false);
    }
}
