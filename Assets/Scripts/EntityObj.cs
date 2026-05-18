using UnityEngine;

public class EntityObj : MonoBehaviour
{
    public GameObject Target;
    public float Speed;
    public float distance;

    public float radius;

    void Start()
    {

    }
    void Update()
    {
        distance = Vector3.Distance(Target.transform.position, transform.position);
        if(distance < radius)
        {
            Vector3 dir = (Target.transform.position - transform.position).normalized;

            transform.position +=  dir * Speed * Time.deltaTime;
        }

        
    }

}
