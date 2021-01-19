using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class checkTile : MonoBehaviour
{

	public Tilemap tm; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public bool checkIle(Vector2 pos) {
    	Vector3Int v3pos = new Vector3Int((int)pos.x, (int)pos.y, 0);
    	return tm.HasTile(v3pos);
    }
}
