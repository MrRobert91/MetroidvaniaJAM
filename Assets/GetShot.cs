using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetShot : MonoBehaviour
{

    public AudioSource audioGetPower;
    public GameObject panel;
    
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            col.gameObject.GetComponent<Attack>().canShot = true;
            //GetComponent<SpriteRenderer>().enabled = false;
            //GetComponent<BoxCollider2D>().enabled = false;
            audioGetPower.PlayOneShot(audioGetPower.clip);

            StartCoroutine(WaitToDestroyPowerUp(2f));

        
        }
        
    }

    IEnumerator WaitToDestroyPowerUp(float time)
	{
        GetComponent<SpriteRenderer>().enabled = false;

        //doubleJumpPanelObject = GameObject.Find("PanelDoubleJump");
        //doubleJumpPanelObject.SetActive(true);

        panel.SetActive(true);

		yield return new WaitForSeconds(time);

        //doubleJumpPanelObject.SetActive(false);

		this.gameObject.SetActive(false);
	}
}
