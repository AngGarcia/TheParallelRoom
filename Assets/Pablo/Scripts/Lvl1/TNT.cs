using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TNT : MonoBehaviour
{
    public GameObject flame;
    public GameObject explosion;
    public float timeToExplode;
    public float timeToRespawn;
    public float distanceToDie = 3.0f;
    [SerializeField] private GameObject player;
    private float distance;
    public Transform respawnPosition;
    public GameObject dinamite;
    public GameObject parent;
    // Start is called before the first frame update
    void Start()
    {
        //player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }


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
            //poner SFX de muerte del HappyWheels
            GameManager.SceneChangerInstance.mainMenu();
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
