using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    [SerializeField] private GameObject m_RunStopDust;
    [SerializeField] private GameObject m_JumpDust;
    [SerializeField] private GameObject m_LandingDust;

    private int m_facingDirection = 1;

    void SpawnDustEffect(GameObject dust, float dustXOffset = 0)
    {
        if (dust != null)
        {
            // Set dust spawn position
            Vector3 dustSpawnPosition = transform.position + new Vector3(dustXOffset * m_facingDirection, 0.0f, 0.0f);
            GameObject newDust = Instantiate(dust, dustSpawnPosition, Quaternion.identity) as GameObject;
            // Turn dust in correct X direction
            newDust.transform.localScale = newDust.transform.localScale.x * new Vector3(m_facingDirection, 1, 1);
        }
    }

    void AE_runStop()
    {
        // Spawn Dust
        float dustXOffset = 0.6f;
        SpawnDustEffect(m_RunStopDust, dustXOffset);
    }

    void AE_footstep()
    {

    }

    void AE_Jump()
    {
        // Spawn Dust
        SpawnDustEffect(m_JumpDust);
    }

    void AE_Landing()
    {
        // Spawn Dust
        SpawnDustEffect(m_LandingDust);
    }

}
