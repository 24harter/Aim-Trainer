using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : MonoBehaviour
{

	public GameObject bullet;
	public Transform barrel;
	public float bulletSpeed = 150;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
			{
				Instantiate(bullet, barrel.transform.position, barrel.transform.rotation);
				//bullet.GetComponent<Rigidbody>().velocity = transform.up * bulletSpeed;
			}
    }
}
