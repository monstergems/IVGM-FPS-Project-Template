using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy_text : MonoBehaviour
{
    public GameObject textDisplay;

    void Start()
    {
        //yield WaitForSecondsRealtime(5);
        Destroy(textDisplay,4);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
