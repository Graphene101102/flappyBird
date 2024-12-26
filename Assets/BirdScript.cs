using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public logicScript logic;
    public bool birdIsAlive = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && birdIsAlive) {
             myRigidbody.linearVelocity = Vector2.up * 4 ;
        }
      
        if(transform.position.y > 500 || transform.position.y < -600) {
            logic.gameOver();
            birdIsAlive = false;
        }
    }

    public void OnCollisionEnter2D(Collision2D collision) 
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
