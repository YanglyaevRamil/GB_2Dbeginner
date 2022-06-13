using UnityEngine;

[CreateAssetMenu(fileName = "New CharacterPhysicalSettings", menuName = "Configs/CharacterPhysicalSettings")]
public class CharacterPhysicalSettings : ScriptableObject
{
    [SerializeField]
    private float collisionThresh;

    [SerializeField]
    private float climbThresh;

    public float CollisionThresh { get { return collisionThresh; } }
    public float ClimbThresh { get { return climbThresh; } }
}
