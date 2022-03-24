using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileScript : MonoBehaviour
{
    Rigidbody rb;
   
    void Start()
    {
        rb = gameObject.GetComponentInParent<Rigidbody>();
    }


    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            TileSpawnManager.Instance.SpawnTile();
            StartCoroutine(FallDown());
        }  
    }

    IEnumerator FallDown()
    {
        yield return new WaitForSeconds(0.5f);
        rb.isKinematic = true;
        yield return new WaitForSeconds(2f);
        rb.isKinematic = false;
        if(TileSpawnManager.Instance.name == "RightTile")
        {            
            TileSpawnManager.Instance.BackToRightPool(gameObject);
        }
        if (TileSpawnManager.Instance.name == "ForwardTile")
        {
            TileSpawnManager.Instance.BackToForwardPool(gameObject);
        }

    }

}
