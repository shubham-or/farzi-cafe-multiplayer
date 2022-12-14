using UnityEngine;

public class GameplayScene : MonoBehaviour
{
    public GameObject[] dishes;
    public GameObject leftDoor, rightDoor;


    public static GameplayScene Instance;
    private void Awake() => Instance = this;

    public Camera mainCamera;

    void Start()
    {
        print("Scene Loaded - " + gameObject.scene.name);
        GameManager.Instance.leftdoor = leftDoor;
        GameManager.Instance.rightdoor = rightDoor;

        GameManager.Instance.cluesManager.dishes = dishes;
    }


}
