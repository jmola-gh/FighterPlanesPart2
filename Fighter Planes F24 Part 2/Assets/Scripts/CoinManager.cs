using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class CoinManager : MonoBehaviour
{
    public int coinCount;
    public TextMeshProUGUI CoinText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CoinText.text = coinCount.ToString();
    }
}
