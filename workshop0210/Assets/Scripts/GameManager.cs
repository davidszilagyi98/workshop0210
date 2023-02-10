using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject winFlag;
    public int minCoinsToCollectForWin = 10;
    
    [HideInInspector]
    public bool gameWon = false;

    private List<Coin> coins;
    private int coinsCollected = 0;

    public static GameManager instance;

    // Start is called before the first frame update
    void Awake()
    {
        if(instance == null) {
            instance = this;
        } else {
            Destroy(gameObject);
        }

        if(winFlag != null) {
            winFlag.SetActive(false);
        }
    }

    public void RegisterCoin(Coin coin) {
        if(coins == null) {
            coins = new List<Coin>();
        }
        coins.Add(coin);
    }

    public void RemoveCoin(Coin coin) {
        coins.Remove(coin);
        coinsCollected++;

        if(coins.Count == 0 || coinsCollected == minCoinsToCollectForWin) {
            SpawnWinFlag();
        }
    }

    public int GetCoinsCollected() {
        return coinsCollected;
    }

    private void SpawnWinFlag() {
        if(winFlag != null) {
            if(!winFlag.activeSelf) {
                winFlag.SetActive(true);
            }
        }
    }
}
