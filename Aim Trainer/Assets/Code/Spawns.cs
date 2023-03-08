using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawns : MonoBehaviour
{
	public static GameObject q;
	public static GameObject w;
	public static GameObject e;
	public static GameObject r;
	public static GameObject t;
	public static GameObject y;
	public static GameObject u;
	public static GameObject i;
	public static GameObject o;
	public static GameObject p;
	public static GameObject a;
	public static GameObject s;
	public static GameObject d;
	public static GameObject f;
	public static GameObject g;
	public static GameObject h;
	public static GameObject j;
	public static GameObject k;
	public static GameObject l;
	public static GameObject z;
	public static GameObject x;
	public static GameObject c;
	public static GameObject v;
	public static GameObject b;
	public static GameObject n;
	public static GameObject m;
	public static GameObject qq;
	public static GameObject ww;
	public static GameObject ee;
	public static GameObject rr;
	public GameObject spawner;
	public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(target, spawns.Range(0, 29), spawner.transform.position, spawner.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	public void spawns()
	{
		int[] spawn = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30};

		spawn[0] = q;
		spawn[1] = w;
		spawn[2] = e;
		spawn[3] = r;
		spawn[4] = t;
		spawn[5] = y;
		spawn[6] = u;
		spawn[7] = i;
		spawn[8] = o;
		spawn[9] = p;
		spawn[10] = a;
		spawn[11] = s;
		spawn[12] = d;
		spawn[13] = f;
		spawn[14] = g;
		spawn[15] = h;
		spawn[16] = j;
		spawn[17] = k;
		spawn[18] = l;
		spawn[19] = z;
		spawn[20] = x;
		spawn[21] = c;
		spawn[22] = v;
		spawn[23] = b;
		spawn[24] = n;
		spawn[25] = m;
		spawn[26] = qq;
		spawn[27] = ww;
		spawn[28] = ee;
		spawn[29] = rr;
	}
}
