using UnityEngine;

public class AICarController : MonoBehaviour
{
    public Transform[] waypoints;

    public float speed = 15f;

    int index;

    private void Update()
    {
        if (waypoints.Length == 0)
            return;

        Transform target = waypoints[index];

        transform.position =
            Vector3.MoveTowards(
                transform.position,
                target.position,
                speed * Time.deltaTime);

        transform.LookAt(target);

        if(Vector3.Distance(
            transform.position,
            target.position) < 2f)
        {
            index =
                (index + 1) % waypoints.Length;
        }
    }
}
