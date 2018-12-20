using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CallCinematics : MonoBehaviour {
    public GameObject Orig;
    public GameObject Cinematics;
    public cutscene_1 CutScene;
    

    public Button Set_Button;
	// Use this for initialization
	void Start () {
        Set_Button.onClick.AddListener(Call_Cred);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void Call_Cred()
    {
        Orig.SetActive(false);
        Cinematics.SetActive(true);
        CutScene.CutScene_active = true;
    }
}
