using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TriggerChecker_Player : MonoBehaviour
{
    public static TriggerChecker_Player instance;

    public GameObject rotater;
    public TMP_Text diam_text;
    public int d;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	void OnTriggerExit(Collider col){
		if (col.gameObject.CompareTag("laddu"))
		{
            gameObject.transform.parent.localScale += new Vector3(0,0,0.5f);
		}

        if (col.gameObject.CompareTag("antim"))
        {
            GameManager.instance.Level1Cleared = true;

        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("laal"))
        {
            GameManager.instance.GameOver = true;
        }

        
    }

}
