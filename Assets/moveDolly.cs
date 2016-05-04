using UnityEngine;
using System.Collections;

public class moveDolly : MonoBehaviour {

    public float speed;
	
	// Update is called once per frame
	void Update () {


        transform.Translate( -1*Input.GetAxis("Vertical") * Time.deltaTime * speed,Input.GetAxis("Horizontal") * Time.deltaTime * speed, 0);

	}
}
