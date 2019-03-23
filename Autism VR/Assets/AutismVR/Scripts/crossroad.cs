using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class crossroad : MonoBehaviour
{
    private GameObject fpsCon;
    
    // Start is called before the first frame update
    void Start()
    {
        fpsCon = GameObject.Find("FPSController");
    }

    // Update is called once per frame
    void Update()
    {
        if (fpsCon.transform.position.z < 6.5f)
        {
            GetComponent<Text>().text += "✔️";
            Destroy(this);
        }
    }
}
