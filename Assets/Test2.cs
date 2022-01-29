using UnityEngine;

namespace DefaultNamespace
{
    public class Test2:MonoBehaviour
    { 
        public UserId id;

        private void Start()
        {
            id = new UserId(1);
          
            var id2 =id+id;
            var t = id2.AsPrimitive();
            Debug.Log(t);
            Debug.Log(id2);
        }
    }
}