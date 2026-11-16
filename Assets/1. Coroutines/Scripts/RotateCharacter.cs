using UnityEngine;
using System.Collections;

public class RotateCharacter : MonoBehaviour
{
    public IEnumerator Rotate(float rotationDuration)
    {
        float timer = 0f;

        while (timer < rotationDuration)
        {
            timer += Time.deltaTime;
            float angle = 360f * (timer / rotationDuration);
            transform.rotation = Quaternion.Euler(0, 0, angle);
            yield return null;
        }
    }
}