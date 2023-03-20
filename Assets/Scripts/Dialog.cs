using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog : MonoBehaviour
{
    

    [Header("ink JSON")]
    [SerializeField] private TextAsset inkJSON;

    private bool playerInRange;
    private bool freeze;

    public GameObject panel; 


    private void Awake()
    {
        playerInRange = false;
    }

    private void Update()
    {
        freeze = DialogueManager.GetInstance().dialogueIsPlaying;

        if (playerInRange && !freeze)
        {
           if (Input.GetKeyDown(KeyCode.Z))
           {
                //Debug.Log(inkJSON.text);
                DialogueManager.GetInstance().EnterDialogueMode(inkJSON);

           }
        }
    }
    
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            playerInRange = true;
            panel.SetActive(true);
        }
    }
    
    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            playerInRange = false;
            panel.SetActive(false);
        }
    }
}
