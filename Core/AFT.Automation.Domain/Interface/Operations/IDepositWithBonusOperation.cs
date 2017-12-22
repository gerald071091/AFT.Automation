namespace AFT.Automation.Domain.Interface.Operations
{
    public interface IDepositWithBonusOperation
    {
        /// <summary>
        /// DepositWithBonusOperation provide code in bonus code field
        /// </summary>
        IDepositWithBonusOperation ProvideDepositWithBonusCode(string code);

        /// <summary>
        /// DepositWithBonusOperation select product
        /// </summary>
        IDepositWithBonusOperation SelectDepositWithBonusProduct(string product);

        /// <summary>
        /// DepositWithBonusOperation accept terms and condition
        /// </summary>
        IDepositWithBonusOperation ClickDepositWithBonusTermsAndCondition();

        /// <summary>
        /// DepositWithBonusOperation accept bonus subscription
        /// </summary>
        IDepositWithBonusOperation ClickDepositWithBonusSubscribe();
    }
}
