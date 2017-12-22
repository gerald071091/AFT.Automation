namespace AFT.Automation.Domain.Interface.Operations
{
    public interface ILoginOperation
    {
        /// <summary>
        /// LoginOperation Get the provided username
        /// </summary>
        /// <param name="username"></param>
        IBaseOperation ProvideLoginUserName(string username);

        /// <summary>
        /// LoginOperation Get the provided password
        /// </summary>
        /// <param name="password"></param>
        IBaseOperation ProvideLoginPassword(string password);

        /// <summary>
        /// LoginOperation click login button
        /// </summary>
        IBaseOperation ClickLoginButton();

        /// <summary>
        /// LoginOperation click Logout button
        /// </summary>
        IBaseOperation ClickLogoutButton();

        /// <summary>
        /// LoginOperation check if login details is display/present
        /// </summary>
        /// <returns></returns>
        bool IsLoginHeaderPresent();
    }
}
