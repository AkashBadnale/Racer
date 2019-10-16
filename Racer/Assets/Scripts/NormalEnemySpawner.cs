using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalEnemySpawner : MonoBehaviour
{
    public GameObject[] enemyCars;
    int enemy;
    public float delayTimer = 3f;
    float timer;
    Vector3 spawnPosition;

    // Start is called before the first frame update
    void Start()
    {
       timer = delayTimer;
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer - Time.deltaTime;
        if(timer <= 0){
            spawnPosition = new Vector3( Random.Range(-2.55f, 2.55f), transform.position.y, transform.position.z );
            enemy = Random.Range(0,4);
            
            //spawn(enemy,1f);
            Instantiate( enemyCars[enemy], spawnPosition, transform.rotation );
            timer = delayTimer;

            Invoke("increaseDelayTimer",40.0f);
            
        }
        
    }
     /** 
    IEnumerator spawn(int num, float delayTime){
        yield return new WaitForSeconds(delayTime);
        Instantiate( enemyCars[num], spawnPosition, transform.rotation );
    }
    */
 
    void increaseDelayTimer(){
        if(delayTimer > 1f ){
           delayTimer = delayTimer - 1f;
        }
    }
    
}
