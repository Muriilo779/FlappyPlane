using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControler : MonoBehaviour
{
    private float timer = 1f;

    [SerializeField] private GameObject obsctacle;
    [SerializeField] private Vector3 posicao;

    [SerializeField] private float spawnMin = 1f;
    [SerializeField] private float spawnMax = 3f;
    //Variavel dos pontos do canvas
    [SerializeField] private Text pontosTexto;
    [SerializeField] private Text levelTexto;
    [SerializeField] private float proximoLevel = 10f;

    private float posicaoMin = -0.4f;
    private float posicaoMax = 2.4f;

    private float pontos = 0f;
    private int level = 1;

    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        Pontos();
        GanhaLevel();
        ObstacleSpawner();

    }

    private void Pontos()
    {
        pontos += Time.deltaTime;

        pontosTexto.text = Mathf.Round(pontos).ToString();
    }

    private void ObstacleSpawner()
    {
        timer -= Time.deltaTime;
        posicao.y = Random.Range(posicaoMin, posicaoMax);
        if (timer <= 0)
        {
            Instantiate(obsctacle, posicao, Quaternion.identity);
            timer = Random.Range(spawnMin, spawnMax);
        }
    }

    private void GanhaLevel()
    {
        if (pontos >= proximoLevel)
        {
            level++;
            proximoLevel *= 2;
        }
        levelTexto.text = level.ToString();
    }

    public int ReturnLevel() { return level; }

}
