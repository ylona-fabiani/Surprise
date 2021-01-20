using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Collectible : MonoBehaviour
{
    public bool aEteCreuser;
    public GameObject coffre;
    public GameObject coffre1;
    public GameObject coffre2;
    //public Object coffre;
    // Start is called before the first frame update
    void Start()
    {
        aEteCreuser = false;
        if (coffre != null && coffre1 != null && coffre2 != null){
        	coffre.SetActive(false);
        	coffre2.SetActive(false);
        	coffre1.SetActive(false);
        }
         
    }

    // Update is called once per frame
    void Update(){
        
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
    	if (coffre != null && coffre1 != null && coffre2 != null){
        	coffre.SetActive(true);
        	coffre2.SetActive(true);
        	coffre1.SetActive(true);
        }
        Destroy(gameObject);
        aEteCreuser=true;
    }

}
