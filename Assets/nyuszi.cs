using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nyuszi : MonoBehaviour
{
    public int nyusz = 99;
    public static nyuszi instance2;
    //public static mozogjatekos Instance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        instance2 = this;
        
    }
}
