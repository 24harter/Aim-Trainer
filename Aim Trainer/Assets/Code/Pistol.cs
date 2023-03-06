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
		pistol();
		firemode = 0;
	}

	// Update is called once per frame
	void Update()
	{
		pistol();
	}

	void pistol()
	{
		if (Input.GetKeyDown(KeyCode.Mouse0))
		{
			if (firemode == 0)
			{
				Instantiate(bullet, barrel.transform.position, barrel.transform.rotation);
			}
			else if (firemode == 1)
			{
				Instantiate(bullet, barrel.transform.position, barrel.transform.rotation);
				Instantiate(bullet, barrel.transform.position, barrel.transform.rotation);
				Instantiate(bullet, barrel.transform.position, barrel.transform.rotation);
			}
			else if (firemode == 2)
			{
				if (Input.GetKeyDown(KeyCode.P))
				{
					Application.Quit();
				}
			}
			else if (firemode == 3)
			{
				Instantiate(rubberduck, barrel.transform.position, barrel.transform.rotation);
			}
		}

		if (Input.GetKeyDown(KeyCode.X))
		{
			if (firemode == 2)
			{
				firemode = 0;
			}
			else
			{
				firemode++;
			}
		}

		if (Input.GetKeyDown(KeyCode.T))
		{
			if (rubberDuck)
			{
				rubberDuck = false;
				firemode = 0;
			}
			else
			{
				rubberDuck = true;
				firemode = 3;
			}
		}
	}
}
