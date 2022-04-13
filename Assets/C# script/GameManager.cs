using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{   
    public bool gameend;
    public void Endgame(){
        
        if(gameend == false){
            Debug.Log("GameOver\n");
            gameend=true;
        }

    }
    void Update(){
        if(gameend == true){
            if(Input.GetKey(KeyCode.Space)){
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
