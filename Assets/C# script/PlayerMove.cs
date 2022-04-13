using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody rb;
    public float Forceapplied = 2000f;
    public float sideways = 500f; 

    public Vector3 positionplayer;
    public Vector3 offset;
    public gameover g_over;

    void start(){
        positionplayer = transform.position;
        g_over.enabled = false;
    }
    void FixedUpdate()
    {
        rb.AddForce(0, 0, Forceapplied * Time.deltaTime);

        if(Input.GetKey("d") && FindObjectOfType<GameManager>().gameend == false){
            rb.AddForce(sideways * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(Input.GetKey("a") && FindObjectOfType<GameManager>().gameend==false){
            rb.AddForce(-sideways * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(rb.position.y < -1f){
            FindObjectOfType<GameManager>().Endgame();
            transform.position = positionplayer + offset;
            rb.velocity = Vector3.zero;
            
        }
    }
}
