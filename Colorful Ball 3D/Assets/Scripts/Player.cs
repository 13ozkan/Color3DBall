using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody rigidbody;

    [Range(20f, 40f)]

    private Touch touch;
    public int speedModifier;


    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {



        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                rigidbody.velocity = new Vector3(
                     touch.deltaPosition.x * speedModifier * Time.deltaTime,
                     transform.position.y,
                     touch.deltaPosition.y * speedModifier * Time.deltaTime
                     );
            }

            if (touch.phase == TouchPhase.Ended)
            {
                rigidbody.velocity = Vector3.zero;
            }
        }
    }
}
