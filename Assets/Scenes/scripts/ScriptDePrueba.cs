using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptDePrueba : MonoBehaviour
{
    public int numeroentero = 5;
    public int numerovida = 100;
    public float numeroDecimal = 4.62f;
    public string nombrepersonaje = "Chiquilicuatre";
    public bool variable_interuuptor_verdaderoofalso = false;
    // Start is called before the first frame update
    void Start()
    {
        numeroentero = 10;

        int suma = numeroentero + numerovida;
        Debug.Log(suma);
        string sumatextos = nombrepersonaje + " 1, el breakingdance, 2, el cruzaito";
        Debug.Log(sumatextos);

        Debug.Log(nombrepersonaje);
        Debug.Log(numeroentero);
        Debug.Log(numeroDecimal);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
