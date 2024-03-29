

using UnityEngine;

public class PlayerModel 
{
    public CharacterType CharacterType { get { return _characterType; } }
    public CharacterClass CharacterClass { get { return _characterClass; } set { _characterClass = value; } }
    public string Description { get { return _description; } }
    public Health Health { get { return _health; } }
    public int CoinPrice { get { return _coinPrice; } set { _coinPrice = value; } }
    public int Damage { get { return _damage; } set { _damage = value; } }
    public Vector2 SpeedClimb { get { return _speedClimb; } set { _speedClimb = value; } }
    public Vector2 SpeedMax { get { return _speedMax; } set { _speedMax = value; } }
    public Vector2 SpeedNow { get { return _speedNow; } set { _speedNow = value; } }
    public Vector2 Acceleration { get { return _acceleration; } set { _acceleration = value; } }
    public Vector2 JumpForce { get { return _jumpForce; } set { _jumpForce = value; } }
    public int JumpNumber { get { return _jumpNumber; } set { _jumpNumber = value; } }
    public SpriteAnimationsConfig SpriteAnimationsConfig { get { return _spriteAnimationsConfig; } set { _spriteAnimationsConfig = value; } }
    public CharacterSettings CharacterSettings { get { return _characterSettings; } set { _characterSettings = value; } }

    private CharacterType _characterType;
    private CharacterClass _characterClass;
    private string _description;
    private Health _health;
    private int _coinPrice;
    private int _damage;
    private Vector2 _speedClimb;
    private Vector2 _speedMax;
    private Vector2 _speedNow;
    private Vector2 _acceleration;
    private Vector2 _jumpForce;
    private int _jumpNumber;

    private SpriteAnimationsConfig _spriteAnimationsConfig;

    private CharacterSettings _characterSettings;

    public PlayerModel(CharacterData playerData)
    {
        _characterType = playerData.CharacterType;
        _characterClass = playerData.CharacterClass;
        _description = playerData.Description;
        _health = new Health(playerData.Health);
        _coinPrice = 0;
        _damage = playerData.Damage;
        _speedClimb = playerData.SpeedClimb;
        _speedMax = playerData.SpeedMax;
        _speedNow = Vector2.zero; 
        _acceleration = playerData.Acceleration;
        _jumpForce = playerData.JumpForce;
        _jumpNumber = playerData.JumpNumber;
        _spriteAnimationsConfig = playerData.SpriteAnimationsConfig;
        _characterSettings = playerData.CharacterSettings;
    }
}
