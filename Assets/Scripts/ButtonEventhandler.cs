using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ButtonEventhandler : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private float speed = 0.5f;
    private float angle;
    private bool btnLeftPressed = false;
    private bool btnRightPressed = false;
    private bool btnForwardPressed = false;
    private bool btnBackwardsPressed = false;
    // Start is called before the first frame update
    void Start()
    {
        VirtualButtonBehaviour[] vbs= GetComponentsInChildren<VirtualButtonBehaviour>();
        for (int i = 0; i < vbs.Length; i++)
        {
            vbs[i].RegisterOnButtonPressed(OnButtonPressed);
            vbs[i].RegisterOnButtonReleased(OnButtonReleased);
        }

        
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        switch (vb.VirtualButtonName)
        {
            case "btnLeft":
                btnLeftPressed = true;
                break;
            
            case "btnRight":
                btnRightPressed = true;
                break;
            case "btnForward":
                btnForwardPressed = true;
                break;
            
            case "btnBackwards":
                btnBackwardsPressed = true;
                break;
        }
    }
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        switch (vb.VirtualButtonName)
        {
            case "btnLeft":
                btnLeftPressed = false;
                break;

            case "btnRight":
                btnRightPressed = false;
                break;
            case "btnForward":
                btnForwardPressed = false;
                break;

            case "btnBackwards":
                btnBackwardsPressed = false;
                break;
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (btnForwardPressed)
        {
            player.transform.position += (speed * 0.1f) * player.transform.forward;
            Debug.Log("forward");
        }

        else if (btnBackwardsPressed)
        {
            player.transform.position -= (speed * 0.1f) * player.transform.forward;
            Debug.Log("backwards");
        }

        else if (btnLeftPressed)
        {
            angle += -0.05f;

            Vector3 targetDirection = new Vector3(Mathf.Sin(angle), 0, Mathf.Cos(angle));
            player.transform.rotation = Quaternion.LookRotation(targetDirection);
            Debug.Log("left");
        }

        else if (btnRightPressed)
        {
            angle += -0.05f;

            Vector3 targetDirection = new Vector3(Mathf.Sin(angle), 0, Mathf.Cos(angle));
            player.transform.rotation = Quaternion.LookRotation(targetDirection);
            Debug.Log("right");
        }
    }
}
