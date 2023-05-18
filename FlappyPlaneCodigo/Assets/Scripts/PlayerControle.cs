using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControle : MonoBehaviour
{
    [SerializeField] private Rigidbody2D meuRigid;
    // Start is called before the first frame update
    void Start()
    {
        //Pegando meu rigidBody
        meuRigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
