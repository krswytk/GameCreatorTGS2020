using UnityEngine;

public class Example : MonoBehaviour
{
    public ShakeableTransform m_shakeable;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            m_shakeable.InduceStress(1);
        }
    }
}