using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerControl : MonoBehaviour
{
    private Rigidbody2D meuRigid;
    [SerializeField] private float velocidade = 5f;
    void Start()
    {
        //Pegando meu rigidBody
        meuRigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Subir();

        LimitandoVelocidade();
    }

    private void Subir()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Fazendo a velocidade do RB ir para cima
            meuRigid.velocity = Vector2.up * velocidade;
        }
    }

    private void LimitandoVelocidade()
    {
        if (meuRigid.velocity.y <= -5)
        {
            meuRigid.velocity = Vector2.down * velocidade;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Oiii");
        SceneManager.LoadScene("Jogo");
    }
}
