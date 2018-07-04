using UnityEngine;

public class Love : MonoBehaviour
{
    public GameObject Shoot1;
    public GameObject Shoot2;
    int speed = 2;

    void OnLove()
    {
        // If the sphere has no Rigidbody component, add one to enable physics.
        if (!this.GetComponent<Rigidbody>())
        {
            var headPosition = Camera.main.transform.position;
            Vector3 gazeDirection = Camera.main.transform.forward;

            GameObject obj1 = (GameObject)Instantiate(Shoot1,
            headPosition, Camera.main.transform.rotation);
            obj1.GetComponent<Rigidbody>().velocity = gazeDirection * speed;

            GameObject obj2 = (GameObject)Instantiate(Shoot2,
            headPosition, Camera.main.transform.rotation);
            obj2.GetComponent<Rigidbody>().velocity = gazeDirection * speed;
        }
    }
}