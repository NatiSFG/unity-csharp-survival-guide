using UnityEngine;

public class DeclaringProperties2 : MonoBehaviour {
    DeclaringProperties properties;

    private void Start() {
        properties = GetComponent<DeclaringProperties>();
        Debug.Log(properties.Speed);

        Debug.Log(properties.Name);
    }
}
