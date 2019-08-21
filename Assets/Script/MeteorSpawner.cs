using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpawner : MonoBehaviour
{
    public GameObject pivot;
    public GameObject[] spawnerList = new GameObject[50];

    public GameObject meteorPrefab;

    int y_count = 0;
    public float me_rotate = 0;

    // Start is called before the first frame update
    void Start()
    {
        for (int x = -20; x <= 20; x += 10)
        {
            for (int y = -180; y <= 180; y += 40)
            {
                GameObject obj = Instantiate(pivot, new Vector3(0, 0, 0), Quaternion.Euler(x , y + me_rotate, 0));
                obj.transform.parent = this.transform;
                spawnerList[y_count] = obj;
                //Debug.Log(y_count);
                y_count++;
            }
        }

        StartCoroutine(MeteorAttack());
    }

    void Update()
    {
        
    }

    IEnumerator MeteorAttack()
    {
        while (true)
        {
            Transform attackObj = spawnerList[Random.Range(0, 50)].transform.GetChild(0);

            GameObject meteor = Instantiate(meteorPrefab);
            meteor.transform.position = attackObj.position;

            yield return new WaitForSeconds(Random.Range(0.5f, 0.5f));

            //yield return null;
        }
    }
}
