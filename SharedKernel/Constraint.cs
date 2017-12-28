using System;

namespace SharedKernel
{
    public class Constraint
    {
        private readonly bool _assertion;

        public Constraint(bool assertion)
        {
            _assertion = assertion;
        }

        public void OnFailure(Action action)
        {
            if (!_assertion)
            {
                action();
            }
        }
    }
}
