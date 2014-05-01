using System.IO;

namespace Projac.Testing
{
    class EmptyResultSetExpectationVerificationResult : ExpectationVerificationResult
    {
        public EmptyResultSetExpectationVerificationResult(IExpectation expectation, ExpectationVerificationResultState state) 
            : base(expectation, state)
        {
        }

        public override void WriteTo(TextWriter writer)
        {
            if (Passed)
            {

            }
            else if (Failed)
            {
                
            }
        }
    }
}