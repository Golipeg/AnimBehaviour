using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class FighterController : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    private static readonly int MoveForward = Animator.StringToHash("MoveForward");
    private static readonly int Hit = Animator.StringToHash("hit");
    private static readonly int RandomHit = Animator.StringToHash("randomHit");
    private static readonly int MoveBack = Animator.StringToHash("MoveBack");
    private static readonly int PlayerIsIdler = Animator.StringToHash("playerIsIdler");


    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }
    private void Update()
    {
        bool playerIsIdler = true;
        
        
        if (Input.GetKey(KeyCode.W))
        {
            _animator.SetTrigger(MoveForward);
            gameObject.transform.position += Vector3.forward * Time.deltaTime;
            playerIsIdler = false;
        }

        if (Input.GetKey(KeyCode.S))
        {
            _animator.SetTrigger(MoveBack);
            gameObject.transform.position += Vector3.back * Time.deltaTime;
            playerIsIdler = false;
        }
        
        if (Input.GetMouseButtonDown(0))
        {
            _animator.SetTrigger(Hit);
            _animator.SetFloat(RandomHit, Random.value);
        }
        _animator.SetBool(PlayerIsIdler,playerIsIdler);
        
    }
}