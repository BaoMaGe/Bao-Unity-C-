using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BaomageCore
{
    public class Find : MonoBehaviour
    {
        [SerializeField]
        private string n;
        public void OnGUI()
        {
            if (GUILayout.Button("find"))
            {
                Find2();
            }
        }
        public void Find2()//����㼶���Ҷ�Ӧ���ֵ�����
        {
            List<Transform> ch = new List<Transform>(5);//����ch�����建���б�
            List<Transform> ch2 = new List<Transform>(5);//����ch2�����建���б�(���������б�Ե�ѭ������������)
            foreach (Transform item in this.GetComponentsInChildren<Transform>())//��¼���������嵽�б���
            {
                ch.Add(item);
            }
            foreach (var item in ch)//��ÿ�������������
            {
                if (item.transform.Find(n) != null)//�ҵ���
                {
                    print("yes");
                    return;
                }
                else//û�ҵ�
                {
                    continue;
                }
            }
            foreach (Transform item in ch)//��¼���������嵽�б��ﲢ�����һ���б�
            {
                foreach (Transform item2 in item.GetComponentsInChildren<Transform>())
                {
                    ch2.Add(item2);
                }
                ch.Clear();
            }
            foreach (var item in ch2)//��ÿ�������������
            {
                if (item.transform.Find(n) != null)//�ҵ���
                {
                    print("yes");
                    return;
                }
                else//û�ҵ�
                {
                    continue;
                }
            }
        }

    }
}

