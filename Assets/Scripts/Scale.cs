using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour
{
    //instancia a classe Vector que possibilita manipular as dimensões
    public Vector3 scaleChange;
    
   
    


    // Start é chamado antes da atualização do primeiro frame
    void Start()
    {
        float x = Random.Range(0.0f, 1.0f)/10.0f;
        float y = Random.Range(0.0f, 1.0f) / 10.0f;
        float z = Random.Range(0.0f, 1.0f) / 10.0f;
        scaleChange.Set(x, y, z);
        
       
       

    }

    // Update é chamado a cada atualização de frame
    void Update()
    {
        transform.localScale += scaleChange;
        
       
    }
}
