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
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D target){
    	print("azdad");
    	if(target.gameObject.tag == "Player"){
    		myGui.increaseScore();
    		Destroy(gameObject);
    	}
    }
}
