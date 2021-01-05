using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPlayerControlledVelocity : MonoBehaviour
{

    public float speed;

    // Update is called once per frame
    void FixedUpdate()
    {
		float horizontal = 0.0f;
		float vertical = 0.0f;
		if (Input.GetAxisRaw("Horizontal") > 0)
		{
			horizontal = Input.GetAxisRaw("Horizontal");
		}

		if (Input.GetAxisRaw("Vertical") > 0)
		{
			vertical = Input.GetAxisRaw("Vertical");
		}


		Vector3 direction = new Vector3(horizontal, 0, vertical);

		gameObject.transform.Translate(direction.normalized * Time.deltaTime * speed);


	}
}
