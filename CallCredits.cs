using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CallCredits : MonoBehaviour {
    public GameObject Orig;
    public GameObject Credits;
    public CreditsBackButton CreditsBack;

    public Button CredButton;
	// Use this for initialization
	void Start () {
        CredButton.onClick.AddListener(CallCredScene);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void CallCredScene()
    {
        Orig.SetActive(false);
        Credits.SetActive(true);
        CreditsBack.prev = Orig;
    }
}
