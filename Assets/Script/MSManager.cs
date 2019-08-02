using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MSManager : MonoBehaviour
{
    public GameObject[] meteorSpawner = new GameObject[3];
    Vector3 rotDir;

    void Start()
    {
        if (!(meteorSpawner[0] && meteorSpawner[1] && meteorSpawner[2]))
            Debug.Log("메테오 스포너가 존재하지 않습니다");

        rotDir = Vector3.left + Vector3.back;

        StartCoroutine(setRandomRotate());
    }

    // Update is called once per frame
    void Update()
    {
        //for (int i = 0; i <= 2; ++i)
        //{
        //    meteorSpawner[i].transform.position = new Vector3(0, 0, 0);
        //    meteorSpawner[i].transform.Rotate(rotDir * Time.deltaTime);
        //    //meteorSpawner[i].transform.rotation = Quaternion.Slerp(meteorSpawner[i].transform.rotation, Quaternion.Euler(rotDir), Time.deltaTime);
        //}

        meteorSpawner[1].transform.rotation = meteorSpawner[0].transform.rotation * Quaternion.Euler(90, 0, 0);
        meteorSpawner[2].transform.rotation = meteorSpawner[0].transform.rotation * Quaternion.Euler(0, 0, 90);

        transform.Rotate(100 * rotDir * Time.deltaTime);
    }

    IEnumerator setRandomRotate()
    {
        while (true)
        {
            if (rotDir == Vector3.left + Vector3.back)
                rotDir = Vector3.forward + Vector3.right;
            else if (rotDir == Vector3.forward + Vector3.right)
                rotDir = Vector3.left + Vector3.back;

            yield return new WaitForSeconds(3);
        }

    }
}
