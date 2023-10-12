using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreScript : MonoBehaviour
{
    public TextMeshProUGUI MyscoreText;
    private int ScoreNum;
    void Start()
    {
        ScoreNum = 0;
        MyscoreText.text = "score :" + ScoreNum;
     }

    private void OnTriggerEnter2D(Collider2D coin)
    {
        if(coin.tag == "MyCoin")
        {
            ScoreNum += 10;
            Destroy(coin.gameObject);
            MyscoreText.text = "Score" + ScoreNum;
        }
    }

 
}
