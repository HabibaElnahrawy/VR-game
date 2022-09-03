using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{

    public Text score_text;
    private int score_nb=0;
    public GameObject key;
   // Bulletmov _score;
    // Start is called before the first frame update
    void Start()
    {
       // key.SetActive(false);

        score_nb =0;
        score_text.text="Score:"+score_nb;
       
    }

    // Update is called once per frame
   public void  calculate_Score (int sco)
   {
      
       score_nb +=sco;
       score_text.text="Score:"+score_nb;
        if (score_nb == 25)
        {
            key.SetActive(true);
        }
    }

 
}
