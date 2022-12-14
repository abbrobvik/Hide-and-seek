using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public Transform spawnpoint;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = spawnpoint.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
