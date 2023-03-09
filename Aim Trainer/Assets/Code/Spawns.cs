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
	public transform position1;
	public transform position2;
	public transform position3;
	public transform position4;
	public transform position5;
	public transform position6;
	public transform position7;
	public transform position8;
	public transform position9;
	public transform position10;
	public transform position11;
	public transform position12;
	public transform position13;
	public transform position14;
	public transform position15;
	public transform position16;
	public transform position17;
	public transform position18;
	public transform position19;
	public transform position20;
	public transform position21;
	public transform position22;
	public transform position23;
	public transform position24;
	public transform position25;
	public transform position26;
	public transform position27;
	public transform position28;
	public transform position29;
	public transform position30;

	
    // Start is called before the first frame update
    void Start()
    {
        Random.Range(0, 29);
		Instantiate(target, position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	public void spawns()
	{
		GameObject[] spawn = {q, w, e, r, t, y, u, i, o, p, a, s, d, f, g, h, j, k, l, z, x, c, v, b, n, m, qq, ww, ee, rr};

		spawn[q] = position1;
		spawn[w] = position2;
		spawn[e] = position3;
		spawn[r] = position4;
		spawn[t] = position5;
		spawn[y] = position6;
		spawn[u] = position7;
		spawn[i] = position8;
		spawn[o] = position9;
		spawn[p] = position10;
		spawn[a] = position11;
		spawn[s] = position12;
		spawn[d] = position13;
		spawn[f] = position14;
		spawn[g] = position15;
		spawn[h] = position16;
		spawn[j] = position17;
		spawn[k] = position18;
		spawn[l] = position19;
		spawn[z] = position20;
		spawn[x] = position21;
		spawn[c] = position22;
		spawn[v] = position23;
		spawn[b] = position24;
		spawn[n] = position25;
		spawn[m] = position26;
		spawn[qq] = position27;
		spawn[ww] = position28;
		spawn[ee] = position29;
		spawn[rr] = position30;
	}
}
