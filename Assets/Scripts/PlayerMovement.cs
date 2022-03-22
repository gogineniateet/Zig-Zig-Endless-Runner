using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Vector3 direction;
    public float playerSpeed;
    TileSpawnManager spawnTile;
    ScoreManager score;

    // Start is called before the first frame update
    void Start()
    {
        spawnTile = GameObject.Find("TileSpawnManager").GetComponent<TileSpawnManager>();
        score = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))           
        {
            //if player moving forward then move him left
            if (direction == Vector3.forward)
            {
                direction = Vector3.left;
            }
            else 
            {
                direction = Vector3.forward;
            }                
        }
        transform.Translate(direction * playerSpeed * Time.deltaTime);
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Tile")
        {
            Destroy(collision.gameObject, 3f);
        }
        
    }

    public void OnTriggerExit(Collider other)
    {
        spawnTile.SpawnTile();
        //if(other.tag == "Player")
        //{
        //    TileSpawnManager.Instance.SpawnTile();

        //}
         //TileSpawnManager.Instance.SpawnTile();
        if (other.gameObject.tag == "Coin")
        {
            score.ScoreUpdate(10);
        }

    }
   



}
