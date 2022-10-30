using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class open_gate : MonoBehaviour
{
    public GameObject gate_one;
    public GameObject gate_two;
    public GameObject knop;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (knop==null)
            {
                gate_one.transform.eulerAngles = new Vector3(gate_one.transform.eulerAngles.x,
                0,
                gate_one.transform.eulerAngles.z
                );
                gate_two.transform.eulerAngles = new Vector3(gate_two.transform.eulerAngles.x,
                0,
                gate_two.transform.eulerAngles.z
                );
                // gate_one.transform.eulerAngles.y = 0;
                // gate_two.transform.eulerAngles.y = 0;
            }
        
    }
}
