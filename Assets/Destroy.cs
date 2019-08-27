using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    SphereCollider sc;

    void Start()
    {
        sc = this.GetComponent<SphereCollider>();
        Destroy(gameObject, 0.8f);
        Destroy(sc, 0.1f);
    }
}
