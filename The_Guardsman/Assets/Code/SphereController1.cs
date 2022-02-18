using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController1 : MonoBehaviour
{
    #region Unity
    public GameObject sphera;
    public float speed = 10f;
    #endregion

    #region C#
    private bool trigger = false;
    SphereCollider spheraCollider;
    private Collider playerCollider;
    private float boundsSee = 10f;
    #endregion

    private void Start()
    {

    }

    void Update()
    {
        if (trigger)
        {
            transform.LookAt(playerCollider.transform);
            transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
            if (Vector3.Distance(transform.position, playerCollider.transform.position) < boundsSee)
            {
                Debug.Log("Destroy");
                Destroy(sphera, 1f);
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            playerCollider = other;
            trigger = true;
        }
        else { return; }
    }


}
