using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeKeypad : MonoBehaviour
{
    [SerializeField]
    private safeDoor safeDoor;
    [SerializeField]
    private GameObject pokeInteractorLeft;
    [SerializeField]
    private GameObject pokeInteractorRight;
    [SerializeField]
    private BoxCollider leftControllerCollider;
    [SerializeField]
    private BoxCollider rightControllerCollider;
    [SerializeField]
    private Transform realPosition;
    [SerializeField]
    private Animator wheelAnimator;
    [SerializeField]
    private KeypadButton botonOK;

    private string actualCode = "7777"; //es diferente
    private int numMaxDigitos;
    private string actualNum;
    private bool canType;
    private bool done;

    private Vector3 leftControllerPos;
    private Vector3 rightControllerPos;
    private Vector3 keypadPos;
    private float distance;

    void Start()
    {
        numMaxDigitos = 4;
        actualNum = "";
        canType = true;
        done = false;

        // keypadPos = this.gameObject.GetComponent<Transform>().position;
        keypadPos = realPosition.position;
        distance = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        if(actualNum.Length >= numMaxDigitos)
        {
            canType = false;
        }

        //done nos indica si hemos abierto la taquilla o no (hemos introducido el código correcto)
        if (!done)
        {
            leftControllerPos = leftControllerCollider.gameObject.GetComponent<Transform>().position;
            rightControllerPos = rightControllerCollider.gameObject.GetComponent<Transform>().position;
            //cojo el transform del keypad y el transform de cada una de las manos
            //mano izquierda
            if (Vector3.Distance(keypadPos, leftControllerPos) > distance)
            {
                pokeInteractorLeft.SetActive(false);
                leftControllerCollider.enabled = true;
            }
            else
            {
                pokeInteractorLeft.SetActive(true);
                leftControllerCollider.enabled = false;
            }

            //mano derecha
            if (Vector3.Distance(keypadPos, rightControllerPos) > distance)
            {
                pokeInteractorRight.SetActive(false);
                rightControllerCollider.enabled = true;
            }
            else
            {
                pokeInteractorRight.SetActive(true);
                rightControllerCollider.enabled = false;
            }
        }
    }

    public void typeNum(int numToType)
    {
        if (canType && !done)
        {
            MusicManager.Instance.PlaySound(AppSounds.SAFE_BUTTON);
            actualNum = actualNum + numToType.ToString();
            Debug.Log(numToType + " tipeado");
            Debug.Log("Actual numero: " + actualNum);
        }
    }

    public void cleanScreen()
    {
        if (!done)
        {
            MusicManager.Instance.PlaySound(AppSounds.SAFE_BUTTON);
            canType = true;
            actualNum = "";
            Debug.Log("Actual numero: " + actualNum);
        }
    }

    public void checkAnswer()
    {
        if (actualNum == actualCode)
        {
            Debug.Log("Actual numero: " + actualNum);
            canType = false;
            done = true;
            botonOK.setIsFollowing(false);

            MusicManager.Instance.PlaySound(AppSounds.SAFE_BUTTON);

            pokeInteractorLeft.SetActive(false);
            pokeInteractorRight.SetActive(false);
            leftControllerCollider.enabled = true;
            rightControllerCollider.enabled = true;

            //realizar animación de apertura y abrir la caja fuerte
            //ejecutar animación y esta tendrá un evento que abre la puerta (como el Crate del lvl1)
            wheelAnimator.SetInteger("openSafe", 1);
            MusicManager.Instance.PlaySound(AppSounds.UNLOCK_SAFE);
        }
        else
        {
            MusicManager.Instance.PlaySound(AppSounds.SAFE_BUTTON);
            actualNum = "";
            Debug.Log("Actual numero: " + actualNum);
            canType = true;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        //Gizmos.DrawWireSphere(this.gameObject.transform.position, distance);
        Gizmos.DrawWireSphere(realPosition.position, distance);
    }
}
