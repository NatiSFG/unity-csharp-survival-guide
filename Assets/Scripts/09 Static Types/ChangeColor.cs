using UnityEngine;

public class ChangeColor : MonoBehaviour {

    void Start() {
        Debug.Log("Press the space key to change your color");
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Space))
            ColorUtility.PickAndSetAColorToObject(this.gameObject, Color.red);
    }
}
