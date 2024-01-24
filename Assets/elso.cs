using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class elso : MonoBehaviour
{public static elso instance5;
    public string sscsss = "kjhkjkjh";
    public void scene(string x)
    {
        SceneManager.LoadScene(x);
        
    }
    private void Start()
    {
        instance5 = this;
        
    }
    // Start is called before the first frame update

}
