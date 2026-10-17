using System.Collections;
using System.Collections.Generic;
using System.Net.Security;
using Unity.VisualScripting;
using UnityEngine;


public class NewBehaviourScript : MonoBehaviour {

    private SpriteRenderer SpRen;
    
    // Start is called before the first frame update
    void Start() {
        SpRen = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update() {

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SpRen.color = Color.red;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SpRen.color = Color.blue;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SpRen.color = Color.cyan;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            SpRen.color = Color.green;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            SpRen.color = Color.white;
        }
    }
}
