using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundControl : MonoBehaviour
{
    [SerializeField] private Renderer background;

    private float xOffset = 0f;
    [SerializeField] private float velocidade = 0.1f;
    private Vector2 textureOffset;
    // Start is called before the first frame update
    void Start()
    {
        background = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        xOffset -= Time.deltaTime * velocidade;
        textureOffset.x = xOffset; 
        background.material.mainTextureOffset = textureOffset;

    }
}
