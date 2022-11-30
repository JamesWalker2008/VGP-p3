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
        if (Input.GetKeyDown(KeyCode.Space) && isonGround)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isonGround = false;
       
        }
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
   
    }
    private void OnCollisionEnter(Collision collision)
    {
        isonGround = true;
    }
}   


