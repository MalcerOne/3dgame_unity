using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    private PlayerInput inputOfPlayer;
    private PlayerInput.OnFootActions onFootActions;
    private PlayerForce playerForce;

    // Start is called before the first frame update
    void Awake(){
        inputOfPlayer = new PlayerInput();
        onFootActions = inputOfPlayer.OnFoot;
        playerForce = GetComponent<PlayerForce>();
    }

    // Update is called once per frame
    void FixedUpdate(){
        playerForce.ProMove(onFootActions.Movement.ReadValue<Vector2>());
    }

    private void OnFootEnable(){
        onFootActions.Enable();
    }

    private void OnFootDisable(){
        onFootActions.Disable();
    }
}
