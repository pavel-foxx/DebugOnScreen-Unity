using UnityEngine;
using UnityEngine.UI;
namespace DebugOnScreen
{
    public class Debuger : MonoBehaviour
    {
        private static Debuger _instance;
        public static Debuger instance
        {
            get
            {
                if (_instance == null)
                    _instance = FindObjectOfType<Debuger>();
                return _instance;
            }
        }

        private Transform messagesHolder;

        private static string canvasInstanceInResources = "Debuger/DebugerCanvas";
        private static string messageInstanceInResources = "Debuger/Message";

        public static void Log(object text)
        {
            Debug.Log(text);

            if (instance == null)
                _instance = Instantiate(Resources.Load<Debuger>(canvasInstanceInResources));

            if (instance.messagesHolder == null)
                instance.messagesHolder = instance.transform.GetChild(0);

            Text message = Instantiate(Resources.Load<Text>(messageInstanceInResources), _instance.messagesHolder);
            message.text = text.ToString();
        }

        public static void LogError(object text)
        {
            Debug.LogError(text);

            if (instance == null)
                _instance = Instantiate(Resources.Load<Debuger>(canvasInstanceInResources));

            if (instance.messagesHolder == null)
                instance.messagesHolder = instance.transform.GetChild(0);

            Text message = Instantiate(Resources.Load<Text>(messageInstanceInResources), _instance.messagesHolder);
            message.color = new Color(255, 0, 0, 255);
            message.text = text.ToString();
        }
    }
}