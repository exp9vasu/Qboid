using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
	
	public GameObject cube;
	public Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - cube.transform.position;
    }

    // Update is called once per frame
    void Update()    
    {
        transform.position = cube.transform.position + offset;
    }
}
