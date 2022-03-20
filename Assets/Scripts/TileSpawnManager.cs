using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileSpawnManager : MonoBehaviour
{
    public GameObject currentTile;
    public GameObject rightTile;
    public GameObject forwardTile;
    public GameObject[] tilesPrefab;


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 30; i++)
        {
            int k = Random.Range(0, 2);
            Instantiate(tilesPrefab[k], currentTile.transform.GetChild(k).position, Quaternion.identity);
            currentTile = Instantiate(tilesPrefab[k], currentTile.transform.GetChild(k).position, Quaternion.identity);
        }
    }
        
    // Update is called once per frame
    void Update()
    {
        
    }
}
