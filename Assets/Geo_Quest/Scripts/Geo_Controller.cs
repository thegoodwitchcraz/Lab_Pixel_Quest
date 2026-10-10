using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.AI;

public class Geo_Controller : MonoBehaviour {
    int variable1 = 2;
    private string Var2 = "Good Morning ";
    int Var3 = 3;

    private Rigidbody2D rb;
    public int speed = 5;

    // Start is called before the first frame update
    void Start() {
        rb = GetComponent<Rigidbody2D>();
        
        //string Var1 = "World";
        //Debug.Log(Var2 + Var1);
    }
    
    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(xInput * speed, rb.velocity.y);
            /*
            if (Input.GetKeyUp(KeyCode.W))
            {
                transform.position += new Vector3(0, 1, 0);
            }

            if (Input.GetKey(KeyCode.W))
            {
                transform.position += new Vector3(0, 1, 0);
            }

            if (Input.GetKeyDown(KeyCode.S))
            {
                transform.position += new Vector3(0, -1, 0);
            }

            if (Input.GetKey(KeyCode.S))
            {
                transform.position += new Vector3(0, -1, 0);
            }
            */

        }


}
