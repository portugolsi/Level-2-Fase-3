using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

public float velocidade; 

public Rigidbody2D corpoPlayer;

public float movHorizontal;

public float movVertical;

public bool estamovimentando;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movHorizontal = Input.GetAxisRaw("Horizontal");
        movVertical = Input.GetAxisRaw("Vertical");
        corpoPlayer.MovePosition(transform.position + new Vector3(movHorizontal,movVertical,0)*velocidade*Time.deltaTime);
    } move();



    void Move () {

    movHorizontal = Input.GetAxisRaw("Horizontal");
    movVertical = Input.GetAxisRaw("Vertical");
    corpoPlayer.MovePosition(transform.position + new Vector3(movHorizontal,movVertical,0)*velocidade*Time.deltaTime);
    
    
    }
}
