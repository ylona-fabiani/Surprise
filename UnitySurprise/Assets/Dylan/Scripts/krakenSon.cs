using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class krakenSon : MonoBehaviour
{
    private AudioSource AudioSource;
    private bool lancer;
    // Start is called before the first frame update
    void Start()
    {
    	lancer = false;
        AudioSource = GetComponent<AudioSource>();
        AudioSource.Stop();
    }

    // Update is called once per frame
    void Update()
    {
    	if (!lancer && PlayerMovement.level == 3){
    		lancer = true;
    		AudioSource.Play();
    	}

        else if (PlayerMovement.level == 4)
        {
        	AudioSource.Stop();
        }
    }
}
