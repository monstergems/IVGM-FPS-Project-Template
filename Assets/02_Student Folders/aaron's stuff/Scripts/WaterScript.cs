using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterScript : MonoBehaviour
{
    public Transform target_low;
    public Transform target_high;
    public float frac;

    public static bool[] rise_status= new bool[1];

    void Start()
    {
        
    }

    void Update()
    {
        if(rise_status[0]== true)//was if rise
        {
            //transform.position=target_high.position;
            transform.position=Vector3.Lerp(target_low.position,target_high.position,frac);
            //transform.position += Vector3.up * 10.0f;
        }
        else
        {
            //transform.position=target_low.position;
            transform.position=Vector3.Lerp(target_high.position,target_low.position,frac);
            //transform.position += Vector3.up * -10.0f;
        }
    }
}
