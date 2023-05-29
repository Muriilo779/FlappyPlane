using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacelControl : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float velocidade = 4f;
    [SerializeField] private GameObject eu;
    [SerializeField] private GameControler game;
    void Start()
    {
        Destroy(eu, 5f);

        game = FindObjectOfType<GameControler>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * Time.deltaTime * (velocidade + game.ReturnLevel());
    }
}
