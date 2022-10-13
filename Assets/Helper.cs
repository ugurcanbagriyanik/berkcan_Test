using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

namespace Helpers
{
    public static class Helper
    {
        public static List<GameObject> GetChildren(GameObject go,[CanBeNull] string tag)
        {
            List<GameObject> list = new List<GameObject>();
            return GetChildrenHelper(go, list,tag);
        }

        private static List<GameObject> GetChildrenHelper(GameObject go, List<GameObject> list,[CanBeNull] string tag)
        {
            if (go == null || go.transform.childCount == 0)
            {
                return list;
            }

            foreach (Transform t in go.transform)
            {
                if (tag == null || t.CompareTag(tag))
                {
                    list.Add(t.gameObject);
                }
                
                GetChildrenHelper(t.gameObject, list,tag);
            }

            return list;
        }
    }
}