namespace AFT.Automation.Domain.Interface.Operations
{
    public interface IChangePasswordOperation
    {
        /// <summary>
        /// ChangePasswordOperation click change password button
        /// </summary>
        IChangePasswordOperation ClickChangePasswordButton();

        /// <summary>
        /// ChangePasswordOperation provide current password
        /// </summary>
        IChangePasswordOperation ProvideChangePasswordCurrent(string currentPassword);

        /// <summary>
        /// ChangePasswordOperation provide new password
        /// </summary>
        IChangePasswordOperation ProvideChangePasswordNew(string newPassword);

        /// <summary>
        /// ChangePasswordOperation confirm new password
        /// </summary>
        IChangePasswordOperation ProvideChangePasswordConfirm(string confirmPassword);

        /// <summary>
        /// ChangePasswordOperation click update button
        /// </summary>
        IChangePasswordOperation ClickChangePasswordUpdateButton();
    }
}
