using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   private Rigidbody playerRb;
   public float jumpForce = 10;
   public float gravityModifier;
   public bool isonGround = true;
   private float speed = 30;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isonGround = false;
            playerRb.AddForce(Vector3.up * 100, ForceMode.Impulse); 
        }
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
    void OnCollisionEnter(Collision collision)
    {
        isonGround = true;
    }
}


