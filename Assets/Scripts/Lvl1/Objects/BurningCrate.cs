using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurningCrate : MonoBehaviour
{
    [SerializeField]
    private GameObject fire;

    [SerializeField]
    private GameObject objectInside;

    private bool touchingFire = false;
    private bool inFlames = false;
    private float segundos = 0.0f;
    void Start()
    {
        fire.SetActive(false);
        segundos = 0.0f;
        inFlames = false;
    }

    // Update is called once per frame
    void Update()
    {
        //si la caja está ardiendo
        if (inFlames)
        {
            segundos += Time.deltaTime;
            Debug.Log("Segundos: " + segundos);
            if(segundos > 5)
            {
                fire.SetActive(false);
                this.gameObject.SetActive(false); //desactivamos la caja
                objectInside.SetActive(true);
            }
        }
        else {

            //si la llama está tocando la caja
            if (touchingFire)
            {
                segundos += Time.deltaTime;
                Debug.Log("Segundos: " + segundos);

                if (segundos > 3)
                {
                    fire.SetActive(true);
                    inFlames = true;
                    segundos = 0.0f; //reseteamos otra vez
                }
            }
            else
            {
                segundos = 0.0f;
            }

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("BlowtorchFlame"))
        {
            touchingFire = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("BlowtorchFlame"))
        {
            touchingFire = false;
        }
    }
}
