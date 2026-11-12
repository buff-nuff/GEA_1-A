using UnityEngine;

public class Lesson10 : MonoBehaviour
{
    [ContextMenu("예측 1")]
    void Predict1()
    {
        int hp = 0;
        bool hasShield = true;
        bool isDead = hp <= 0;
        Debug.Log(isDead);
        Debug.Log(isDead && !hasShield);
        Debug.Log(isDead || hasShield);
        Debug.Log(!(hp > 0) == isDead);

    }

    [ContextMenu("쇼트 서킷")]
    void ShortCirouit()
    {
        int total = 100;
        int count = 0;
        if (count != 0 && total / count > 5)
        {
            Debug.Log("평균 5 초과");
        }
        if (count == 0 || total / count > 5)
        {
            Debug.Log("통과");
        }
        bool wrong = total / count > 5 && count != 0;      
    }

    [ContextMenu("판단")]
    void Judge()
    {
        int hp = 20;
        int maxHp = 100;
        bool isStunned = false;
        bool hasPoison = false;

        bool canAttack = hp > 0 && !isStunned;
        bool isDanger = hp <= maxHp / 4 || hasPoison;
        Debug.Log(canAttack);
        Debug.Log(isDanger);
    }

    [ContextMenu("계단")]
    void Stair()
    {
        int height = 3;
        string text = "";
        for (int i = 1; i <= height; i++)
        {
            for (int star = 1; star <= i; star++)
            {
                text +=  "*";
            }
            text += "\n";
        }
        Debug.Log(text);
    }
    [ContextMenu("뒤집힌 계단")]
    void ReverseStair()
    {
        int height = 5;
        string text = "";
        for (int row = height; row >= 0; row--)
        {
            for (int i = 1; i < row; i++)
            {
                text += "*";
            }
            text += "\n";
        }
        Debug.Log(text);
    }
    [ContextMenu("오른쪽 계단")]
    void RightStair()
    {
        int height = 4;
        string text = "";
        for (int row = 1; row <= height; row++)
        {
            int spaceCount = height - row;
            int starCount = row;

            for (int i = 0; i < spaceCount; i++)
            {
                text += " ";
            }
            for (int i = 0; i < starCount; i++)
            {
                text += "*";
            }
            text += "\n";
        }
        Debug.Log(text);

    }

    [ContextMenu("트리")]
    void Tree()
    {
        int height = 4;
        string result = "";
        for (int row = 1; row <= height; row++)
        {
            int spaceCount = height - row;
            int starCount = 2 * row - 1;

            for (int i = 0; i < spaceCount; i++)
            {
                result += " ";
            }
            for (int i = 0; i < starCount; i++)
            {
                result += "*";
            }
            result += "\n";
        }
        Debug.Log(result);
    }

    [ContextMenu("상태")]
    void State()
    {
        int hp = 40;
        string state = "정상";
        if (hp <= 0) state = "사망";
        else if (hp < 50) state = "위험";
        Debug.Log(state);
        int weaponId = 3;
        switch (weaponId)
        {
            case 1: Debug.Log("검"); break;
            case 3: Debug.Log("활"); break;
            default: Debug.Log("맨손"); break;
        }
    }

    [ContextMenu("반복")]
    void Loop()
    {
        int sum = 0;
        for (int i = 2; i <= 10; i += 2)
        {
            sum += i;
        }
        Debug.Log(sum);
        for (int i = 1; i <= 9; i++)
        {
            Debug.Log("3x" + i + "=" + 3 * i);
        }
        
    }
}

