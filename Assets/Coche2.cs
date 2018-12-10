using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coche2 : MonoBehaviour {

    float velocidad = 0.1f;
    public KeyCode teclaAsignada;
    public GameObject UICanvas;

    // Use this for initialization
    void Start () {
        UICanvas.SetActive(false);


    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(teclaAsignada))
        {
            this.transform.Translate(new Vector3(0, velocidad, 0));

            //Debug.Log("he pulsado");

        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {

        print("colision");
        velocidad = 0f;
        UICanvas.SetActive(true);

    }
}
		
	

