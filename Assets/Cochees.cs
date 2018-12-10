using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cochees : MonoBehaviour {

    float velocidad = 0.1f;
    public KeyCode teclaAsignada;
    public KeyCode teclaAsignada2;
    public GameObject coche1;
    public GameObject coche2;

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
      
        if (Input.GetKeyDown(teclaAsignada))
        {
            coche1.transform.position = coche1.transform.position + new Vector3(0, velocidad, 0);
            //this.transform.Translate(new Vector3(0, velocidad, 0));
            //Debug.Log("he pulsado");
        }

        if (Input.GetKeyDown(teclaAsignada2))
        {
            coche2.transform.position = coche2.transform.position + new Vector3(0, velocidad, 0);
        }
    }
    


    void OnTriggerEnter2D(Collider2D collider)
    {
        print("colision");
        velocidad = 0f;
       

    }
}
		
	

