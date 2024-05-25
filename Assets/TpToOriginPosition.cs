using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TpToOriginPosition : MonoBehaviour
{
    [SerializeField] private GameObject pawn;
    [SerializeField] private GameObject knight;
    [SerializeField] private GameObject bishop1;
    [SerializeField] private GameObject bishop2;
    [SerializeField] private GameObject king;
    [SerializeField] private GameObject remote;
    [SerializeField] private GameObject blueFlower;
    [SerializeField] private GameObject redFlower;
    [SerializeField] private GameObject yellowFlower;
    [SerializeField] private GameObject orangeFlower;

    private Vector3 pawnResetPosition;
    private Vector3 knightResetPosition;
    private Vector3 bishop1ResetPosition;
    private Vector3 bishop2ResetPosition;
    private Vector3 kingResetPosition;
    private Vector3 remoteResetPosition;
    private Vector3 blueFlowerResetPosition;
    private Vector3 redFlowerResetPosition;
    private Vector3 yellowFlowerResetPosition;
    private Vector3 orangeFlowerResetPosition;

    private Quaternion pawnResetRotation;
    private Quaternion knightResetRotation;
    private Quaternion bishop1ResetRotation;
    private Quaternion bishop2ResetRotation;
    private Quaternion kingResetRotation;
    private Quaternion remoteResetRotation;
    private Quaternion blueFlowerResetRotation;
    private Quaternion redFlowerResetRotation;
    private Quaternion yellowFlowerResetRotation;
    private Quaternion orangeFlowerResetRotation;


    // Start is called before the first frame update
    void Start()
    {
        pawnResetPosition           = pawn.transform.position;
        knightResetPosition         = knight.transform.position;
        bishop1ResetPosition        = bishop1.transform.position;
        bishop2ResetPosition        = bishop2.transform.position;
        kingResetPosition           = king.transform.position;
        remoteResetPosition         = remote.transform.position;
        blueFlowerResetPosition     = blueFlower.transform.position;
        redFlowerResetPosition      = redFlower.transform.position;
        yellowFlowerResetPosition   = yellowFlower.transform.position;
        orangeFlowerResetPosition   = orangeFlower.transform.position;

        pawnResetRotation           = pawn.transform.localRotation;
        knightResetRotation         = knight.transform.localRotation;
        bishop1ResetRotation        = bishop1.transform.localRotation;
        bishop2ResetRotation        = bishop2.transform.localRotation;
        kingResetRotation           = king.transform.localRotation;
        remoteResetRotation         = remote.transform.localRotation;
        blueFlowerResetRotation     = blueFlower.transform.localRotation;
        redFlowerResetRotation      = redFlower.transform.localRotation;
        yellowFlowerResetRotation   = yellowFlower.transform.localRotation;
        orangeFlowerResetRotation   = orangeFlower.transform.localRotation;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Pawn")
        {
            pawn.GetComponent<Transform>().position = pawnResetPosition;
            pawn.GetComponent<Transform>().rotation = pawnResetRotation;

        }

        if (collision.gameObject.tag == "Knight")
        {
            knight.GetComponent<Transform>().position = knightResetPosition;
            knight.GetComponent<Transform>().rotation = knightResetRotation;
        }

        if (collision.gameObject.tag == "Bishop1")
        {
            bishop1.GetComponent<Transform>().position = bishop1ResetPosition;
            bishop1.GetComponent<Transform>().rotation = bishop1ResetRotation;
        }

        if (collision.gameObject.tag == "Bishop2")
        {
            bishop2.GetComponent<Transform>().position = bishop2ResetPosition;
            bishop2.GetComponent<Transform>().rotation = bishop2ResetRotation;
        }

        if (collision.gameObject.tag == "King")
        {
            king.GetComponent<Transform>().position = kingResetPosition;
            king.GetComponent<Transform>().rotation = kingResetRotation;
        }

        if (collision.gameObject.tag == "Remote")
        {
            remote.GetComponent<Transform>().position = remoteResetPosition;
            remote.GetComponent<Transform>().rotation = remoteResetRotation;
        }

        if (collision.gameObject.tag == "BlueFlower")
        {
            blueFlower.GetComponent<Transform>().position = blueFlowerResetPosition;
            blueFlower.GetComponent<Transform>().rotation = blueFlowerResetRotation;
        }

        if (collision.gameObject.tag == "RedFlower")
        {
            redFlower.GetComponent<Transform>().position = redFlowerResetPosition;
            redFlower.GetComponent<Transform>().rotation = redFlowerResetRotation;
        }

        if (collision.gameObject.tag == "YellowFlower")
        {
            yellowFlower.GetComponent<Transform>().position = yellowFlowerResetPosition;
            yellowFlower.GetComponent<Transform>().rotation = yellowFlowerResetRotation;
        }

        if (collision.gameObject.tag == "OrangeFlower")
        {
            orangeFlower.GetComponent<Transform>().position = orangeFlowerResetPosition;
            orangeFlower.GetComponent<Transform>().rotation = orangeFlowerResetRotation;
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Pawn")
        {
            pawn.GetComponent<Transform>().position = pawnResetPosition;
            pawn.GetComponent<Transform>().rotation = pawnResetRotation;

        }

        if (collision.gameObject.tag == "Knight")
        {
            knight.GetComponent<Transform>().position = knightResetPosition;
            knight.GetComponent<Transform>().rotation = knightResetRotation;
        }

        if (collision.gameObject.tag == "Bishop1")
        {
            bishop1.GetComponent<Transform>().position = bishop1ResetPosition;
            bishop1.GetComponent<Transform>().rotation = bishop1ResetRotation;
        }

        if (collision.gameObject.tag == "Bishop2")
        {
            bishop2.GetComponent<Transform>().position = bishop2ResetPosition;
            bishop2.GetComponent<Transform>().rotation = bishop2ResetRotation;
        }

        if (collision.gameObject.tag == "King")
        {
            king.GetComponent<Transform>().position = kingResetPosition;
            king.GetComponent<Transform>().rotation = kingResetRotation;
        }

        if (collision.gameObject.tag == "Remote")
        {
            remote.GetComponent<Transform>().position = remoteResetPosition;
            remote.GetComponent<Transform>().rotation = remoteResetRotation;
        }

        if (collision.gameObject.tag == "BlueFlower")
        {
            blueFlower.GetComponent<Transform>().position = blueFlowerResetPosition;
            blueFlower.GetComponent<Transform>().rotation = blueFlowerResetRotation;
        }

        if (collision.gameObject.tag == "RedFlower")
        {
            redFlower.GetComponent<Transform>().position = redFlowerResetPosition;
            redFlower.GetComponent<Transform>().rotation = redFlowerResetRotation;
        }

        if (collision.gameObject.tag == "YellowFlower")
        {
            yellowFlower.GetComponent<Transform>().position = yellowFlowerResetPosition;
            yellowFlower.GetComponent<Transform>().rotation = yellowFlowerResetRotation;
        }

        if (collision.gameObject.tag == "OrangeFlower")
        {
            orangeFlower.GetComponent<Transform>().position = orangeFlowerResetPosition;
            orangeFlower.GetComponent<Transform>().rotation = orangeFlowerResetRotation;
        }
    }
}
