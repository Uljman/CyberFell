using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    Animator anim;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float hMovement = Input.GetAxis("Horizontal");
        Move(hMovement);
	}

    void Move(float hMov)
    {
        transform.Translate(new Vector3(hMov,0,0));
        anim.SetFloat("Speed",Mathf.Abs(hMov));
        Flip(hMov);
    }

    void Flip(float hMov)
    {
        float x = transform.localScale.x;
        if (hMov < 0 && x > 0)
        {
            x = x * -1;
            transform.localScale = new Vector3(x, transform.localScale.y, transform.localScale.z);
        }
        if (hMov > 0 && x < 0)
        {
            x = x * -1;
            transform.localScale = new Vector3(x, transform.localScale.y, transform.localScale.z);
        }
    }
}
