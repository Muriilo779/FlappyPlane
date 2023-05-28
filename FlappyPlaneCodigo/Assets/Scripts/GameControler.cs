using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControler : MonoBehaviour
{
    private float timer = 1f;

    [SerializeField] private GameObject obsctacle;
    [SerializeField] private Vector3 posicao;

    [SerializeField] private float spawnMin = 1f;
    [SerializeField] private float spawnMax = 3f;

    private float posicaoMin = -0.4f;
    private float posicaoMax = 2.4f;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        posicao.y = Random.Range(posicaoMin, posicaoMax);
        if(timer <= 0)
        {
            Instantiate(obsctacle, posicao, Quaternion.identity);
            timer = Random.Range(spawnMin, spawnMax);
        }
        
    }
    //Dando oi a cada 1 segundo 
}
