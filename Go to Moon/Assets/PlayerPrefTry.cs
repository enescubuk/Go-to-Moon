using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPrefTry : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log(PlayerPrefs.GetFloat("speed"));
            Debug.Log(PlayerPrefs.GetInt("wing"));
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            SceneManager.LoadScene("new");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            SceneManager.LoadScene("Garage");
        }

    }
}
