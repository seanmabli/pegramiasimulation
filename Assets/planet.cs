using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planet : MonoBehaviour {

	float timer = 0;

	public float diameter = 200;

  void Update() {
		timer += 2 / diameter;
		float x = -Mathf.Cos(timer);
		float z = Mathf.Sin(timer);
		transform.Translate(x, 0, z);
  }
}