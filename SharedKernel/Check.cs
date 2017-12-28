namespace SharedKernel
{
    public static class Check
    {
        public static Constraint That(bool assertion)
        {
            return new Constraint(assertion);
        }
    }
}
