using UnityEngine;

public static class ColorUtility {
    public static void PickAndSetAColorToObject(GameObject obj, Color color, bool randomColor = false) {
        //if randomColor == true
        //assign random color
        //obj material color = color that we pass in
        if (randomColor == true)
            color = new Color(Random.value, Random.value, Random.value);
        obj.GetComponent<MeshRenderer>().material.color = color;
    }
}