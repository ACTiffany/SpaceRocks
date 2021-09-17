using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WrapMotion : MonoBehaviour
{
	[SerializeField]
	private SpriteRenderer thisRenderer;

	private Camera mainCamera;

	private bool isWrappingX = false;
	private bool isWrappingY = false;


	private void OnEnable()
	{
		mainCamera = Camera.main;
	}

	private void FixedUpdate()
    {
		if (thisRenderer.isVisible)
		{
			isWrappingX = false;
			isWrappingY = false;
		}

        else
		{
			Vector2 viewportPosition = mainCamera.WorldToViewportPoint(gameObject.transform.position);
			Vector2 newWorldPosition = gameObject.transform.position;

			if (!isWrappingX 
				&&(viewportPosition.x > 1 || viewportPosition.x < 0))
			{
				Debug.Log(gameObject.name + " -> Wrap X");

				newWorldPosition.x = -newWorldPosition.x;
				isWrappingX = true;
			}

			if (!isWrappingY
				&& (viewportPosition.y > 1 || viewportPosition.y < 0))
			{
				Debug.Log(gameObject.name + " -> Wrap y");

				newWorldPosition.y = -newWorldPosition.y;
				isWrappingY = true;
			}

			gameObject.transform.position = newWorldPosition;
		}
	}
}
