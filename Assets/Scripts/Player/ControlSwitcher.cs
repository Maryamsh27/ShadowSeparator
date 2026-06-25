using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlSwitcher : MonoBehaviour
{
    public GameObject player;
    public GameObject shadow;

    bool controllingShadow = false;

    void Update()
    {
        Debug.Log("Script Running");

        if (Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log("Q Pressed");
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            controllingShadow = !controllingShadow;

            Debug.Log(controllingShadow ?
                "Shadow Control" :
                "Player Control");
        }
    }
}
