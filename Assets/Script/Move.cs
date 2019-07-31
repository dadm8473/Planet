using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Transform maincamera;

    void Start()
    {
        maincamera = Camera.main.transform.parent;
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        transform.Rotate(v * 50 * Time.deltaTime, h * 50 * Time.deltaTime, 0f);

        maincamera.transform.rotation = transform.rotation;
    }
}
