using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerForce : MonoBehaviour{
    private CharacterController charController;
    private Vector3 playerVel;
    public float vel = 5f;

    // Start is called before the first frame update
    void Start(){
        charController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update(){
    }

    public void ProMove(Vector2 input){
        Vector3 moveVector = Vector3.zero;
        moveVector.x = input.x;
        moveVector.z = input.y;

        charController.Move(transform.TransformDirection(moveVector) * vel * Time.deltaTime);
    }
    
}

