using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TNT : MonoBehaviour
{
    [SerializeField] private GameObject flame;
    [SerializeField] private GameObject explosion;
    [SerializeField] private float timeToExplode;
    [SerializeField] private float timeToRespawn;
    [SerializeField] private float distanceToDie = 3.0f;
    [SerializeField] private GameObject player;
    private float distance;
    [SerializeField] private Transform respawnPosition;
    [SerializeField] private GameObject dinamite;
    [SerializeField] private GameObject parent;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "BlowtorchFlame")
        {
            flame.SetActive(true);
            StartCoroutine(explosionCountdown(timeToExplode));
        }

        if (other.gameObject.tag == "Match")
        {
            flame.SetActive(true);
            StartCoroutine(explosionCountdown(timeToExplode));
        }
    }

    IEnumerator explosionCountdown(float timeToExplode) 
    {
        yield return new WaitForSeconds(timeToExplode);
        flame.SetActive(false);
        explosion.SetActive(true);
        StartCoroutine(explode(1.3f));
        
    }

    IEnumerator explode(float explosionTime)
    {
        yield return new WaitForSeconds(explosionTime);
        explosion.SetActive(false);
        distance = Vector3.Distance(player.transform.position, this.transform.position);
        Debug.Log(distance);
        if (distance <= distanceToDie)
        {
            MusicManager.Instance.PlaySound(AppSounds.PLAYER_DEATH);
            SceneChanger.Instance.mainMenu();
        }
        else
        {
            StartCoroutine(respawnTNT(timeToRespawn));
        }
    }

    IEnumerator respawnTNT(float timeToRespawn)
    {
        yield return new WaitForSeconds(timeToRespawn);
        GameObject din = Instantiate(dinamite);
        din.transform.position = respawnPosition.position;
        Destroy(parent);
    }
}
