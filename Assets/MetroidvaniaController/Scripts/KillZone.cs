using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillZone : MonoBehaviour
{

    //public Transform init_transform;
    //public Transform player_transform;


    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);

            //Esto no funciona, habrá que pasarle el transform del player directamente
            //col.gameObject.transform = init_transform;

        }
        else
        {
            Destroy(col.gameObject);
        }
    }
}
