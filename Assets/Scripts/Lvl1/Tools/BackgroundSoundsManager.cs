using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundSoundsManager : MonoBehaviour
{
    [SerializeField]
    private AudioClip voices;
    [SerializeField]
    private AudioClip mineroSong;

    private AudioSource audioSource;
    private float delayTime = 20f;

    void Start()
    {
        audioSource = this.gameObject.GetComponent<AudioSource>();
        StartCoroutine(PlayAudioWithDelay());
    }

    IEnumerator PlayAudioWithDelay()
    {
        while (true)
        {
            audioSource.PlayOneShot(voices);
            yield return new WaitForSeconds(voices.length + delayTime);
        }
    }
}
