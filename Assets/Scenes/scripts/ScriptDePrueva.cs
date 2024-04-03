using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptDePrueva : MonoBehaviour
{
    public float vidasPersonaje = 3;
    public float numeroDecimal = 4.5f;
    public string NombrePersonaje = "Mario Vaquerizo";
    public char letra = "a";
    public bool interruptor = false;
    
    
    public int[] arrayNumeros;
    public int[] arrayNumeros2 = new int[6];
    private int[] arrayNumeros3 = {7, 8, 3, 9};
    private string[] arrayStrings = new string[7];
    private string[] arrayStrings2 = {"Dale a tu cuerpo alegria macarena"};

    private int[,] array2Dimensiones = new int[4, 2];
    private int[,] array2Dimensiones = {{7, 8, 65, 0}, {9, 2, 545, 8}};

    public List<string> stringList;
    private List<int> intList = new List<int>(7);
    private List<int> intList2 = new List<int>() {7, 9, 6, 78, 25, 02};

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(arrayNumeros[1]);
        Debug.Log(arrayNumeros[0]);

        Debug.Log(array2Dimensiones[0, 1]);
        array2Dimensiones[2,1] = 777777777;

        arrayNumeros2[0] = 4;
        arrayNumeros2[5] = 7;

        intList2.Add(10);
        intList2.RemoveAt(2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
