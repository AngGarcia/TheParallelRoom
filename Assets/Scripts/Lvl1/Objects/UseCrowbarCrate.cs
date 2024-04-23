using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseCrowbarCrate : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    private GameObject crowbar;
    [SerializeField]
    private Animator animatorCrowbar;

    private GameObject tapaCaja;
    private GameObject socketCaja;

    private float fuerzaInicial = 10f; 
    private Vector3 direccionImpulso = Vector3.up; 


    public void openCrateAnim(GameObject tapa)
    {
        tapaCaja = tapa;
        animatorCrowbar.SetInteger("openCrate", 1);
    }

    public void setSocket(GameObject socket)
    {
        socketCaja = socket;
    }

    public void abrirTapa()
    {
        socketCaja.SetActive(false);
        animatorCrowbar.SetInteger("openCrate", 0);
        tapaCaja.AddComponent<Rigidbody>();
        tapaCaja.GetComponent<Rigidbody>().AddForce(direccionImpulso * fuerzaInicial, ForceMode.Impulse);
    }
}
