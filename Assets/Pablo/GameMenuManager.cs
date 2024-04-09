using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameMenuManager : MonoBehaviour
{
    public Transform head;
    public float spawnDistance = 2;
    public GameObject menu;
    public GameObject confirmationCanvas;
    public InputActionProperty showButton;
    public GameObject mandoIzquierdo;
    public GameObject RayInteractorObject;
    public GameObject DirectIntercatorObject;
    public GameObject quitButton;
    public GameObject resetButton;

    public Slider m_musicSlider;

    public float maxPositionX = 3.3f;
    public float minPositionX = -3.3f;
    public float maxPositionZ = 3.3f;
    public float minPositionZ = -3.3f;


    // Start is called before the first frame update
    void Start()
    {
        m_musicSlider.value = GameManager.CommonVariablesInstance.volumeMusic;
    }

    // Update is called once per frame
    void Update()
    {
        if(showButton.action.WasPressedThisFrame() && !confirmationCanvas.activeSelf)
        {
            if(!menu.activeSelf)
            {
                m_musicSlider.value = GameManager.CommonVariablesInstance.volumeMusic;
                menu.SetActive(true);
                RayInteractorObject.GetComponent<XRRayInteractor>().enabled = true;
                DirectIntercatorObject.GetComponent<XRDirectInteractor>().enabled = false;
                mandoIzquierdo.GetComponent<XRDirectInteractor>().enabled= false;
                menu.transform.position = head.position + new Vector3(head.forward.x,0,head.forward.z).normalized * spawnDistance;
                

                if (menu.transform.position.x > maxPositionX)
                {
                    menu.transform.position = new Vector3(maxPositionX, menu.transform.position.y, menu.transform.position.z);
                }

                if (menu.transform.position.x < minPositionX)
                {
                    menu.transform.position = new Vector3(minPositionX, menu.transform.position.y, menu.transform.position.z);
                }

                if (menu.transform.position.z > maxPositionZ)
                {
                    menu.transform.position = new Vector3(menu.transform.position.x, menu.transform.position.y, maxPositionZ);
                }

                if (menu.transform.position.z < minPositionZ)
                {
                    menu.transform.position = new Vector3(menu.transform.position.x, menu.transform.position.y, minPositionZ);
                }

                menu.transform.LookAt(new Vector3(head.position.x, menu.transform.position.y, head.position.z));
                menu.transform.forward *= -1;

                if (SceneManager.GetActiveScene().name == "MainMenu")
                {
                    quitButton.SetActive(false);
                    resetButton.SetActive(true);
                }
                    
                
                else
                {
                    quitButton.SetActive(true);  
                    resetButton.SetActive(false);
                }
                    
                
            }
            else
            {
                menu.SetActive(false);
                RayInteractorObject.GetComponent<XRRayInteractor>().enabled = false;
                DirectIntercatorObject.GetComponent<XRDirectInteractor>().enabled = true;
                mandoIzquierdo.GetComponent<XRDirectInteractor>().enabled = true;
                MusicManager.Instance.MusicVolumeSave = m_musicSlider.value;
                GameManager.CommonVariablesInstance.volumeMusic = m_musicSlider.value;
            }
            //menu.SetActive(!menu.activeSelf);
        }


    }

    public void closeMenu()
    {
        menu.SetActive(false);
        RayInteractorObject.GetComponent<XRRayInteractor>().enabled = false;
        DirectIntercatorObject.GetComponent<XRDirectInteractor>().enabled = true;
        mandoIzquierdo.GetComponent<XRDirectInteractor>().enabled = true;
        MusicManager.Instance.MusicVolumeSave = m_musicSlider.value;
        GameManager.CommonVariablesInstance.volumeMusic = m_musicSlider.value;
    }

    public void activateConfirmationCanvas()
    {
        menu.SetActive(false);
        RayInteractorObject.GetComponent<XRRayInteractor>().enabled = false;
        DirectIntercatorObject.GetComponent<XRDirectInteractor>().enabled = true;
        mandoIzquierdo.GetComponent<XRDirectInteractor>().enabled = true;
        MusicManager.Instance.MusicVolumeSave = m_musicSlider.value;
        GameManager.CommonVariablesInstance.volumeMusic = m_musicSlider.value;


        confirmationCanvas.SetActive(true);
        RayInteractorObject.GetComponent<XRRayInteractor>().enabled = true;
        DirectIntercatorObject.GetComponent<XRDirectInteractor>().enabled = false;
        mandoIzquierdo.GetComponent<XRDirectInteractor>().enabled = false;
        confirmationCanvas.transform.position = head.position + new Vector3(head.forward.x, 0, head.forward.z).normalized * spawnDistance;
        confirmationCanvas.transform.LookAt(new Vector3(head.position.x, confirmationCanvas.transform.position.y, head.position.z));
        confirmationCanvas.transform.forward *= -1;
    }

    public void pressedNO()
    {
        confirmationCanvas.SetActive(false);
        m_musicSlider.value = GameManager.CommonVariablesInstance.volumeMusic;
        menu.SetActive(true);
        RayInteractorObject.GetComponent<XRRayInteractor>().enabled = true;
        DirectIntercatorObject.GetComponent<XRDirectInteractor>().enabled = false;
        mandoIzquierdo.GetComponent<XRDirectInteractor>().enabled = false;
        menu.transform.position = head.position + new Vector3(head.forward.x, 0, head.forward.z).normalized * spawnDistance;

        if (menu.transform.position.x > maxPositionX)
        {
            menu.transform.position = new Vector3(maxPositionX, menu.transform.position.y, menu.transform.position.z);
        }

        if (menu.transform.position.x < minPositionX)
        {
            menu.transform.position = new Vector3(minPositionX, menu.transform.position.y, menu.transform.position.z);
        }

        if (menu.transform.position.z > maxPositionZ)
        {
            menu.transform.position = new Vector3(menu.transform.position.x, menu.transform.position.y, maxPositionZ);
        }

        if (menu.transform.position.z < minPositionZ)
        {
            menu.transform.position = new Vector3(menu.transform.position.x, menu.transform.position.y, minPositionZ);
        }

        menu.transform.LookAt(new Vector3(head.position.x, menu.transform.position.y, head.position.z));
        menu.transform.forward *= -1;

        if (SceneManager.GetActiveScene().name == "MainMenu")
        {
            quitButton.SetActive(false);
            resetButton.SetActive(true);
        }


        else
        {
            quitButton.SetActive(true);
            resetButton.SetActive(false);
        }
    }

    public void onMusicValueChanged()
    {
        MusicManager.Instance.MusicVolume = m_musicSlider.value;
        GameManager.CommonVariablesInstance.volumeMusic = m_musicSlider.value;
    }

    public void onQuitToMenu()
    {
        GameManager.SceneChangerInstance.mainMenu();
    }
}
