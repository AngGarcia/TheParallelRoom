using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeGravel : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private Mesh normalMesh;
    [SerializeField]
    private Mesh secondMesh;
    [SerializeField]
    private GameObject tnt;

    void Start()
    {
        tnt.SetActive(false);
        this.gameObject.GetComponent<MeshFilter>().mesh = normalMesh;
        this.gameObject.GetComponent<MeshCollider>().isTrigger = true;
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Shovel"))
        {
            // this.gameObject.GetComponent<AudioSource>().Play(0);
            MusicManager.Instance.PlaySound(AppSounds.SHOVEL_DIG);
            this.gameObject.GetComponent<MeshFilter>().mesh = secondMesh;
            tnt.SetActive(true);
            // this.gameObject.GetComponent<MeshCollider>().isTrigger = false;
            this.gameObject.GetComponent<MeshCollider>().enabled = false;
            this.gameObject.GetComponent<BoxCollider>().enabled = true;


        }
    }


}
