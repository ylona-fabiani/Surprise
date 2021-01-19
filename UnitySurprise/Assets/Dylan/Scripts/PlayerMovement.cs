using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public Animator animator;

    public float vitesse_bateau;
    public float vitesse_perso;
    public string forme;
    public int level;

    private float xglisse;
    private float yglisse;


    void Start(){

    }

    void Update()
    {

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
            	else {
            		rb.rotation = 270;
            	}



		        if(level > 0)
		        {
		        	animator.SetInteger("level", level);
		        	animator.SetFloat("speed", Mathf.Abs(xglisse)+Mathf.Abs(yglisse));
		        }

		        rb.velocity = new Vector2(xglisse, yglisse) * vitesse_perso;
	        	break;


            default :
                rb.velocity = new Vector2(xmove, ymove) * vitesse_perso;
                break;
        }
    }
}