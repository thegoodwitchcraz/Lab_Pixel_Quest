using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.AI;

public class Geo_Controller : MonoBehaviour {
    private string Var2 = "Good Morning ";
    int Var3 = 3;

    // Start is called before the first frame update
    void Start()
    {
        string Var1 = "World";
        Debug.Log(Var2 + Var1);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.W))
        {
            transform.position += new Vector3(0, 1, 0);
        }

    }
}
