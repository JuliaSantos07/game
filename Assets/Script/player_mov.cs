using System.Collections;
using System.Collections.Generic;
using UnityEngine; //inclui a biblioteca da unity
public class player_mov : MonoBehaviour
{
    float _velocidadeFrente; // cria variavel de velocidade
    float _velocidadeTras;
    float _velocidedeGirar;
    // Start is called before the first frame update
    void Start()
    {
        _velocidadeFrente = 10; // define o valor de cada variavel
        _velocidadeTras = 5;
        _velocidedeGirar = 60;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            transform.Translate(0, 0, (_velocidadeFrente * Time.deltaTime));
        }
        if (Input.GetKey("s"))
        {
            transform.Translate(0, 0, (-_velocidadeTras * Time.deltaTime));
        }
        if (Input.GetKey("a"))
        {
            transform.Rotate(0, (-_velocidedeGirar * Time.deltaTime), 0);
        }
         if (Input.GetKey("d"))
        {
            transform.Rotate(0, (_velocidedeGirar * Time.deltaTime), 0);
        }
    }
}
