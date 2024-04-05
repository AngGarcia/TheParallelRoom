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
    private GameObject pokeInteractor1;
    [SerializeField]
    private GameObject pokeInteractor2;
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

    void Start()
    {
        numMaxDigitos = 4;
        actualText = "";
        canType = true;
        done = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (textGlass.text.Length >= numMaxDigitos)
        {
           // Debug.Log("No se puede escribir m?as");
            canType = false;
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
            keypadCollider.enabled = false;
            pokeInteractor1.SetActive(false);
            pokeInteractor2.SetActive(false);
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
}