using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{
    Vector3 centerPos;
    LineRenderer lineRenderer;
    public GameObject cyliRender;

    public GameObject explosion;

    void Start()
    {
        //lineRenderer = GetComponent<LineRenderer>();
        centerPos = new Vector3(0, 0, 0);
    }

    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, centerPos - transform.position, out hit))
        {
            //if (hit.collider.tag == "Planet")
            //{
            //    if (Input.GetMouseButton(0))
            //    {
            //        Renderer rend = hit.transform.GetComponent<Renderer>();
            //        MeshCollider meshCollider = hit.collider as MeshCollider;

            //        //Debug.Log(rend);
            //        //Debug.Log(rend.sharedMaterial);
            //        //Debug.Log(rend.sharedMaterial.mainTexture);
            //        //Debug.Log(meshCollider);

            //        if (rend == null || rend.sharedMaterial == null || rend.sharedMaterial.mainTexture == null || meshCollider == null)
            //        {
            //            //Debug.Log(rend);
            //            //Debug.Log(rend.sharedMaterial);
            //            //Debug.Log(rend.sharedMaterial.mainTexture);
            //            //Debug.Log(meshCollider);
            //        }

            //        Texture2D tex = rend.material.mainTexture as Texture2D;
            //        Vector2 pixelUV = hit.textureCoord;
            //        pixelUV.x *= tex.width;
            //        pixelUV.y *= tex.height;

            //        tex.SetPixel((int)pixelUV.x, (int)pixelUV.y, Color.black);
            //    }
            //}
            
            //hit.transform.GetComponent<MeshRenderer>().material.color = Color.red;
            Debug.DrawRay(transform.position, centerPos - transform.position, Color.red, 0.1f);
        }

        transform.position = Vector3.Lerp(transform.position, centerPos, 0.01f);
        cyliRender.transform.localScale = new Vector3(1, 7, 1);
        transform.LookAt(centerPos);
        //lineRenderer.SetPosition(0, transform.position);
        //lineRenderer.SetPosition(1, centerPos - transform.position);
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
 