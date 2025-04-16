using UnityEngine;
using NaughtyAttributes;
public class Coin : MonoBehaviour
{
    [SerializeField] private int price = 5;
    public float rotateSpeed;

    private void Update()
    {
        Debug.Log("Rotation is " + transform.rotation);
        Debug.Log("Euler Angle is " + transform.rotation.eulerAngles);
    }

    void PrintCurrentMoney(int currentMoney)
    {
        Debug.Log($"Current money is {currentMoney}");
    }

    private void OnEnable()
    {
        GameManager.Instance.OnMoneyChanged.AddListener(PrintCurrentMoney);
    }

    private void OnDisable()
    {
        GameManager.Instance.OnMoneyChanged.RemoveListener(PrintCurrentMoney);
    }

    public void Collect()
    {
        GameManager.Instance.Money = price;
        Destroy(gameObject);
    }
    [Button("Rotate Quaternion.Identity")]
    public void Quaternion_Identity()
    {
        transform.rotation = Quaternion.identity;
    }
    [Button("Rotate 0 Degree")]
    public void _0Degree()
    {
        transform.rotation = Quaternion.Euler(0, 0, 0);
    }
    [Button("Rotate 90 Degree")]
    public void _90Degree()
    {
        transform.rotation = Quaternion.Euler(0,90,0);
    }
    [Button("Rotate 180 Degree")]
    public void _180Degree()
    {
        transform.rotation = Quaternion.Euler(0, 180, 0);
    }

}
