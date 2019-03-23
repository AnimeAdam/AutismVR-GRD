using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bothways : MonoBehaviour
{
    private float timer;
    public float stopTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > stopTime)
        {
            GetComponent<Text>().text += "✔️";
            Destroy(this);
        }
    }
}
