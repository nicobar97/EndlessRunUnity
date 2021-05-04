using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScaler : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {
        //calculate height
        float height = Camera.main.orthographicSize * 2f;
        //calculate width
        float width = height * Screen.width / Screen.height;

        if (gameObject.name == "background"){
        	//GameObject (background) skalieren
        	transform.localScale = new Vector3(width, height, 0);
    	} else 
    		transform.localScale = new Vector3(width + 3f, 2, 0);
    	
    }
}