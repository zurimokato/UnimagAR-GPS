using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controlador : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void CargaEntrada(string entrada)
    {
        SceneManager.LoadScene(entrada);
    }
    public void VolverMenu(string menu)
    {
        SceneManager.LoadScene(menu);
    }

    public void LoadVuforiaAR(string vuforia)
    {
        SceneManager.LoadScene(vuforia);
    }
}
