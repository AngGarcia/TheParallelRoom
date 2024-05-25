using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Television : MonoBehaviour
{
    private float audioLength = 6f;
    private float actualTime = 0f;
    private bool isON = false;
    private bool repeat;

    void Start()
    {
        isON = false;
        repeat = false;
    }

    // Update is called once per frame
    void Update()
    {
        //reproducimos en bucle el audio de la estática de la TV
        if (isON)
        {
            if (repeat)
            {
                Debug.Log("REPETIMOS");
                MusicManager.Instance.PlaySound(AppSounds.TV_STATIC);
                repeat = false;
                actualTime = 0;
            }
            else
            {
                //esperamos a que acabe el audio para repetirlo
                actualTime += Time.deltaTime;
                Debug.Log(actualTime);

                if (actualTime >= audioLength)
                {
                    //MusicManager.Instance.PlaySound(AppSounds.TV_STATIC);
                    repeat = true;
                    actualTime = 0;
                }
            }
        }
    }

    public void turnON()
    {
        isON = true;
        repeat = true; //para que suene por 1º vez el audio
    }

    public void turnOFF()
    {
        isON = false;
    }
}
