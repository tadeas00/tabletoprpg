using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : Collidable
{
    // Demage struktura
    public int damagePoint = 1;
    public float pushForce = 2.0f;

    //Update struktura
    public int weaponLevel = 0;
    private SpriteRenderer spriteRenderer;

    protected override void Start()
    {
        base.Start();
        spriteRenderer = GetComponent<SpriteRenderer>();
        
    }
}
