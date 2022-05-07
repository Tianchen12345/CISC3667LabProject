using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dart : MonoBehaviour
{
    public Transform firePoint;
	public GameObject dartPrefab;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
        	Shoot();
        }
    }
    void Shoot()
    {
    	
    	Instantiate(dartPrefab, firePoint.position, firePoint.rotation);
    
    }
}
