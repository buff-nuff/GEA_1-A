using UnityEngine;
using System.Collections.Generic;

public class Lesson12 : MonoBehaviour
{
    int GetDamage(int attack, int defense)
    {
        int damage = attack - defense;
        if (damage < 1) return 1;
        return damage;
    }

    [ContextMenu("함수")]
    void UseFunction()
    {
        int a = GetDamage(12, 5);
        int b = GetDamage(3, 10);
        int c = GetDamage(20, 4);
        Debug.Log(a + " " + b + " " + c);
    }


    void PrintHp(int hp)
    {
        Debug.Log("HP " + hp);
    }

    int GetHalf(int value)
    {
        return value / 2;
    }

    [ContextMenu("반환")]
    void ReturnTest()
    {
        PrintHp(GetHalf(50));
    }

    [ContextMenu("흩어진 값")]
    void SeparateVariables()
    {
        string[] names = { "슬라임", "고블린" };
        int[] hps = { 30, 50 };
        int[] attacks = { 5, 8 };

        hps[1] -= 20;
        Debug.Log(names[1] + " " + hps[1] + " " + attacks[1]);
    }

    

    [ContextMenu("생성자")]
    void UseConstructor()
    {
        Monster slime = new Monster("슬라임", 30, 5);
        Monster goblin = new Monster("고블린", 50, 8);
        Debug.Log(slime.name + " " + slime.hp);
        Debug.Log(goblin.name + " " + goblin.attack);
    }

}
