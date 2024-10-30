using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public interface IDamagable
{
    void TakePhysicalDamage(int damage);
}
public class PlayerCondition : MonoBehaviour, IDamagable
{
    public UICondition uiCondition;

    Condition hp { get {  return uiCondition.hp; } }
    Condition hunger { get {  return uiCondition.hunger; } }
    Condition stamina { get {  return uiCondition.stamina; } }

    public float noHungerHpDecay;
    public event Action onTakeDamage;
    private void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
       hunger.Subtract(hunger.passiveValue * Time.deltaTime);
       stamina.Add(stamina.passiveValue * Time.deltaTime);

        if(hunger.curValue < 0.0f)
        {
            hp.Subtract(noHungerHpDecay * Time.deltaTime);
        }

        if(hp.curValue <= 0.0f)
        {
            Die();
        }
    }
    public void Heal(float amount)
    {
        hp.Add(amount);
    }
    public void Eat(float amount)
    {
        hunger.Add(amount);
    }
    private void Die()
    {
        Debug.Log("Á×À½");
    }
    public void TakePhysicalDamage(int damage)
    {
        hp.Subtract(damage);
        onTakeDamage?.Invoke();
    }
}
