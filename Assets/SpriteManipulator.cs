using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteManipulator : MonoBehaviour {

    Sprite sp;
	// Use this for initialization
	void Start () {
        sp = gameObject.GetComponent<SpriteRenderer>().sprite;
	}
	
	// Update is called once per frame
	void Update () {
        Color[] px = new Color[sp.texture.GetPixels().Length];
        int x = 0;
        foreach (var pixel in sp.texture.GetPixels())
        {
            
            
            px[x] = ChangePixel(pixel);
            x++;
        }
        sp.texture.SetPixels(px);
	}

    Color ChangePixel(Color col)
    {
        col.a = 1;
        return col;
    }
}
