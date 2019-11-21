using UnityEngine;
using UnityEngine.UI;

public class Compass : MonoBehaviour
{
    [SerializeField]
    private RectTransform root;

    [SerializeField]
    private Text trueHeading;

    void Start()
    {
        Input.compass.enabled = true;
        Input.location.Start();
    }

    void Update ()
    {
        root.rotation = Quaternion.Euler(0, 0, Input.compass.trueHeading);
        trueHeading.text = ((int)Input.compass.trueHeading) + "°";
    }
}