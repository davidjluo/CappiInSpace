using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuSettingsButton : MonoBehaviour {
    public GameObject menu;
    public GameObject settings;
    public SettingsBackButton back;

    public Button set_button;


	// Use this for initialization
	void Start () {
        set_button.onClick.AddListener(return_set);	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void return_set()
    {
        back.prev = menu;
        settings.SetActive(true);
        menu.SetActive(false);
    }
}
