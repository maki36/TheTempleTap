using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MokugyoManager : MonoBehaviour {

	//オブジェクト参照
	public GameObject gameManager;//ゲームマネージャー


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void TapMokugyo(){
		//Debug.Log ("デバッグ");
		gameManager.GetComponent<GameManager> ().CreateNewOrb ();
	}
}
