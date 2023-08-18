using UnityEngine;

public class PrimitiveCube : MonoBehaviour {
    private void Update() {
        if (Input.GetKeyDown(KeyCode.Space))
            GameObjectUtility.CreateCubeAndSetPos(this.gameObject, new Vector3(2, 2, 2));
    }
}
