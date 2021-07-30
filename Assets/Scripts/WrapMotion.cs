using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WrapMotion : MonoBehaviour
{
	[SerializeField]
	private SpriteRenderer thisRenderer;


    // Update is called once per frame
    void Update()
    {
        if (!thisRenderer.isVisible)
		{
			// Y Position
			if (gameObject.transform.position.y > 5.1)
			{
				gameObject.transform.position = new Vector2(gameObject.transform.position.x, -5);
			}
			if (gameObject.transform.position.y < -5.1)
			{
				gameObject.transform.position = new Vector2(gameObject.transform.position.x, 5);
			}

			// X Position
			if (gameObject.transform.position.x > 8.5)
			{
				gameObject.transform.position = new Vector2( -8.5f, gameObject.transform.position.y);
			}
			if (gameObject.transform.position.x < -8.5)
			{
				gameObject.transform.position = new Vector2( 8.5f, gameObject.transform.position.y);
			}
		}
	}
}
