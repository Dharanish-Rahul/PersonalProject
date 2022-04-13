using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameover : MonoBehaviour
{   
    public Text gameOverText;

    void Start(){
        gameOverText.enabled = false;
    }
   void Update()
    {
        Debug.Log("Hello");
    }
}
