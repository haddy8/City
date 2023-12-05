using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMove : MonoBehaviour
{
   private float speedRotate=50.96f;
   public float horizontalAxis;
  public float speed;
  public float verticalAxis;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
      verticalAxis=Input.GetAxis("Vertical");
      transform.Translate (Vector3.forward*Time.deltaTime*speed*verticalAxis);
      horizontalAxis=Input.GetAxis("Horizontal");
      transform.Rotate (Vector3.up*Time.deltaTime*speedRotate*horizontalAxis);
     /* if(Input.GetKey(KeyCode.W))
    {
       transform.Translate (Vector3.forward*Time.deltaTime*speed);
    }
     if(Input.GetKey(KeyCode.S))
    {
       transform.Translate (Vector3.back*Time.deltaTime*speed);
    }
     if(Input.GetKey(KeyCode.D))
    {
       transform.Translate (Vector3.right*Time.deltaTime*speed);
    }
         if(Input.GetKey(KeyCode.A))
    {
       transform.Translate (Vector3.left*Time.deltaTime*speed);
      //transform.position=transform.position+(new Vector3(0, 0, -1)*Time.deltaTime*100);
    }*/
      if(Input.GetKey(KeyCode.E))
    {
       transform.Translate (Vector3.down*Time.deltaTime*speed);
    }
      if(Input.GetKey(KeyCode.Q))
    {
       transform.Translate (Vector3.up*Time.deltaTime*speed);
    }
    }
}
