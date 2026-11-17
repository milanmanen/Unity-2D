using UnityEngine;

public class PlayerFip : MonoBehaviour
{
    private float HorizontalInput;
    private bool faceingRight = true;
    // Update is called once per frame
    void Update()
    {
        HorizontalInput = Input.GetAxis("Horizontal");
        SetupDirectionByScale();

    }

    private void SetupDirectionByScale()
    {
        if(HorizontalInput < 0 && faceingRight || HorizontalInput > 0 && !faceingRight)
        {
            faceingRight = !faceingRight;
            Vector3 playerScale = transform.localScale;
            playerScale.x *= -1;
            transform.localScale = playerScale;
        }
    }
}
