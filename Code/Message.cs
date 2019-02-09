using UnityEngine;

namespace DebugOnScreen
{
    public class Message : MonoBehaviour
    {
        [SerializeField]
        private TextMesh textMesh;

        public void Show(string message)
        {
            textMesh.text = message;
        }
    }
}
