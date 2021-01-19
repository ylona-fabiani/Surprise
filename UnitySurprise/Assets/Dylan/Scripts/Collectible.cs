using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    bool aEteCreuser;
    Collectible coffre;
    // Start is called before the first frame update
    void Start()
    {
        aEteCreuser = false;
        if(this.tag == "coffre"){
                this.gameObject.SetActive(true);
            }
        
    }

    // Update is called once per frame
    void Update(){
        if(aEteCreuser){
            print("adz");
            this.gameObject.SetActive(false);}
    }

    void OnTriggerEnter2D(Collider2D target){
    	if(target.gameObject.tag == "Player"){
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
            else if(this.tag == "Pelle"){
                myGui.recuperePelle();
                Destroy(gameObject);
            }
            else if(this.tag == "map"){
                myGui.increaseMap();
                Destroy(gameObject);
            }
            else if(this.tag == "Sable"){
                myGui.afficheCreuser(this);
            }
            else if(this.tag == "map"){
                myGui.increaseMap();
                Destroy(gameObject);
            }

    	}
    }

    public void creuser(){
        Destroy(gameObject);
        aEteCreuser=true;
        
    }
}
