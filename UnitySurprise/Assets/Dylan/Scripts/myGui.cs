using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myGui : MonoBehaviour
{
	static public int score;
	public Texture2D textureToDisplay;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnGUI(){
 		GUI.Label (new Rect(33,8,80,20), score.ToString());
 		GUI.Label(new Rect(3, 0, textureToDisplay.width/8, textureToDisplay.height/8), textureToDisplay);

	}

	public static void increaseScore(){
		score=score+1;
	}

}
