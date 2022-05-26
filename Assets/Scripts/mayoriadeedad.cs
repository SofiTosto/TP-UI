using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mayoriadeedad : MonoBehaviour

{
    // Start is called before the first frame update
     public int edadusu;
     public Text mitexto;

    void Start()
    {
        
        if (edadusu >= 18)
        {
            Debug.Log("Es mayor de edad");
            mitexto.text = "Es mayor de edad";
        }
        else
        {
            Debug.Log("No es mayor de edad");
            mitexto.text = "No es mayor de edad";
        }
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
