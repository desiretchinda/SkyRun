using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 7f;

    private bool turnLeft;

    private bool turnRight;

    private CharacterController characterController;

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        turnLeft = Input.GetKeyDown(KeyCode.LeftArrow);
        turnRight = Input.GetKeyDown(KeyCode.RightArrow);

        if (turnLeft)
            transform.Rotate(new Vector3(0, -90, 0));
        else if (turnRight)
            transform.Rotate(new Vector3(0, 90, 0));

        characterController.SimpleMove(new Vector3(0, 0, 0));
        characterController.Move(transform.forward * speed * Time.deltaTime);
    }
}
