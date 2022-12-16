using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   private Rigidbody playerRb;
   private Animator playerAnim;
   private AudioSource playerAudio;
   public ParticleSystem dirtParticle;
   public ParticleSystem explosionParticle;
   public AudioClip jumpSound;
   public AudioClip crashSound;
   public float jumpForce = 10;
   public float gravityModifier;
   public bool isonGround = true;
   public bool gameOver = false;
  

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();
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
        
    }
    void OnCollisionEnter(Collision collision)
    {
        isonGround = true;
    }
}


