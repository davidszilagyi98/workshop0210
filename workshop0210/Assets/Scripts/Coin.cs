using UnityEngine;

public class Coin : MonoBehaviour
{
    void Start()
    {
        GameManager gm = GameManager.instance;
        if(gm) {
            gm.RegisterCoin(this);
        }
    }

    void OnDestroy() {
        GameManager gm = GameManager.instance;
        if(gm) {
            gm.RemoveCoin(this);
        }
    }

    void OnTriggerEnter2D(Collider2D coll) {
        if(coll.gameObject.tag.Equals("Player")) {
            Destroy(gameObject);
        }
    }
}
