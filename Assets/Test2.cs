using UnityEngine;

namespace DefaultNamespace
{
    public class Test2:MonoBehaviour
    { 
        public UserId id;

        private void Start()
        {
            id = new UserId(1);
            var t = id.AsPrimitive();
            Debug.Log(t);
        }
    }
}