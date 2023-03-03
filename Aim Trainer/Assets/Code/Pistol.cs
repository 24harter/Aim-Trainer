using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : MonoBehaviour
{

	public GameObject bullet;
	public Transform barrel;
	public float bulletSpeed = 150;
	public GameObject rubberduck;
	public bool rubberDuck;
	public float firemode;
    // Start is called before the first frame update
    void Start()
    {
        pistol(0);
		firemode = 0;
    }
	void FixedUpdate()
	{
		if(rubberDuck == true)
		{
		pistol(3);
		}

		if(Input.GetKeyDown(KeyCode.T) && rubberDuck == false)
		{
			rubberDuck = true;
			firemode = 3;
		}
		if(Input.GetKeyDown(KeyCode.T) && rubberDuck == true)
		{
		rubberDuck = false;
		}

	}
    // Update is called once per frame
    void pistol(int x)
    {
		if (x == 0)
		{
			if(Input.GetKeyDown(KeyCode.Mouse0))
			{
				Instantiate(bullet, barrel.transform.position, barrel.transform.rotation);
				//bullet.GetComponent<Rigidbody>().velocity = transform.up * bulletSpeed;
			}
		}
		if (Input.GetKeyDown(KeyCode.X))
		{
			x = 1;
			firemode = 1;
		}
		if (x == 1)
		{
			if(Input.GetKeyDown(KeyCode.Mouse0))
			{
				//Burst Mode, fires three bullets
				Instantiate(bullet, barrel.transform.position, barrel.transform.rotation);
				//bullet.GetComponent<Rigidbody>().velocity = transform.up * bulletSpeed;
				Instantiate(bullet, barrel.transform.position, barrel.transform.rotation);
				Instantiate(bullet, barrel.transform.position, barrel.transform.rotation);
			}
		}
		if (Input.GetKeyDown(KeyCode.X) && x == 1)
		{
			x = 2;
			firemode = 2;
		}
		if (Input.GetKeyDown(KeyCode.X) && x == 2)
		{
			x = 0;
		}
			if (x == 2) 
			{
				
					if (Input.GetKeyDown(KeyCode.P))
					{
						Application.Quit();
					}
			}
		if (x == 3)
		{
			if(Input.GetKeyDown(KeyCode.Mouse0))
			{
				//Burst Mode, fires three bullets
				Instantiate(rubberduck, barrel.transform.position, barrel.transform.rotation);
				//bullet.GetComponent<Rigidbody>().velocity = transform.up * bulletSpeed;
				
			}
		}
		if (Input.GetKeyDown(KeyCode.X) && x == 3)
		{
			x = 0;
			firemode = 0;
		}
    }
	
}
