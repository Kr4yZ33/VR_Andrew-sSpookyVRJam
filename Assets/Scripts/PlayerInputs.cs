using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using System.Linq;

public class PlayerInputs : MonoBehaviour
{
    [SerializeField]
    XRNode xRNodeB = XRNode.LeftHand; // reference to the XR node (left hand)
    //readonly XRNode xRNodeR = XRNode.RightHand;
    readonly List<InputDevice> devices = new List<InputDevice>(); // read only list of input devices

    InputDevice deviceB; // reference to our input device

    void GetDevice()
    {
        InputDevices.GetDevicesAtXRNode(xRNodeB, devices); // get any input devices connected
        deviceB = devices.FirstOrDefault(); // set our device to the first or default in the input device list
    }

    void OnEnable()
    {
        if (!deviceB.isValid) // if not equal to device is valid (there is no device)
        {
            GetDevice(); // call the get device function
        }
    }

    void Update()
    {
        FunctionUpdate();
        PlayerControls();

        if (!deviceB.isValid) // if device is valid is not true
        {
            GetDevice(); // get device
        }

        List<InputFeatureUsage> featuresB = new List<InputFeatureUsage>(); // create a new list for our input features
        deviceB.TryGetFeatureUsages(featuresB); // get all of the features of any type of device connected
    }

    /// <summary>
    /// 
    /// </summary>
    void FunctionUpdate()
    {
        if (Input.GetKey(KeyCode.Home))
        {
            // home button codes
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            // escape button codes
        }
        if (Input.GetKey(KeyCode.Menu))
        {
            Application.Quit();
        }
    }

    /// <summary>
    /// controls what happens when different buttons are pressed
    /// </summary>
    void PlayerControls()
    {
        if (deviceB.TryGetFeatureValue(CommonUsages.triggerButton, out bool triggerValue) && triggerValue) // if the trigger button fo the controller is pressed
        {
            // set bools if trigger is pressed
        }
        else if (triggerValue != true) // otherwsie if the trigger button is not pressed
        {
            // set bool if trigger is not pressed
        }
    }
}
