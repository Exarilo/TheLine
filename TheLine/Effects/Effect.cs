namespace TheLine.Effects
{
    public class Effect
    {
        public string Description { get; set; }
        public virtual void ApplyEffect(Character character) { }
    }
}
