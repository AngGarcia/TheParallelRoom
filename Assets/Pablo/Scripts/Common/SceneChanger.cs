using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : PersistentSingleton<SceneChanger>
{
    // Start is called before the first frame update
    //public AudioSource audioSource;
    //public AudioClip button;
    public FadeScreen fadeScreen;
    private void Start()
    {
        Time.timeScale = 1;

        SceneManager.sceneLoaded += OnSceneLoaded;
        //if(GameObject.FindWithTag("faderScreen")!=null)
        //    fadeScreen = GameObject.FindWithTag("faderScreen").GetComponent<FadeScreen>();
    }


    public void lvl1()
    {
        StartCoroutine(delayLvl1());
        //SceneManager.LoadScene("Lvl1_Mines");
        //GameManager.Instance.level = 1;
        //GameManager.Instance.saveToJson();
        //Cursor.lockState = CursorLockMode.Locked;
    }

    public void lvl2()
    {
        StartCoroutine(delayLvl2());
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
        int counter = 100;
        fadeScreen.FadeOut();

        yield return new WaitForSecondsRealtime(fadeScreen.fadeDuration);

        
        GameManager.Instance.level = 1;
        GameManager.Instance.saveToJson();
        Cursor.lockState = CursorLockMode.Locked;
        //while (fadeScreen == null && counter >= 0)
        //{
        //    if (GameObject.FindWithTag("faderScreen") != null)
        //    {
        //        fadeScreen = GameObject.FindWithTag("faderScreen").GetComponent<FadeScreen>();
        //        Debug.Log("BUSCO FADER SCREEN 2");
        //    }
        //    counter--;
        //}
        SceneManager.LoadScene("Lvl1_Mines");
    }

    IEnumerator delayLvl2()
    {
        int counter = 100;
        fadeScreen.FadeOut();

        yield return new WaitForSecondsRealtime(fadeScreen.fadeDuration);

        
        GameManager.Instance.level = 2;
        GameManager.Instance.saveToJson();
        Cursor.lockState = CursorLockMode.Locked;
        //while (fadeScreen == null && counter >= 0)
        //{
        //    if (GameObject.FindWithTag("faderScreen") != null)
        //    {
        //        fadeScreen = GameObject.FindWithTag("faderScreen").GetComponent<FadeScreen>();
        //        Debug.Log("BUSCO FADER SCREEN 2");
        //    }
        //    counter--;
        //}
        SceneManager.LoadScene("Lvl2_Habitacion");
    }

    IEnumerator delayMainMenuScreen()
    {
        int counter = 100;
        fadeScreen.FadeOut();
        
        yield return new WaitForSeconds(fadeScreen.fadeDuration);

        

        GameManager.Instance.saveToJson();
        Cursor.lockState = CursorLockMode.Locked;
        //while(fadeScreen == null && counter>=0)
        //{
        //    if (GameObject.FindWithTag("faderScreen") != null)
        //    {
        //        fadeScreen = GameObject.FindWithTag("faderScreen").GetComponent<FadeScreen>();
        //        Debug.Log("BUSCO FADER SCREEN 2");
        //    }
        //    counter--;
        //}

        SceneManager.LoadScene("MainMenu");

    }

    private void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
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
