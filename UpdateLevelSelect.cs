using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateLevelSelect : MonoBehaviour {
    public GameObject WorldSelect;
    public LevelManager Manager;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Update_Levels(int Score, int level)
    {
        int i = 0;

        foreach(Transform puzzle in WorldSelect.transform)
        {
            if(i == level)
            {
                int j;
                for(j=0; j<Score; j++)
                {
                    puzzle.gameObject.transform.GetChild(1).GetChild(3+j).gameObject.SetActive(true);
                }
                Manager.Level_Array[level + 1] = 1;
            }
            if(i == level + 1)
            {
                puzzle.gameObject.GetComponent<Button>().interactable = true;
            }
            i++;
        }
    }
    public void ResetLevels()
    {
        Manager.Level_Array[2] = 0;
        Manager.Level_Array[1] = 0;
        int t=0;
        foreach (Transform puzzle in WorldSelect.transform)
        {
            int j;
            for (j = 0; j < 3; j++)
            {
                
                puzzle.gameObject.transform.GetChild(1).GetChild(3 + j).gameObject.SetActive(false);
            }
            if (t != 0)
            {
                puzzle.gameObject.GetComponent<Button>().interactable = false;
            }
            t++;
        }
    }
}
