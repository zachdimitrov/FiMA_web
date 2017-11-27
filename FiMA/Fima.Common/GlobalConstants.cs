namespace Fima.Common
{
    public class GlobalConstants
    {
        public const string AdministratorRoleName = "администратор";
        public const string GuestRoleName = "гост";
        public const string BackOfficeRoleName = "бек офис";
        public const string FrontOfficeRoleName = "фронт офис";
        public const string AccountantRoleName = "счетоводител";
        public const string WalletManagerRoleName = "управление на портфейл";
        public const string RiskManagerRoleName = "управление на риска";
        public const int PasswordMinLength = 1;

        public static readonly string[] PerTypes = new[]
        {
            "българско физическо лице",
            "българско юридическо лице",
            "чуждестранно физическо лице",
            "чуждестранно юридическо лице"
        };

        public static readonly string[] ContractType = new[]
        {
            "служител",
            "пълномощник"
        };

        public static readonly string[] OrganisationType = new[]
        {
            "банка",
            "ООД",
            "ЕООД",
            "АД",
            "ЕТ",
            "няма"
        };
    }
}
