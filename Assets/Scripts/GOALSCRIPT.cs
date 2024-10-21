using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GOALSCRIPT : MonoBehaviour
{
    public MRUMovement mruObject;
    public MRUVMovement mruvObject;

    void Start()
    {
        float travelTimeMRU = mruObject.GetTravelTime();
        mruvObject.AdjustParameters(travelTimeMRU);
    }
}

