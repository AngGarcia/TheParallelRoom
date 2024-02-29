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
    public InputActionProperty showButton;
    public GameObject RayInteractorObject;
    public GameObject DirectIntercatorObject;
    public GameObject quitButton;

    public Slider m_musicSlider;


    // Start is called before the first frame update
    void Start()
    {
        m_musicSlider.value = GameManager.CommonVariablesInstance.volumeMusic;
    }

    // Update is called once per frame
    void Update()
    {
        if(showButton.action.WasPressedThisFrame())
        {
            if(!menu.activeSelf)
            {
                m_musicSlider.value = GameManager.CommonVariablesInstance.volumeMusic;
                menu.SetActive(true);
                RayInteractorObject.GetComponent<XRRayInteractor>().enabled = true;
                DirectIntercatorObject.GetComponent<XRDirectInteractor>().enabled = false;
                menu.transform.position = head.position + new Vector3(head.forward.x,0,head.forward.z).normalized * spawnDistance;
                menu.transform.LookAt(new Vector3(head.position.x, menu.transform.position.y, head.position.z));
                menu.transform.forward *= -1;

                if(SceneManager.GetActiveScene().name == "MainMenu")
                    quitButton.SetActive(false);
                
                else                
                    quitButton.SetActive(true);
                
            }
            else
            {
                menu.SetActive(false);
                RayInteractorObject.GetComponent<XRRayInteractor>().enabled = false;
                DirectIntercatorObject.GetComponent<XRDirectInteractor>().enabled = true;
                MusicManager.Instance.MusicVolumeSave = m_musicSlider.value;
                GameManager.CommonVariablesInstance.volumeMusic = m_musicSlider.value;
            }
            //menu.SetActive(!menu.activeSelf);
        }


    }

    public void onMusicValueChanged()
    {
        MusicManager.Instance.MusicVolume = m_musicSlider.value;
        GameManager.CommonVariablesInstance.volumeMusic = m_musicSlider.value;
    }
}
