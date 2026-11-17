using UnityEngine;
using System.Collections;
using UnityEditor.ShaderGraph;

public class CoroutineController : MonoBehaviour
{
    [SerializeField] MoveCharacter moveScript;
    [SerializeField] ChangeCharacterColor colorScript;
    [SerializeField] RotateCharacter rotateScript;
    Coroutine mainCoroutine;

    void Start()
    {
       mainCoroutine = StartCoroutine(Controller());
    }

    IEnumerator Controller()
    {
        StartCoroutine(moveScript.Move(new Vector3(3, 3, 0), 2f));

        yield return new WaitForSeconds(2f);

        StartCoroutine(colorScript.ChangeColor(Color.chocolate, 2f));

        yield return new WaitForSeconds(2f);

        StartCoroutine(rotateScript.Rotate(2f));

        yield break;
    }

    // Main coroutine that orchestrates the sequence of effects
    
        // 1. Move the character
        // 2. Change the character's color
        // 3. Rotate the character

        // All effects completed!

}
