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
        Color hue = SpRen.color;
    }

    // Update is called once per frame
    void Update() {

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Color hue = Color.red;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Color hue = Color.blue;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Color hue = Color.white;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            Color hue = Color.green;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            Color hue = Color.white;
        }
    }
}
