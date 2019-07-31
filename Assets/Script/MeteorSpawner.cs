using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpawner : MonoBehaviour
{
    public GameObject cube;

    // Start is called before the first frame update
    void Start()
    {
        for(int x = -180; x <= 180; ++x)
            for(int y = -180; y <= 180; ++y)
                for(int z = -180; z <= 180; ++z)
                    Instantiate(cube, new Vector3(0, 0, -6), Quaternion.Euler(x, y, z));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
