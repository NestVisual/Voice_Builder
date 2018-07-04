using UnityEngine;

public class hello : MonoBehaviour
{
    public GameObject Shoot1;
    public GameObject Shoot2;
    public GameObject Shoot3;
    public GameObject Shoot4;
    public GameObject Shoot5;
    int speed = 2;

    void OnHello()
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

            GameObject obj3 = (GameObject)Instantiate(Shoot3,
            headPosition, Camera.main.transform.rotation);
            obj3.GetComponent<Rigidbody>().velocity = gazeDirection * speed;

            GameObject obj4 = (GameObject)Instantiate(Shoot4,
            headPosition, Camera.main.transform.rotation);
            obj4.GetComponent<Rigidbody>().velocity = gazeDirection * speed;

            GameObject obj5 = (GameObject)Instantiate(Shoot5,
            headPosition, Camera.main.transform.rotation);
            obj5.GetComponent<Rigidbody>().velocity = gazeDirection * speed;
        }
    }
}