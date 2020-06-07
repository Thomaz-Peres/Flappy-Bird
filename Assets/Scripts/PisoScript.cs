using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PisoScript : MonoBehaviour
{
    public float velocidade;
    public float limiteRetornarX;
    public float posicaoRetornarX;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x > limiteRetornarX){
            transform.Translate(-velocidade * Time.deltaTime, 0, 0);
        }
        else{
            //reposiscionando o chao
            transform.position = new Vector2(posicaoRetornarX, transform.position.y);
        }
    }
}
