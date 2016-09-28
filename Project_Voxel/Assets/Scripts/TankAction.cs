using UnityEngine;
using System.Collections;

public class TankAction : BaseMobAction
{
    public GameObject topObj = null;    // 포탑
    public GameObject cannonObj = null; // 포신

    private Vector3 targetPos = Vector3.zero;

	void Start ()
    {
        this.transform.position = spawnPos.transform.position;

        StartCoroutine(ProcessState_WAITING());
	}
    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(spawnPos.transform.position, movingRange);

        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(targetPos, 1f);
    }

    protected override IEnumerator ProcessState_WAITING()
    {
        state = STATE.WAITING;
        float timer = Random.Range(2f, 3f);

        while (true)
        {
            timer -= Time.deltaTime;

            if (timer <= 0f)
                break;

            yield return null;
        }

        StartCoroutine(ProcessState_MOVING());
    }

    protected override IEnumerator ProcessState_MOVING()
    {
        state = STATE.MOVING;
        float timer = Random.Range(6f, 8f);

        Vector3 direction = new Vector3(Random.Range(-1f, 1f), 0f, Random.Range(-1f, 1f));
        direction.Normalize();
        targetPos = spawnPos.transform.position + (direction * movingRange * 0.8f);

        Vector3 v = targetPos - this.transform.position;
        v.y = 0f;
        Quaternion end = Quaternion.LookRotation(v);

        while (true)
        {
            this.transform.Translate(Vector3.forward * Time.deltaTime * speed);
            float step = Time.deltaTime * 50f;
            this.transform.rotation = Quaternion.RotateTowards(this.transform.rotation, end, step);

            float length = Vector3.Distance(spawnPos.transform.position, this.transform.position);
            if (length > movingRange)
                break;

            timer -= Time.deltaTime;
            if (timer < 0f)
                break;

            yield return null;
        }

        StartCoroutine(ProcessState_WAITING());

    }

}
