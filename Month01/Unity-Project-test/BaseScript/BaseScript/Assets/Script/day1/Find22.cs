using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace BaomageCore
{
    public class Find22 : MonoBehaviour
    {
        [SerializeField]
        private List<Transform> n;//�����������б�
        public void Find2()
        {
            FindChildInTransform(this.GetComponent<Transform>(), "Cb");
        }
        public Transform FindChildInTransform(Transform parent, string child)//����������İ취���ұ��������壬����������ȫ�����������
        {
            Transform childTF = parent.Find(child);
            if (childTF != null)
            {
                n.Add(childTF);
                return childTF;
            }
            for (int i = 0; i < parent.childCount; i++)
            {
                childTF = FindChildInTransform(parent.GetChild(i), child);
            }
            return null;
        }
    }
}

