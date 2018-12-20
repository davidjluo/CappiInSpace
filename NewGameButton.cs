using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewGameButton : MonoBehaviour {
    public GameObject NewGameCheck;
    public GameObject Level1;
    public GameObject Menu_background;
    public GameObject Game_background;
    public Button NewButton;

    public UpdateLevelSelect UpdateLevel;
    // Use this for initialization
    void Start () {
        NewButton.onClick.AddListener(StartNew);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void StartNew()
    {
        Level1.SetActive(true);
        Level1.GetComponent<LevelReset1>().GameReset();
        Menu_background.SetActive(false);
        Game_background.SetActive(true);
        NewGameCheck.SetActive(false);
        UpdateLevel.ResetLevels();
    }
}
