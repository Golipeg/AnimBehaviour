using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    private static readonly int MoveForward = Animator.StringToHash("MoveForward");
    private static readonly int MoveBack = Animator.StringToHash("MoveBack");
    private static readonly int Jab = Animator.StringToHash("Jab");
    private static readonly int Hook = Animator.StringToHash("Hook");

    public void MoveForwardAnim()
    {
        _animator.SetTrigger(MoveForward);
    }

    public void MoveBackAnim()
    {
        _animator.SetTrigger(MoveBack);
    }

    public void PunchAnim()
    {
        _animator.SetTrigger(Jab);
    }

    public void HitHookAnim()
    {
        _animator.SetTrigger(Hook);
    }
}