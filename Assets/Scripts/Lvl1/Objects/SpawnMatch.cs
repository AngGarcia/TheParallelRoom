using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cerillaPrefab;
    public Transform spawnCerilla;

    //private GameObject previousCerilla;


    public void cogerCerilla()
    {

        GameObject newCerilla = Instantiate(cerillaPrefab, spawnCerilla.position, Quaternion.identity);

        newCerilla.transform.Rotate(new Vector3(180f, 0f, 0f));
        newCerilla.transform.SetParent(this.gameObject.transform);

    }
}
