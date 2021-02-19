using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Script_Player : MonoBehaviour
{
    public static Script_Player instance;

    public Rigidbody cube;
    public int omega_y;
    public GameObject start_anim;
    bool started;

    private void Awake()
    { 
        if (instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {
        started = false;
    }

    void FixedUpdate()
    {
        if (started)
        {
            start_anim.SetActive(false);
            cube.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 10f);
        }

        if (!started)
        {
            if(Input.anyKeyDown)
            {
                started = true;
            }
        }
     
        /*if (Input.GetKey("s"))
        {
            cube.transform.RotateAround(transform.position, new Vector3(0, omega_y, 0), 120 *Time.deltaTime);
        }

        else if (Input.GetKey("d"))
        {
            cube.transform.RotateAround(transform.position, new Vector3(0, -omega_y, 0), 120 * Time.deltaTime);
        }*/

    }

    public void RotateCW()
    {
        //cube.transform.Rotate(0, omega_y, 0);
        cube.transform.RotateAround(transform.position, new Vector3(0, omega_y, 0), 90 *12 * Time.deltaTime);
    }

    public void RotateACW()
    {
        //cube.transform.Rotate(0, -omega_y, 0);
        cube.transform.RotateAround(transform.position, new Vector3(0, -omega_y, 0), 90* 12 * Time.deltaTime);
    }
    
    public void cubeStop()
    {
        cube.GetComponent<Rigidbody>().isKinematic = true;
    }

}
