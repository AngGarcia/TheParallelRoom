using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // Start is called before the first frame update
    //public AudioSource audioSource;
    //public AudioClip button;
    private void Start()
    {
        Time.timeScale = 1;
    }
    public void lvl1()
    {
        //StartCoroutine(delayLvl1());
        SceneManager.LoadScene("Lvl1_Mines");
        GameManager.Instance.level = 1;
        GameManager.Instance.saveToJson();
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void mainMenu()
    {
        //StartCoroutine (delayMainMenuScreen());
        //MusicManager.Instance.PlayBackgroundMusic(AppSounds.MAIN_MENU_MUSIC);
        SceneManager.LoadScene("MainMenu");
        Cursor.lockState = CursorLockMode.Confined;
    }

    public void exitGame()
    {
        //StartCoroutine(delayExit());
        //MusicManager.Instance.StopBackgroundMusic();
        Application.Quit();

    }

    IEnumerator delayLvl1()
    {
        //audioSource.PlayOneShot(button);
        //yield return new WaitForSecondsRealtime(button.length);
        yield return new WaitForSeconds(2.0f);
        SceneManager.LoadScene("Lvl1_Mines");
        Cursor.lockState = CursorLockMode.Confined;
    }

    IEnumerator delayMainMenuScreen()
    {
        //audioSource.PlayOneShot(button);
        //yield return new WaitForSecondsRealtime(button.length);
        yield return new WaitForSeconds(2.0f);
        SceneManager.LoadScene("MainMenu");
        Cursor.lockState = CursorLockMode.Confined;
    }

    IEnumerator delayExit()
    {
        //audioSource.PlayOneShot(button);
        //yield return new WaitForSeconds(button.length);
        yield return new WaitForSeconds(2.0f);
        Application.Quit();
    }
}
