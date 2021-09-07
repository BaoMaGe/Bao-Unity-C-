using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BaomageCore;

public class FindEnemy : MonoBehaviour
{
    private List<Transform> e = new List<Transform>(5);
    private float lowest = 100;
    public Transform low;
    public void Start()
    {
        FindChildInTransform(this.transform);
        foreach (Transform item in e)
        {
            if (item.GetComponent<EnemyHP>().HP < lowest)
            {
                lowest = item.GetComponent<EnemyHP>().HP;
                low = item.GetComponent<Transform>();
            }
        }
        e.Clear();
    }
    public Transform FindChildInTransform(Transform parent)//����������İ취���ұ��������壬����������ȫ�����������
    {

        if (parent.CompareTag("Enemy"))
        {
            e.Add(parent.transform);
        }
        for (int i = 0; i < parent.childCount; i++)
        {
            FindChildInTransform(parent.GetChild(i));
        }
        return null;
    }
}


