using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
    public float force = 1000f;

    private Vector2 startPostition;
    private Vector2 endPosition;

    private Scene sceneMain;
    private PhysicsScene sceneMainPhysic;

    private Scene scenePrediction;
    private PhysicsScene scenePredictionPhysic;

    void Start()
    {
        sceneMain = SceneManager.CreateScene("MainScene");
        sceneMainPhysic = sceneMain.GetPhysicsScene();

        scenePrediction = SceneManager.CreateScene("scenePrediction");
        scenePredictionPhysic = scenePrediction.GetPhysicsScene();


    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            startPostition = GetMousePosition();
        }
        if (Input.GetMouseButtonUp(0)) {
            endPosition = GetMousePosition();
            Vector2 power = startPostition - endPosition;
            GetComponent<Rigidbody>().AddForce(power*force, ForceMode.Force);
            Debug.Log(power);
        }
    }

    private Vector2 GetMousePosition() {
        return Camera.main.ScreenToViewportPoint(Input.mousePosition);
    }

}
