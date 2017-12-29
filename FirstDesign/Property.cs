namespace FirstDesign
{
    public class Property
    {
        public int ID { get; set; }

        public string Description { get; set; }

        public virtual Person Person { get; set; }
    }
}
