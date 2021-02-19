using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TC_diamond : MonoBehaviour
{
    //public int d;
    

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            PlayerPrefs.SetInt("diamond",PlayerPrefs.GetInt("diamond")+1);
            Destroy(transform.parent.gameObject);

            
        }

    }
}
