
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMove move;
    public gameover g_over;

    void OnCollisionEnter(Collision collisioninfo){
        if(collisioninfo.collider.tag == "Obstacle"){
            move.enabled = false;
            FindObjectOfType<gameover>().gameOverText.enabled = true;
            FindObjectOfType<GameManager>().Endgame();
        }
        if(FindObjectOfType<GameManager>().gameend == true){
            move.enabled = false;
            FindObjectOfType<gameover>().gameOverText.enabled = true;
        }
    }
}
