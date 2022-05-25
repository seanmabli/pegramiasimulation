using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planet : MonoBehaviour
{

	public float xSpread = 10;
	public float zSpread = 10;
	public float yOffset = 3;
	public Transform centerPoint;

	public float rotSpeed = 0.5;

	float timer = 0;

    void Update()
    {
		timer += Time.deltaTime * rotSpeed;
		float x = -Mathf.Cos(timer) * xSpread;
		float z = Mathf.Sin(timer) * zSpread;
		Vector3 pos = new Vector3(x, yOffset, z);
		transform.position = pos + centerPoint.position;
    }
}
