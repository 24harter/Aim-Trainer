using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawns : MonoBehaviour
{
	public static var q;
	public static var w;
	public static var e;
	public static var r;
	public static var t;
	public static var y;
	public static var u;
	public static var i;
	public static var o;
	public static var p;
	public static var a;
	public static var s;
	public static var d;
	public static var f;
	public static var g;
	public static var h;
	public static var j;
	public static var k;
	public static var l;
	public static var z;
	public static var x;
	public static var c;
	public static var v;
	public static var b;
	public static var n;
	public static var m;
	public static var qq;
	public static var ww;
	public static var ee;
	public static var rr;
	

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

		spawn[0] = var q;
		spawn[1] = var w;
		spawn[2] = var e;
		spawn[3] = var r;
		spawn[4] = var t;
		spawn[5] = var y;
		spawn[6] = var u;
		spawn[7] = var i;
		spawn[8] = var o;
		spawn[9] = var p;
		spawn[10] = var a;
		spawn[11] = var s;
		spawn[12] = var d;
		spawn[13] = var f;
		spawn[14] = var g;
		spawn[15] = var h;
		spawn[16] = var j;
		spawn[17] = var k;
		spawn[18] = var l;
		spawn[19] = var z;
		spawn[20] = var x;
		spawn[21] = var c;
		spawn[22] = var v;
		spawn[23] = var b;
		spawn[24] = var n;
		spawn[25] = var m;
		spawn[26] = var qq;
		spawn[27] = var ww;
		spawn[28] = var ee;
		spawn[29] = var rr;
	}
}
