using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    private float morreuX = -3.86f;
    private float morreuY = 5f;
    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        if ((transform.position.x < morreuX) || (transform.position.y > morreuY)){
            Destroy();
        }
    }

    void OnCollisionEnter2D(Collision2D other){
        Destroy();
    }

    void Destroy(){
        Time.timeScale = 0;
        print("Morreu!!!");
        Destroy(gameObject);
    }
}