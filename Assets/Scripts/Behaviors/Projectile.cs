using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D),typeof(PolygonCollider2D))]
public class Projectile : MonoBehaviour
{
	// **Data Fields**
	[SerializeField]
	private float lifetime;
	private float expiration;

	// **Properties**
	public float Lifetime { get => lifetime; }

	// **Private Methods**
	private void OnEnable()
	{
		expiration = Time.time + lifetime;
	}

	private void FixedUpdate()
	{
		if (Time.time > expiration)
			GameObject.Destroy(gameObject);
	}
	// **Public Methods**

	// **Events**
}
