using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class CopyCat_Movement : MonoBehaviour
{
    public CharacterController playerRb;
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    ////Vector3 dirToPlayer = player.position - enemy.position;
    ////dirToPlayer.Normalize(); // the normal vector should have magnitude 1 so the distance between the enemy and the player won't affect the reflection results.
    //Vector3 reflectedVector = Vector3.Reflect(playerRigidBody.velocity, dirToPlayer);
    //enemyRigidBody.velocity = reflectedVector;

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Vector3 dirToPlayer = player.position - this.gameObject.transform.position;
        dirToPlayer.Normalize();
        Vector3 reflectedVector = Vector3.Reflect(playerRb.velocity, dirToPlayer);
        this.gameObject.GetComponent<Rigidbody>().velocity = reflectedVector;
        this.gameObject.transform.localEulerAngles = new Vector3(this.gameObject.transform.localEulerAngles.x, -(player.localEulerAngles.y), this.gameObject.transform.localEulerAngles.z);
    }
}
