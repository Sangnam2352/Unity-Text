using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MoveCloud : MonoBehaviour
{
    public float moveSpeed;
    public float maxWidth;

    int direction = 1;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(moveSpeed*direction, 0, 0);
    }
}
