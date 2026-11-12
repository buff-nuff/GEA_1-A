using UnityEngine;

public class DamagePractice : MonoBehaviour
{
    int attack = 12;
    int defence = 5;
    bool isCritical = false;
    bool targetIsBoss = false;

    [ContextMenu("데미지")]
    void Calc()
    {
        int damage = attack - defence;
        damage = Mathf.Min(damage, 1);
        if (isCritical)
        {
            damage = damage * 2;
        }
        if (targetIsBoss)
        {
            damage = damage / 2;
        }
        Debug.Log(damage);
    }
    
}
