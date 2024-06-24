using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    public string weaponName = "Default Weapon"; 
    public int damage = 10; 
    public float attackRange = 1.0f; 
    public float attackSpeed = 1.0f; 
    public AnimatorOverrideController weaponAnimator; 
    public GameObject weaponModel; 
    public int durability = 100; 


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
