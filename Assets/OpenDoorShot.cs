using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoorShot : MonoBehaviour
{

    public AudioSource audioDestroyDoor;

    //void OnTriggerEnter2D(Collider2D col)
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Shot")
        {
            
            audioDestroyDoor.PlayOneShot(audioDestroyDoor.clip);
            StartCoroutine(WaitToDestroyDoor(1f));

            //Destroy(this.gameObject);

        
        }

    }


    IEnumerator WaitToDestroyDoor(float time)
	{
        GetComponent<SpriteRenderer>().enabled = false;

        //doubleJumpPanelObject = GameObject.Find("PanelDoubleJump");
        //doubleJumpPanelObject.SetActive(true);

        //panel.SetActive(true);

		yield return new WaitForSeconds(time);

        //doubleJumpPanelObject.SetActive(false);

		this.gameObject.SetActive(false);
	}

}
