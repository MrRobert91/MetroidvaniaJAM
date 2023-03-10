using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getDoubleJump : MonoBehaviour
{
    public AudioSource audioGetPower;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            col.gameObject.GetComponent<CharacterController2D>().hasDoubleJump = true;
            GetComponent<SpriteRenderer>().enabled = false;
            audioGetPower.PlayOneShot(audioGetPower.clip);

        
        }
        
    }
}

