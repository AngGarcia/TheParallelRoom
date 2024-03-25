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
            Debug.Log("CONSEGUIDOOO!!");
            canType = false;
            done = true;

            //hacer la movida de activar lo que sea
            lockerDoor.OpenDoor();
        }
        else
        {
            //poner sfx de 'WROOONG'
            actualText = "";
            textGlass.text = actualText;
        }
    }
}