using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
	[SerializeField] Rigidbody2D rigid;
	[SerializeField] int speed=1;
  [SerializeField] bool isFacingRight = true;

    // Start is called before the first frame update
    void Start()
    {
        if (rigid == null)
            rigid = GetComponent<Rigidbody2D>();



    }

    // Update is called once per frame
    void Update()
    {
    	if(isFacingRight){

        transform.Translate(2*Time.deltaTime*speed,2*Time.deltaTime*2f,0);
        		if(transform.position.x>21){
								Flip();


        		}
        }
				if(isFacingRight==false){
					  transform.Translate(2*Time.deltaTime*speed,2*Time.deltaTime*-2f,0);
						if(transform.position.x<-13){
							Flip();
						}
				}


    }
    void FixedUpdate()
    {


    }
    void Flip()
    {

        transform.Rotate(0, 180, 0);

        isFacingRight = !isFacingRight;
    }

}
