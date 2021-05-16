using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Position : MonoBehaviour
{
    public Vector3 positionChange;
    // Start is called before the first frame update
    void Start()
    {
        float x = Random.Range(0.0f, 1.0f) / 10.0f;
        float y = Random.Range(0.0f, 1.0f) / 10.0f;
        float z = Random.Range(0.0f, 1.0f) / 10.0f;
        
        positionChange.Set(x, y, z);

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += positionChange;
    }
}
