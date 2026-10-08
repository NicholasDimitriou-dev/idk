using UnityEngine;
public class RocketScripts : MonoBehaviour
{

    public Camera camera;
    public Transform finalPoint;


    private void Update()
    {

        if (camera.gameObject.transform.position == finalPoint.position)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x,
                gameObject.transform.position.y + 10 * Time.deltaTime, gameObject.transform.position.z);
        }
    }


}
