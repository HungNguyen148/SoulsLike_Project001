﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSlotsManager : MonoBehaviour
{
    public DamageCollider weaponDamageCollider;
    public DamageCollider footDamageCollider;

    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void EnableWeaponDamageCollider()
    {
        weaponDamageCollider.EnableCollider();
    }

    public void DisableWeaponDamageCollider()
    {
        weaponDamageCollider.DisableCollider();
    }

    public void EnableAttackCombo()
    {
        animator.SetBool("CanCombo", true);
    }

    public void DisableAttackCombo()
    {
        animator.SetBool("CanCombo", false);
    }

    public void SetHitAnimation(string hitAnimation)
    {
        weaponDamageCollider.SetHitAnimation(hitAnimation);
    }

    public void SetParryAnimation(string parryAnimation)
    {
        weaponDamageCollider.SetParryAnimation(parryAnimation);
    }

    public void SetParriedAnimation(string parriedAnimation)
    {
        weaponDamageCollider.SetParriedAnimation(parriedAnimation);
    }
}
