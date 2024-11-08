using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{

    public GameObject player;
    public GameObject enemy;
    public GameObject cloud;
    public GameObject coin;
    private int score;
    private int coins;
    public int CoinCount;
   
  

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI CoinText; 
    

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(player, transform.position, Quaternion.identity);
        InvokeRepeating("CreateEnemy", 1f, 3f);
        InvokeRepeating("Createcoin", 1f, 3f);
        CreateSky();
        score = 0;
        scoreText.text = "Score: " + score;
        coins = 0;
        CoinText.text = "Coins:" + CoinCount;
        

   
    }

    // Update is called once per frame
    void Update()
    {
        CoinText.text = CoinCount.ToString();
    }

    void CreateEnemy()
    {
        Instantiate(enemy, new Vector3(Random.Range(-9f, 9f), 7.5f, 0), Quaternion.identity);
    }

    void CreateSky()
    {
        for (int i = 0; i < 30; i++)
        {
            Instantiate(cloud, transform.position, Quaternion.identity);
        }
    }
    void Createcoin()
    {
        Instantiate(coin, new Vector3(Random.Range(-9f, 9f), 7.5f, 0), Quaternion.identity);
    }
    public void EarnScore(int howMuch) 
    {  
        score = score + howMuch;
        scoreText.text = "Score: " + score;
    }
 

}
