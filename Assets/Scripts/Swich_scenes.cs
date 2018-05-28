using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Swich_scenes : MonoBehaviour {
	[SerializeField] private string loadLevel;
	void OnTriggerEnter (Collider other){
		if (other.CompareTag ("Player")) {
			SceneManager.LoadScene (loadLevel);
		}
	}
}
