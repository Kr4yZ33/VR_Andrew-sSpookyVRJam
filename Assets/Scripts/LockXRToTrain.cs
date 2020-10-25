using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockXRToTrain : MonoBehaviour
{

    public Transform xRRig;
    public Transform train;

    // Update is called once per frame
    void Update()
    {
        LockRigToTrain();
    }

    void LockRigToTrain()
    {
        xRRig.transform.position = train.transform.position;
        xRRig.transform.rotation = train.transform.rotation;
    }
}
