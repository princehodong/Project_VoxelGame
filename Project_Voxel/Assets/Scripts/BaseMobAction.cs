using UnityEngine;
using System.Collections;

public class BaseMobAction : MonoBehaviour
{
    public float    movingRange = 5f;           // 이동 반경
    public GameObject  spawnPos = null;    // 생성 위치
    public float speed = 1f;

    protected enum STATE
    {
        NONE,               // 상태 없음
        WAITING,            // 대기 중
        MOVING,             // 이동 중
        ATTACK,             // 공격
        SKILL,              // 스킬
        DIE,                // 사망
        // 이하 상태 이상
        ELECTRIC_SHOCK,     // 감전
        CONFUSION,          // 혼란
        BLAZE,              // 화염
        MAX
    }
    protected STATE state = STATE.NONE;             // 상태

    protected virtual IEnumerator ProcessState_WAITING()
    {
        while (true)
        {
            yield return null;
        }
    }

    protected virtual IEnumerator ProcessState_MOVING()
    {
        while (true)
        {
            yield return null;
        }
    }

    protected virtual IEnumerator ProcessState_ATTACK()
    {
        while (true)
        {
            yield return null;
        }
    }

    protected virtual IEnumerator ProcessState_SKILL()
    {
        while (true)
        {
            yield return null;
        }
    }

    protected virtual IEnumerator ProcessState_DIE()
    {
        while (true)
        {
            yield return null;
        }
    }

    protected virtual IEnumerator ProcessState_ELECTRIC_SHOCK()
    {
        while (true)
        {
            yield return null;
        }
    }

    protected virtual IEnumerator ProcessState_CONFUSION()
    {
        while (true)
        {
            yield return null;
        }
    }

    protected virtual IEnumerator ProcessState_BLAZE()
    {
        while (true)
        {
            yield return null;
        }
    }
}
