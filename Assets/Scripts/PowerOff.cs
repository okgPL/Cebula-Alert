using UnityEngine;
using UnityEngine.UI;

namespace CA
{
    public class PowerOff : MonoBehaviour
    {
        public GameObject tekst;
        private void Start()
        {
            if (Application.isEditor || Debug.isDebugBuild)
                tekst.GetComponent<Text>().text = "CA " + Application.version;
            else tekst.GetComponent<Text>().text = "";
        }
        public void OnMouseDown()
        {
            Debug.Log("Shutting down");
            Application.Quit();
        }
    }
}