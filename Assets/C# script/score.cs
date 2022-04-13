using UnityEngine.UI;
using UnityEngine;

public class score : MonoBehaviour
{
    
    public Transform player;
    public Text scoreText;

    void Update()
    {
        
       

        if(FindObjectOfType<GameManager>().gameend == false){
            scoreText.text = player.position.z.ToString("0") ;
            
        }
    }
}
