[System.Flags]
public enum SpellsChosee
{
    None = 0, 
    Buff = 1 << 1,   
    KillCard = 1 << 2,
    Team = 1 << 3,
    Resurrection= 1 << 4,
    BuffOne = 1 << 5,
    Spy =1 <<6
}
