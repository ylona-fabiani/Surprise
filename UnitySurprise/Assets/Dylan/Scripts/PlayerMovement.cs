﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public Animator animator;

    public float vitesse_bateau;
    public float vitesse_perso;
    public string forme;
    public static int level;

    private float xglisse;
    private float yglisse;


    public GameObject wall1;
    public GameObject wall2;
    public GameObject wall3;
    public GameObject wall4;


    void Start(){

    }

    void Update()
    {
        SoundEffectsHelper.Instance.MakePlayerShotSound();
        float xmove = Input.GetAxisRaw("Horizontal");
        float ymove = Input.GetAxisRaw("Vertical");

        if (xmove != 0 || ymove != 0){
        	xglisse = xmove;
        	yglisse = ymove;
        }

        

        switch(forme){

        	case "bateau":

        		if(yglisse == 1 && xglisse == 1){
        			rb.rotation = 315;
            	}
            	else if (yglisse == 1 && xglisse == -1){
            		rb.rotation = 45;
            	}
            	else if (yglisse == -1 && xglisse == 1){
            		rb.rotation = 225;
            	}
            	else if (yglisse == -1 && xglisse == -1){
            		rb.rotation = 135;
            	}
            	else if(yglisse == 1){
            		rb.rotation = 0;
            	}
            	else if (yglisse == -1){
            		rb.rotation = 180;
            	}
            	else if (xglisse == -1){
            		rb.rotation = 90;
            	}
            	else if (xglisse == 1) {
            		rb.rotation = 270;
            	}

            	if(Input.GetKeyDown("space")){
		        	xglisse = 0;
		        	yglisse = 0;
		        }



		        if(level > 0)
		        {
		        	enlever_wall(level);
		        	animator.SetInteger("level", level);
		        	animator.SetFloat("speed", Mathf.Abs(xglisse)+Mathf.Abs(yglisse));
		        }


		        if(level == 1){
		        	rb.velocity = new Vector2(xglisse, yglisse) * vitesse_bateau;
		        }
		        else if(level == 2){
		        	rb.velocity = new Vector2(xglisse, yglisse) * vitesse_bateau*1.2f;
		        }
		        else if(level == 3){
		        	rb.velocity = new Vector2(xglisse, yglisse) * vitesse_bateau*2.1f;
		        }
		        else if(level == 4){
		        	rb.velocity = new Vector2(xglisse, yglisse) * vitesse_bateau*2f;
		        }

	        	break;


            default :
            	rb.rotation = 0;
                rb.velocity = new Vector2(xmove, ymove) * vitesse_perso;
                animator.SetInteger("level", level);
		        animator.SetFloat("speed", Mathf.Abs(xglisse)+Mathf.Abs(yglisse));
		        animator.SetBool("perso", true);
		        animator.SetFloat("xspeed", xmove);
		        animator.SetFloat("yspeed", ymove);
                enlever_wall(level);
                break;
        }
    }

    public void enlever_wall(int lvl){
    	Destroy(GameObject.Find(string.Format("wall{0}",lvl)));
    }

    

    public void setForme(string f) {
    	forme = f;
    }


    public static void increaseLevel(){
    	level++;
    }
}