using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntanciaPrefab : MonoBehaviour
{
    public GameObject myPrefab;
    public Vector3 position;
    // Start is called before the first frame update
    void Start()
    {
       // myPrefab = Instantiate(Resources.Load("Sphere", typeof(GameObject))) as GameObject;
        int qtd = Random.Range(1, 50);
        Debug.Log(qtd);

        for (int i = 0; i < qtd; i++)
        {

            float x = Random.Range(0.0f, 1.0f);
            float y = Random.Range(1.0f, 10.0f) ;
            float z = Random.Range(1.0f, 3.0f) ;

            position.Set(x, y, z);
            Instantiate(myPrefab, position, Quaternion.identity);
            //Quaternion.identity --> Define que o elemento não sofrerá rotação ao ser instanciado
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
