using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    Animator anim;
	// Use this for initialization
	void Start () {
        // may be changer for "graphics" later
        anim = transform.Find("Sprite").GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        float hMovement = Input.GetAxis("Horizontal");
        float yMovement = Input.GetAxis("Vertical");
        Move(hMovement, yMovement);
	}

    void Move(float hMov, float yMov)
    {
        transform.Translate(new Vector3(hMov, yMov, 0) * 0.1f * Time.deltaTime * 10);
        anim.SetFloat("Speed", Mathf.Abs(hMov) * 0.1f);
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
