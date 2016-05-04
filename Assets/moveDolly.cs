using UnityEngine;
using System.Collections;

public class moveDolly : MonoBehaviour {

    public float speed;
    public GameObject cameras;
	// Update is called once per frame
	void Update () {


        cameras.transform.Translate( -1*Input.GetAxis("Vertical") * Time.deltaTime * speed,Input.GetAxis("Horizontal") * Time.deltaTime * speed, 0);

	}
}
