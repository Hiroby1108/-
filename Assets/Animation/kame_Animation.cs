using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kame_Animation : MonoBehaviour
{
    // Start is called before the first frame update
	Animation anim;

	// Use this for initialization
	void Start () {
		anim = this.gameObject.GetComponent<Animation> ();


	}

	// Update is called once per frame
	void Update () {
		anim.CrossFade("Take 001",0);

		}


}
