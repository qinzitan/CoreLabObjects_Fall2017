using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InClassExample : MonoBehaviour {

    int num = 2;

    void Start()
    {
        int localNum = 4;
        int total = localNum + 5;

        Debug.Log(total);
    }

    void Update()
    {
        //Debug.Log("This is Update: " + "localNum");
    }

}
