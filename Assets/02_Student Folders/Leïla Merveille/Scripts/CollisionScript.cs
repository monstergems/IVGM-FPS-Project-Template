using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider collidingObject)
    {
        if (collidingObject.gameObject.tag == "Player") {
            collidingObject.gameObject.GetComponent<Health>().Kill();
        }
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {
        if( collision.gameObject.tag == "Player" )
        {
            Destroy(collision.gameObject);
        }
    }
}
