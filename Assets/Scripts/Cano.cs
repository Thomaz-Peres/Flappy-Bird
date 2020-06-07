using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cano : MonoBehaviour
{
    public float velocidade;
    public float limiteRetornarX;
    public float posicaoRetornarX;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > limiteRetornarX)
        {
            transform.Translate(-velocidade * Time.deltaTime, 0, 0);
        }
        else
        {
            //reposiscionando o chao
            transform.position = new Vector2(posicaoRetornarX, Random.Range(2.70f, -1.4f));
        }        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        GetComponent<AudioSource>().Play();
    }    
}
