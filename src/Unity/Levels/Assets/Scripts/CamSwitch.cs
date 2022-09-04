using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwitch : MonoBehaviour
{
    public GameObject camera1;
    public GameObject camera2;
    public GameObject camera3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Switch1"))
        {
            camera1.SetActive(true);
            camera3.SetActive(false);
            camera2.SetActive(false);

        }
        if (Input.GetButtonDown("Switch2"))
        {
            camera1.SetActive(false);
            camera3.SetActive(false);
            camera2.SetActive(true);

        }
        if (Input.GetButtonDown("Switch3"))
        {
            camera1.SetActive(false);
            camera2.SetActive(false);
            camera3.SetActive(true);

        }

    }
}
