using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    MovementBehaviour3D _movementBehaviour3D;

    private void Awake()
    {
        _movementBehaviour3D = GetComponent<MovementBehaviour3D>();
    }

    private void Update()
    {
        _movementBehaviour3D.TranslateForwardZ();
    }
}
