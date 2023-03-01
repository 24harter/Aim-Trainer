using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
	
    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
		transform.Translate(this.transform.forward * -150 * Time.deltaTime);
	}
	void OnCollisionEnter(Collision collision)
	{
		if(collision.gameObject.tag == "Player")
			{
				Destroy(collision.gameObject);
			}
		Destroy(this.gameObject);
	}

	
}
