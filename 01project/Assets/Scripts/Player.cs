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

public Animator anim; // controlador de animações

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        Move();
       
    } 



    void Move () {

    movHorizontal = Input.GetAxisRaw("Horizontal");
    movVertical = Input.GetAxisRaw("Vertical");
    corpoPlayer.MovePosition(transform.position + new Vector3(movHorizontal,movVertical,0)*velocidade*Time.deltaTime);
    Animation();
    Ataque();
    
    }

    void Animation(){

        if (movHorizontal==0 && movVertical==0){
            estamovimentando = false;
        } else{
            estamovimentando = true;
        }


        anim.SetBool("semovimenta",estamovimentando);
        anim.SetFloat("horizontal",movHorizontal);
        anim.SetFloat("vertical",movVertical);


    }

    void Ataque(){
         
         if (Input.GetKeyDown("space")){
            anim.SetTrigger("estaAtacando");
         }

    }


}
