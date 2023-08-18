using UnityEngine;

public static class GameObjectUtility {
    ///<summary>
    ///Creates a primitive cube and sets its position.
    ///</summary>
    public static void CreateCubeAndSetPos(GameObject obj, Vector3 newPosition) {
        //create a new primitive cube
        GameObject.CreatePrimitive(PrimitiveType.Cube);
        //set the cube's position to zero
        obj.transform.position = newPosition;
    }
}
