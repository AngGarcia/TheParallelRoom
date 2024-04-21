using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // Start is called before the first frame update
    //public AudioSource audioSource;
    //public AudioClip button;
    public FadeScreen fadeScreen;
    private void Start()
    {
        Time.timeScale = 1;

        if(GameObject.FindWithTag("faderScreen")!=null)
            fadeScreen = GameObject.FindWithTag("faderScreen").GetComponent<FadeScreen>();
    }


    public void lvl1()
    {
        StartCoroutine(delayLvl1());
        //SceneManager.LoadScene("Lvl1_Mines");
        //GameManager.Instance.level = 1;
        //GameManager.Instance.saveToJson();
        //Cursor.lockState = CursorLockMode.Locked;
    }

    public void mainMenu()
    {
        StartCoroutine (delayMainMenuScreen());
        //MusicManager.Instance.PlayBackgroundMusic(AppSounds.MAIN_MENU_MUSIC);
        //SceneManager.LoadScene("MainMenu");
        //Cursor.lockState = CursorLockMode.Confined;
    }

    public void exitGame()
    {
        StartCoroutine(delayExit());
        //MusicManager.Instance.StopBackgroundMusic();
        //Application.Quit();

    }

    IEnumerator delayLvl1()
    {
        fadeScreen.FadeOut();

        yield return new WaitForSecondsRealtime(fadeScreen.fadeDuration);

        SceneManager.LoadScene("Lvl1_Mines");
        GameManager.Instance.level = 1;
        GameManager.Instance.saveToJson();
        Cursor.lockState = CursorLockMode.Locked;
        if (GameObject.FindWithTag("faderScreen") != null)
            fadeScreen = GameObject.FindWithTag("faderScreen").GetComponent<FadeScreen>();
    }

    IEnumerator delayMainMenuScreen()
    {
        fadeScreen.FadeOut();
        
        yield return new WaitForSeconds(fadeScreen.fadeDuration);

        SceneManager.LoadScene("MainMenu");
        Cursor.lockState = CursorLockMode.Confined;
        if (GameObject.FindWithTag("faderScreen") != null)
            fadeScreen = GameObject.FindWithTag("faderScreen").GetComponent<FadeScreen>();
    }

    IEnumerator delayExit()
    {
        fadeScreen.FadeOut();

        yield return new WaitForSeconds(fadeScreen.fadeDuration);

        Application.Quit();
    }
}
