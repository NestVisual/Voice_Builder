using UnityEngine;

public class NestVisual : MonoBehaviour
{
    Vector3 originalPosition;
    public GameObject Shoot1;
    public GameObject Shoot2;
    public GameObject Shoot3;
    public GameObject Shoot4;
    public GameObject Shoot5;
    public GameObject Shoot6;
    public GameObject Shoot7;
    public GameObject Shoot8;
    public GameObject Shoot9;
    public GameObject Shoot10;
    public GameObject Shoot11;
    public GameObject Shoot12;
    public GameObject Shoot13;
    int speed = 2;

    // Use this for initialization
    void Start()
    {
        // Grab the original local position of the sphere when the app starts.
        originalPosition = this.transform.localPosition;
    }

    // Called by GazeGestureManager when the user performs a Select gesture
    void OnSelect()
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

            GameObject obj6 = (GameObject)Instantiate(Shoot6,
            headPosition, Camera.main.transform.rotation);
            obj6.GetComponent<Rigidbody>().velocity = gazeDirection * speed;

            GameObject obj7 = (GameObject)Instantiate(Shoot7,
            headPosition, Camera.main.transform.rotation);
            obj7.GetComponent<Rigidbody>().velocity = gazeDirection * speed;

            GameObject obj8 = (GameObject)Instantiate(Shoot8,
            headPosition, Camera.main.transform.rotation);
            obj8.GetComponent<Rigidbody>().velocity = gazeDirection * speed;

            GameObject obj9 = (GameObject)Instantiate(Shoot9,
            headPosition, Camera.main.transform.rotation);
            obj9.GetComponent<Rigidbody>().velocity = gazeDirection * speed;

            GameObject obj10 = (GameObject)Instantiate(Shoot10,
            headPosition, Camera.main.transform.rotation);
            obj10.GetComponent<Rigidbody>().velocity = gazeDirection * speed;

            GameObject obj11 = (GameObject)Instantiate(Shoot11,
            headPosition, Camera.main.transform.rotation);
            obj11.GetComponent<Rigidbody>().velocity = gazeDirection * speed;

            GameObject obj12 = (GameObject)Instantiate(Shoot12,
            headPosition, Camera.main.transform.rotation);
            obj12.GetComponent<Rigidbody>().velocity = gazeDirection * speed;

            GameObject obj13 = (GameObject)Instantiate(Shoot13,
            headPosition, Camera.main.transform.rotation);
            obj13.GetComponent<Rigidbody>().velocity = gazeDirection * speed;
        }
    }

    // Called by SpeechManager when the user says the "Reset world" command
    void OnReset()
    {
        // If the sphere has a Rigidbody component, remove it to disable physics.
        var rigidbody = this.GetComponent<Rigidbody>();
        if (rigidbody != null)
        {
            DestroyImmediate(rigidbody);
        }

        // Put the sphere back into its original local position.
        this.transform.localPosition = originalPosition;
    }

    // Called by SpeechManager when the user says the "Drop sphere" command
    void OnDrop()
    {
        // Just do the same logic as a Select gesture.
        OnSelect();
    }
}