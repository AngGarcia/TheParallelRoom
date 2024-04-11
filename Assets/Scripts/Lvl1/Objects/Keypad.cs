using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Keypad : MonoBehaviour
{
    // Start is called before the first frame update
    //public int numToType;
    [SerializeField]
    private TMP_Text textGlass;
    [SerializeField]
    private LockerDoor lockerDoor;
    [SerializeField]
    private GameObject pokeInteractorLeft;
    [SerializeField]
    private GameObject pokeInteractorRight;
    [SerializeField]
    private GameObject shovel;
    [SerializeField]
    private BoxCollider leftControllerCollider;
    [SerializeField]
    private BoxCollider rightControllerCollider;
    [SerializeField]
    private BoxCollider keypadCollider;

    private string actualCode = "4598";
    private int numMaxDigitos;
    private string actualText;
    private bool canType;
    private bool done;

    private Vector3 leftControllerPos;
    private Vector3 rightControllerPos;
    private Vector3 keypadPos;
    private float distance;

    void Start()
    {
        numMaxDigitos = 4;
        actualText = "";
        canType = true;
        done = false;

        keypadPos = this.gameObject.GetComponent<Transform>().position;
        distance = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        if (textGlass.text.Length >= numMaxDigitos)
        {
           // Debug.Log("No se puede escribir m?as");
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
            actualText = actualText + numToType.ToString();
            textGlass.text = actualText;
            Debug.Log(numToType + " tipeado");
        }
    }

    public void cleanScreen()
    {
        if (!done)
        {
            canType = true;
            actualText = "";
            textGlass.text = actualText;
        }
    }

    public void checkAnswer()
    {
        if (textGlass.text == actualCode)
        {
            canType = false;
            done = true;

            lockerDoor.OpenDoor();
           // keypadCollider.enabled = false;
            pokeInteractorLeft.SetActive(false);
            pokeInteractorRight.SetActive(false);
            shovel.SetActive(true);
            leftControllerCollider.enabled = true;
            rightControllerCollider.enabled = true;
        }
        else
        {
            //poner sfx de 'WROOONG'
            actualText = "";
            textGlass.text = actualText;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(this.gameObject.transform.position, distance);
    }

}