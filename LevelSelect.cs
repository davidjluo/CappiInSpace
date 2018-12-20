using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSelect : MonoBehaviour {
    public Button level1;
    public GameObject back;
    public Sprite new_background;
	// Use this for initialization
	void Start () {
        level1.onClick.AddListener(Start_level1);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void Start_level1()
    {
        back.GetComponent<SpriteRenderer>().sprite = new_background;
    }
}
