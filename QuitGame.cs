using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour {
    public GameOver GG;
    private WaitForSeconds timer = new WaitForSeconds(.2f);

    public void OnTriggerEnter2D(Collider2D other)
    {
        StartCoroutine(CapTurn());
    }

    private IEnumerator CapTurn()
    {
        yield return timer;
        GG.Game_Over();

    }
}
