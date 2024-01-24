using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nyuszi1 : MonoBehaviour
{
    public string nyusz = "almafa";
    public static nyuszi1 instance2;
    //public GameObject ellen;
    //public static mozogjatekos Instance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("2"))
        {
            transform.position =nyuszi.instance2.transform.position;
        }
        instance2 = this;
        
        
    }
}
