using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptSphere : MonoBehaviour
{
    #region Unity
    public GameObject sphera;
    public GameObject HealthBar;
    public float speed = 10f;
    #endregion

    #region C#
    SphereCollider spheraCollider;
    private Collider playerCollider;
    private bool trigger = false;
    private float boundsSee = 10f;
    #endregion

    void Update()
    {
        if (trigger)
        {
            transform.LookAt(playerCollider.transform);
            transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
            if (Vector3.Distance(transform.position, playerCollider.transform.position) < boundsSee)
            {
                Debug.Log("Destroy");
                Destroy(sphera, 0.1f);
                
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            playerCollider = other;
            trigger = true;
            HealthBar.GetComponent<HealthBar>().bar.fillAmount += 0.1f;
        }
        else { return; }
    }

}
