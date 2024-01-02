using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float moveSpeed = 10f;  // �������� �������� ����
    private Transform target;     // ���� (����), � ������� ���� ��������
    public float damageAmount = 10;
    public void SetTarget(Transform newTarget)
    {
        target = newTarget;
    }

    void Update()
    {
        if (target != null)
        {
            // ���������� ���� � ����
            Vector3 direction = (target.position - transform.position).normalized;
            transform.Translate(direction * moveSpeed * Time.deltaTime, Space.World);
        }
        else
        {
            // ���� ���� �����������, ���������� ����
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            other.GetComponent<EnemyHeaphController>().TakeDamage(damageAmount);
            Destroy(this.gameObject);
        }
    }
}
