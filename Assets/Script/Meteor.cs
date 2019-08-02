using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{
    Vector3 centerPos;

    public GameObject explosion;

    void Start()
    {
        centerPos = new Vector3(0, 0, 0);
    }

    void Update()
    {
        RaycastHit hit;
        if(Physics.Raycast(transform.position, centerPos - transform.position, out hit))
        {
            //hit.transform.GetComponent<MeshRenderer>().material.color = Color.red;
            Debug.DrawRay(transform.position, centerPos - transform.position, Color.red, 0.1f);
        }

        transform.position = Vector3.Lerp(transform.position, centerPos, 0.01f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Planet")
        {
            GameObject obj = Instantiate(explosion);
            obj.transform.position = transform.position;
            Destroy(gameObject);
        }
    }
}
 