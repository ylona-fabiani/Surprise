using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detecteTile : MonoBehaviour
{

	public Rigidbody2D rb;
	public checkTile ct;
	public PlayerMovement pm;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ct.checkIle(rb.position)) {
        	pm.setForme("perso");
            animator.SetBool("perso", true);
        }
        else {
        	pm.setForme("bateau");
            animator.SetBool("perso", false);
        }
    }
}
