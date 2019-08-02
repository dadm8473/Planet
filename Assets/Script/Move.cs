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

        transform.Rotate(0f, h * 80 * Time.deltaTime, 0f);
        transform.Rotate(80 * Time.deltaTime, 0f, 0f);

        maincamera.transform.rotation = transform.rotation;
    }
}
