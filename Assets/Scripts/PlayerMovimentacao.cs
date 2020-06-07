using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovimentacao : MonoBehaviour
{
    public Text textPontos;
    public float speed = 1f;
    private Rigidbody2D rig;
    int pontos;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump")){
            rig.velocity = Vector2.up * speed;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        pontos++;
        print(pontos);
        textPontos.text = pontos.ToString();
    }
}
