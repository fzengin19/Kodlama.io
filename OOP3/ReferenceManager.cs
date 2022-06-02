namespace OOP3
{
    internal class ReferenceManager
    {   //Method Injection
        public void MakeReference(ICreditManager creditManager, List<ILoggerService> loggerServices)
        {
            // ANY CODE
            creditManager.Calculate();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }

        }
        public void PreCreditInformation(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
