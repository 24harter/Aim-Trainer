using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawns : MonoBehaviour
{
    public GameObject[] spawnObjects;
    public Transform[] positions;

    public GameObject targetPrefab;
    public Transform targetParent;

    // Start is called before the first frame update
    void Start()
    {
        int randomIndex = Random.Range(0, spawnObjects.Length);
        GameObject spawnObject = spawnObjects[randomIndex];
        Transform position = positions[randomIndex];
        Instantiate(targetPrefab, position.position, Quaternion.identity, targetParent);
		spawnObjects = new GameObject[30];
		spawnObjects[0] = GameObject.Find("Spawn1");
		spawnObjects[1] = GameObject.Find("Spawn2");
		spawnObjects[2] = GameObject.Find("Spawn3");
		spawnObjects[3] = GameObject.Find("Spawn4");
		spawnObjects[4] = GameObject.Find("Spawn5");
		spawnObjects[5] = GameObject.Find("Spawn6");
		spawnObjects[6] = GameObject.Find("Spawn7");
		spawnObjects[7] = GameObject.Find("Spawn8");
		spawnObjects[8] = GameObject.Find("Spawn9");
		spawnObjects[9] = GameObject.Find("Spawn10");
		spawnObjects[10] = GameObject.Find("Spawn11");
		spawnObjects[11] = GameObject.Find("Spawn12");
		spawnObjects[12] = GameObject.Find("Spawn13");
		spawnObjects[13] = GameObject.Find("Spawn14");
		spawnObjects[14] = GameObject.Find("Spawn15");
		spawnObjects[15] = GameObject.Find("Spawn16");
		spawnObjects[16] = GameObject.Find("Spawn17");
		spawnObjects[17] = GameObject.Find("Spawn18");
		spawnObjects[18] = GameObject.Find("Spawn19");
		spawnObjects[19] = GameObject.Find("Spawn20");
		spawnObjects[20] = GameObject.Find("Spawn21");
		spawnObjects[21] = GameObject.Find("Spawn22");
		spawnObjects[22] = GameObject.Find("Spawn23");
		spawnObjects[23] = GameObject.Find("Spawn24");
		spawnObjects[24] = GameObject.Find("Spawn25");
		spawnObjects[25] = GameObject.Find("Spawn26");
		spawnObjects[26] = GameObject.Find("Spawn27");
		spawnObjects[27] = GameObject.Find("Spawn28");
		spawnObjects[28] = GameObject.Find("Spawn29");
		spawnObjects[29] = GameObject.Find("Spawn30");
    }
}
