﻿using UnityEngine;

public class PlayerActionControls : MonoBehaviour {
	private GameObject[] limbs;

	void Start() {
		GameObject bearLimbPrefab = Managers.LimbManager.LimbPrefabs[0];

		limbs = new GameObject[4];
		
		limbs[0] = Instantiate(bearLimbPrefab);
		limbs[1] = Instantiate(bearLimbPrefab);
		limbs[2] = Instantiate(bearLimbPrefab);
		limbs[3] = Instantiate(bearLimbPrefab);

		foreach(GameObject limb in limbs) {
			ConfigureLimbInstance(limb);
		}
	}

	void Update () {
		if (Input.GetButtonDown("Action1")) {
			Debug.Log("Action1 button pressed");
			limbs[0].GetComponent<Limb>().Activate();
		}

		if (Input.GetButtonDown("Action2")) {
			Debug.Log("Action2 button pressed");
			limbs[1].GetComponent<Limb>().Activate();
		}

		if (Input.GetButtonDown("Action3")) {
			Debug.Log("Action3 button pressed");
			limbs[2].GetComponent<Limb>().Activate();
		}

		if (Input.GetButtonDown("Action4")) {
			Debug.Log("Action4 button pressed");
			limbs[3].GetComponent<Limb>().Activate();
		}
	}

	private void ConfigureLimbInstance(GameObject limb) {
		limb.transform.SetParent(this.transform);
		limb.transform.localPosition = Vector3.zero;
		limb.transform.localScale = Vector3.one;
	}

}
