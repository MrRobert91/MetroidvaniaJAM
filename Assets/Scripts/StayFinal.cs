using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StayFinal : MonoBehaviour
{
    // Start is called before the first frame update
    void OnEnable()
    {
        //SceneManager.LoadScene("Intro", LoadSceneMode.Single);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        SceneManager.LoadScene("MenuFinal");
    }
}
