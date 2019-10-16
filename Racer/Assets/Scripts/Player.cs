using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float playerSpeed;
    Vector3 position;
    //public Animation end;
    public GameObject blast;

    // Start is called before the first frame update
    void Start()
    {
        position = transform.position;
        //end = GetComponent<Animation> ();
    }

    // Update is called once per frame
    void Update(){

        /** 
         if (Input.touchCount == 1) {

         Touch touch = Input.touches[0];
         if(touch.position.x < Screen.width/2){
             transform.position += Vector3.left * playerSpeed * Time.deltaTime;


         }
         else if(touch.position.x > Screen.width/2){
             transform.position += Vector3.right * playerSpeed * Time.deltaTime;

         }
        Vector3 position = transform.position;
        */

        // to make the player move around x-axis
        //position.x = position.x + Input.GetAxis("Horizontal") * playerSpeed * Time.deltaTime;
        //transform.position = position;

        // to avoid the player moving out of the screen
        //position.x = Mathf.Clamp(position.x, -2.52f, 2.58f);

        if (Input.touchCount > 0){
        Touch touch = Input.GetTouch(0);

        int direction = (touch.position.x > (Screen.width / 2)) ? 1 : -1;
        movePlayer(direction);
    }
        
        
    }

    void OnCollisionEnter2D(Collision2D col){
        if(col.gameObject.tag == "enemy"){
            Instantiate( blast, transform.position, transform.rotation);
            //end.Play("death");
            Destroy(gameObject);
            //Application.LoadLevel("gameover");
            SceneManager.LoadScene("gameover");
        }
    }

    public void moveRight(){
        if( transform.position.x <= 2.55f )
            transform.position += Vector3.right * playerSpeed * Time.deltaTime;
    }

    public void moveLeft(){
        if( transform.position.x >= -2.50f )
            transform.position += Vector3.left * playerSpeed * Time.deltaTime;
    }

   void movePlayer(int direction){
      float xPos = transform.position.x + (direction * Time.deltaTime * playerSpeed);
      position = new Vector3 (Mathf.Clamp (xPos, -2.50f, 2.55f), transform.position.y, transform.position.z);
      transform.position = position;
   }
}
