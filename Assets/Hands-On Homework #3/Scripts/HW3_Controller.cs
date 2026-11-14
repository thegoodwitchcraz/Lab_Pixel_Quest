using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.AI;
using UnityEngine.SceneManagement;

public class HW3_Controller : MonoBehaviour {
    int variable1 = 2;
    private string Var2 = "Good Morning ";
    int Var3 = 3;

    private Rigidbody2D rb2d;
    private SpriteRenderer _spriteRenderer;
    public int speed = 5;

    // Start is called before the first frame update
    public void Start() {
      
        //string Var1 = "World";
        //Debug.Log(Var2 + Var1);
    }

    // Update is called once per frame
    void Update() { }
       

    public string nextScene = "HW3_Scene1";
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        switch (collision.tag)
        {
            case "Death":{
                    string thisLevel = SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene(thisLevel);
                    break;
                }
            case "Finish":{
                    SceneManager.LoadScene(nextScene);                    
                    break;
                }
        }
    }

}
