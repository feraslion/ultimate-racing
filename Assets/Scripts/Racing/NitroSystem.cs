using UnityEngine;

public class NitroSystem : MonoBehaviour
{
    public float NitroPower = 50f;
    public float NitroDuration = 3f;

    private CarController car;
    private bool active;

    private void Start()
    {
        car = GetComponent<CarController>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            ActivateNitro();
        }
    }

    public void ActivateNitro()
    {
        if (active) return;

        active = true;

        float oldSpeed = car.currentMaxSpeed;
        car.currentMaxSpeed += NitroPower;

        Invoke(nameof(ResetNitro), NitroDuration);
    }

    void ResetNitro()
    {
        active = false;
        car.currentMaxSpeed -= NitroPower;
    }
}
