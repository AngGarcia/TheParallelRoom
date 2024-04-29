using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundSoundsManager : MonoBehaviour
{
    [SerializeField]
    private AudioClip voices;
    [SerializeField]
    private AudioClip rocksFalling;
    [SerializeField]
    private AudioClip explosion;

    [SerializeField]
    private AudioClip mineroSong;
    [SerializeField]
    private AudioClip ambientMusic;

    [SerializeField]
    private AudioSource audioSourceSFX;
    [SerializeField]
    private AudioSource audioSourceMusic;
    private float delayTime = 30f;

    void Start()
    {
        //StartCoroutine(PlayAudioWithDelay());
        audioSourceMusic.clip = ambientMusic;
        audioSourceMusic.Play();
        StartCoroutine(PlayMineSFXWithDelay());
    }

    IEnumerator PlayVoicesWithDelay()
    {
        while (true)
        {
            audioSourceSFX.PlayOneShot(voices);
            yield return new WaitForSeconds(voices.length + delayTime);
        }
    }

    IEnumerator PlayMineSFXWithDelay()
    {

        float num = 0.0f;

        while (true)
        {

            // Generar un número aleatorio entre 0 y 2
            num = Mathf.RoundToInt(Random.Range(0f, 1f));

            if(num == 0)
            {
                audioSourceSFX.PlayOneShot(rocksFalling);
            }
            else
            {
                audioSourceSFX.PlayOneShot(explosion);
            }
            yield return new WaitForSeconds(delayTime);
        }
    }

}
