using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;
using System;

public class hasznal : MonoBehaviour
{
    public TextMeshProUGUI textm1;
    public TextMeshProUGUI textm2;
    public float ido=0;
    public Color[] szinek;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (nyuszi.instance2 != null) 
        {
            ido += Time.deltaTime;

            textm1.text = nyuszi.instance2.nyusz.ToString(); 
            textm2.text = Math.Round(ido, 2).ToString();
           
                nyuszi.instance2.gameObject.transform.localScale = new Vector3(4, 4, 4);
            nyuszi.instance2.gameObject.GetComponent<Renderer>().material.color = szinek[2];

        };
        
        //if (kocka.instance != null)
        //{
        //    textm.text = kocka.instance.nyusz.ToString();
        //    kocka.instance.gameObject.transform.localScale = new Vector3(4, 4, 4);
        //    //kocka.instance.gameObject.Ge23 tComponent<Renderer>().
        //    kocka.instance.gameObject.GetComponent<Renderer>().material.color = szinek[2];

        //}
        //if (gomb.instance != null)
        //{
        //    textm.text += gomb.instance.g;
        //}
        //if (kapszula.instance != null)
        //{
        //    textm.text += kapszula.instance.kk;
        //    kapszula.instance.osszead();
        //}
       
    }
}
