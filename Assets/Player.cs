using UnityEngine;
using System.Collections;


public class Player : MonoBehaviour
{

	 public GameObject _PlayerOne;
	public GameObject _PlayerTwo;
	Vector3 g_MoveDir = Vector3.zero;
	float g_MoveSpeed;
	float horizontalSpeed = 2.0f;
	public float speed = 15f;
	public Rigidbody rb;
	Vector3 Inputkey;



    private void Update()
    {


		



    }

    void FixedUpdate()
	{

		C_Move();

		
	}



	void C_Move()
	{
		if(Input.GetKey(KeyCode.A))
		{
			
		_PlayerOne.transform.Translate(Vector3.up * speed * Time.deltaTime);

			//rb.transform.Translate(Vector3.up * speed * Time.deltaTime);


		}

		else if (Input.GetKey(KeyCode.D))
        {
			_PlayerOne.transform.Translate(Vector3.down * speed * Time.deltaTime);
			//rb.transform.Translate(Vector3.down * speed * Time.deltaTime);
		}

		else if (Input.GetKey(KeyCode.LeftArrow))
		{

			_PlayerTwo.transform.Translate(Vector3.up * speed * Time.deltaTime);
		}

		else if (Input.GetKey(KeyCode.RightArrow))
		{

			_PlayerTwo.transform.Translate(Vector3.
				down * speed * Time.deltaTime);
		}




	}
}
