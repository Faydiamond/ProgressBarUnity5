using UnityEngine;
using System.Collections;
using UnityEngine.UI;
//administrador de escenas
using UnityEngine.SceneManagement;

public class PreLoader : MonoBehaviour {

	public Transform Carga;
	public Transform TextIndicador;
	public Transform TextCargar;

	[SerializeField] private float Cantidad;
	[SerializeField] private float Velocidad;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Cantidad < 100) {
			Cantidad += Velocidad * Time.deltaTime;
			TextIndicador.GetComponent<Text> ().text = ((int)Cantidad).ToString () + "%";
			TextCargar.gameObject.SetActive (true);
		} else {
			TextCargar.gameObject.SetActive (false);
			TextIndicador.GetComponent<Text>().text="Ya!";
			SceneManager.LoadScene ("EscenaDos");
		}

		Carga.GetComponent<Image> ().fillAmount = Cantidad / 100;
}
}