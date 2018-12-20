using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EmptyReset : MonoBehaviour {
    public bool resetActive;
    public GameObject Data;
    public GameObject Obstacles;


    public Sprite cw_token;
    public Sprite ccw_token;
	// Use this for initialization
	void Start () {
        resetActive = false;
	}
	
	// Update is called once per frame
	void Update () {
 
	}

    public void Reset_Game()
    {
        foreach (Transform child in gameObject.transform)
        {
            if(child.gameObject.GetComponent<SpriteRenderer>().sprite == cw_token)
            {
                child.gameObject.GetComponent<SpriteRenderer>().sprite = null;
                child.gameObject.GetComponent<RotateCW90>().rotate_active = false;
                child.gameObject.GetComponent<CWPlaced>().active = false;
                child.gameObject.GetComponent<Drop>().drop_active = true;                
            }

            if(child.gameObject.GetComponent<SpriteRenderer>().sprite == ccw_token)
            {
                child.gameObject.GetComponent<SpriteRenderer>().sprite = null;
                child.gameObject.GetComponent<RotateCCW>().rotate_active = false;
                child.gameObject.GetComponent<CCWPlaced>().active = false;
                child.gameObject.GetComponent<Drop>().drop_active = true;
            }

        }

        foreach(Transform data in Data.transform)
        {
            data.gameObject.SetActive(true);
        }
        foreach(Transform obs in Obstacles.transform)
        {
            obs.gameObject.SetActive(true);
        }
    }

}
