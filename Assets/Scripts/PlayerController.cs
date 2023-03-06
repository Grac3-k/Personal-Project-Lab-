using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;  
    public float jumpForce = 10;
    public float gravityModifier;
    public bool isOnGround = true;
    public float speed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
             playerRb.AddForce(Vector3.up* 10, ForceMode.Impulse);
             isOnGround = false;
        }

        //We'll move the player to the right
         transform.Translate(Vector3.right * Time.deltaTime * speed);

    }

    private void OnCollisionEnter(Collision collision)
    {
        isOnGround = true;
    }
}
