using UnityEngine;
using System.Collections;

public class BalkLevelController : MonoBehaviour {
	
	void Start () {
		LoadSceneBackground();
	}

	void Update () {	
	}

	void LoadSceneBackground() {
		Utils.LoadBackground("Background", "back_wooden", new Vector2(0, 0), false);
	}
}

