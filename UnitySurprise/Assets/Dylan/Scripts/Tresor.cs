using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tresor : MonoBehaviour
{

	public bool aEteCreuser;
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void apparait(){
    	print("adzdfhdb");
    	this.gameObject.SetActive(true);
    	print("adz");
    }
}
