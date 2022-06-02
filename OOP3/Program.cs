using OOP3;

ICreditManager personelFinanceCreditManager = new PersonelFinanceCreditManager();
ICreditManager vehicleCreditManager = new VehicleCreditManager();
ICreditManager housingCreditManager = new HousingCreditManager();

//ReferenceManager referenceManager = new ReferenceManager();
//referenceManager.MakeReference(personelFinanceCreditManager, new DatabaseLoggerService());

ILoggerService databaseLoggerService = new DatabaseLoggerService();
ILoggerService fileLoggerService = new FileLoggerService();

List<ILoggerService> loggers = new List<ILoggerService> { new FileLoggerService(), new DatabaseLoggerService() };

ReferenceManager referenceManager = new ReferenceManager();
referenceManager.MakeReference(personelFinanceCreditManager, loggers);

List<ICreditManager> credits = new List<ICreditManager>() { personelFinanceCreditManager, vehicleCreditManager, housingCreditManager };
//referenceManager.PreCreditInformation(credits);


{
    return;
}