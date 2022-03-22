using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileSpawnManager : MonoBehaviour
{
    public GameObject currentTile;
    //public GameObject rightTile;
    //public GameObject forwardTile;
    public GameObject[] tilesPrefab;
    private static TileSpawnManager instance;
     //static TileSpawnManager Instance { get => instance;  }


    //private void Awake()
    //{
    //    if (instance == null)
    //    {
    //        instance = this;
    //    }            
    //}
    public static TileSpawnManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = GameObject.FindObjectOfType<TileSpawnManager>();
            }
            return instance;
        }
    }
        
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            SpawnTile();
        }        
    }
      
    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnTile()
    {
        int index = Random.Range(0, 10);
        if(index == 3)
        {
            currentTile.transform.GetChild(3).gameObject.SetActive(true);
        }
        int k = Random.Range(0, 2);
        //Instantiate(tilesPrefab[k], currentTile.transform.GetChild(k).position, Quaternion.identity);
        currentTile = Instantiate(tilesPrefab[k], currentTile.transform.GetChild(k).position, Quaternion.identity);
    }
       
       
}
