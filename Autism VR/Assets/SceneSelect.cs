using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSelect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("ScenerioSelector");
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            CityScene();
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            OfficeScene();
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            PlaygroundScene();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            RestuarantScene();
        }
    }

    public void CityScene()
    {
        SceneManager.LoadScene("RoomCity");
    }

    public void OfficeScene()
    {
        SceneManager.LoadScene("RoomOffice");
    }

    public void PlaygroundScene()
    {
        SceneManager.LoadScene("RoomPlayground");
    }

    public void RestuarantScene()
    {
        SceneManager.LoadScene("RoomRestaurant");
    }
}
