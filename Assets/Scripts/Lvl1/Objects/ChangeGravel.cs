using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeGravel : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private Mesh[] dirtMeshes;
    [SerializeField]
    private GameObject tnt;

    //[SerializeField]
   // private GameObject gravel;

    private int numCavados;
    void Start()
    {
        numCavados = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Shovel"))
        {
            Debug.Log(numCavados);
            if (numCavados > 1)
            {

                this.GetComponent<MeshCollider>().isTrigger = false;
                tnt.SetActive(true);
            }
            else
            {
                numCavados++;
                this.gameObject.GetComponent<MeshFilter>().mesh = dirtMeshes[numCavados];
            }
        }
    }


}
