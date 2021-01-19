using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){}

    void OnTriggerEnter2D(Collider2D target){
    	if(target.gameObject.tag == "Player"){
            print("player");
            if(this.tag == "Planches"){
    		  myGui.increaseNombrePlanches();
    		  Destroy(gameObject);}
            else if(this.tag == "Tissus"){
                myGui.increaseNombreTissus();
                Destroy(gameObject);
            }
            else if(this.tag == "Cailloux"){
                myGui.increaseNombreCailloux();
                Destroy(gameObject);
            }

    	}
    }
}
