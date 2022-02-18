using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController1 : MonoBehaviour
{
    public Rigidbody sphera;
    Collider go;
    bool trigger = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (trigger)
        {
            transform.LookAt(go.transform);
            transform.Translate(new Vector3(0, 0, 10 * Time.deltaTime));
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            go = other;
            trigger = true;
        }
        else { return; }
    }

}
