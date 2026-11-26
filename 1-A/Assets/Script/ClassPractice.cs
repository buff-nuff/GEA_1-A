using UnityEngine;

public class ClassPractice : MonoBehaviour
{
    [ContextMenu("클래스 실습")]
    void ShowWeapon()
    {
        Weapon weapon = new Weapon("낡은 검", 2);
        for (int i = 0; i < 3; i++)
        {
            if (weapon.Use())
            {
                Debug.Log(weapon.name + " 사용, " + "남은 내구도 " + weapon.durability);
            }
            else
            {
                Debug.Log(weapon.name + " 부서짐");
            }
        }
    }
}
