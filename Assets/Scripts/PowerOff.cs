using UnityEngine;

namespace CA
{
    public class PowerOff : MonoBehaviour
    {
        public void OnMouseDown()
        {
            Debug.Log("Shutting down");
            Application.Quit();
        }
    }
}