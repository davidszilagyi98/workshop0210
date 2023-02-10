using UnityEngine;

public class WinFlag : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D coll) {
        if(coll.gameObject.tag.Equals("Player") && !GameManager.instance.gameWon) {
            Debug.Log("You won the game!");
            GameManager.instance.gameWon = true;
        }
    }
}
