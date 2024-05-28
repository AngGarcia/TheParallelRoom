using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MenuButton : MonoBehaviour
{

    [SerializeField]
    private BoxCollider leftControllerCollider;

    [SerializeField]
    private BoxCollider rightControllerCollider;

    [SerializeField]
    private GameObject pokeInteractorLeft;
    
    [SerializeField]
    private GameObject pokeInteractorRight;

    private Vector3 buttonPos;
    private Vector3 leftControllerPos;
    private Vector3 rightControllerPos;
    [SerializeField] private float distance = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        buttonPos = this.gameObject.GetComponent<Transform>().position;
    }

    // Update is called once per frame
    void Update()
    {
        leftControllerPos = leftControllerCollider.gameObject.GetComponent<Transform>().position;
        rightControllerPos = rightControllerCollider.gameObject.GetComponent<Transform>().position;

        //mano izquierda
        if (Vector3.Distance(buttonPos, leftControllerPos) > distance)
        {
            pokeInteractorLeft.SetActive(false);
            leftControllerCollider.enabled = true;
        }
        else
        {
            pokeInteractorLeft.SetActive(true);
            leftControllerCollider.enabled = false;
        }

        //mano derecha
        if (Vector3.Distance(buttonPos, rightControllerPos) > distance)
        {
            pokeInteractorRight.SetActive(false);
            rightControllerCollider.enabled = true;
        }
        else
        {
            pokeInteractorRight.SetActive(true);
            rightControllerCollider.enabled = false;
        }
    }
}
