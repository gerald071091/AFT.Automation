using AFT.Automation.Domain.Helper;
using AFT.Automation.Domain.Interface.Operations;
using AFT.Automation.Services;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Xml;
using TechTalk.SpecFlow;

namespace AFT.Automation.UnitTest.Utilities
{
    public class TestUtility : PageOperation
    {
        #region Asserts

        /// <summary>
        /// Check if the url contains the page name
        /// </summary>
        /// <param name="url"></param>
        /// <param name="pageName"></param>
        protected void CheckUrl(string url, string pageName)
        {
            Assert.That(url, Does.Contain(pageName));
        }

        /// <summary>
        /// Check if page exist
        /// </summary>
        /// <param name="url"></param>
        protected void DoesPageExist(string url)
        {
            Assert.That(url.Contains("404"), Is.False, "Is 404 page.");
        }

        /// <summary>
        /// Check if actual content contains the expected content
        /// </summary>
        /// <param name="actualContent"></param>
        /// <param name="expectedContent"></param>
        protected void DoesContains(string actualContent, string expectedContent)
        {
			if (actualContent.Contains("http"))
			{
				actualContent = actualContent.ToLower();
				expectedContent = expectedContent.ToLower();
			}

            Assert.AreEqual(true, actualContent.Contains(expectedContent));
        }

        /// <summary>
        /// Check if this operation satisfy the condition
        /// </summary>
        /// <param name="predicateExp"></param>
        protected void DoesContains(Expression<Func<IBaseOperation, bool>> predicateExp)
        {
            Func<IBaseOperation, bool> predicate = predicateExp.Compile();

            Assert.AreEqual(true, predicate(_operation));
        }

        /// <summary>
        /// Check if statement are truthy
        /// </summary>
        /// <param name="state"></param>
        protected void DoesEqual(bool state)
        {
            Assert.AreEqual(true, state);
        }

        /// <summary>
        /// Check if first obj and second obj are equal
        /// </summary>
        /// <param name="firstState"></param>
        /// <param name="secondState"></param>
        protected void DoesEqual(object firstState, object secondState)
        {
            Assert.AreEqual(firstState, secondState);
        }

        #endregion Asserts

        #region Argument transformation functions

        [StepArgumentTransformation]
        public List<string> TransformToListOfString(string commaSeparatedList)
        {
            string[] stringSeparators = new string[] { "," };
            return commaSeparatedList.Split(stringSeparators, StringSplitOptions.None).ToList();
        }

        #endregion Argument transformation functions

        #region Compiled Actions

        public void GetSharedStepAction(string scenario)
        {
			_dictionary = new Dictionary<string, Action>
            {
				#region Login
                {"LoginUserIsRequired", () => { DoesContains(_operation.ModalMessage(), "Login is required."); _operation.ClickAcceptModalButton(); } },
				{"LoginUserLessThan5", () => { DoesContains(_operation.ModalMessage(), "Invalid Username"); _operation.ClickAcceptModalButton(); } },
				{"LoginUserGreaterThan12", () => { DoesContains(_operation.ModalMessage(), "Invalid Username"); _operation.ClickAcceptModalButton(); } },
				{"LoginSpecialCharacter", () => { DoesContains(_operation.ModalMessage(), "Invalid Username"); _operation.ClickAcceptModalButton(); } },
				{"LoginPassIsRequired", () => { DoesContains(_operation.ModalMessage(), "Password is required."); _operation.ClickAcceptModalButton(); }  },
				{"LoginPassLessThan6", () => { DoesContains(_operation.ModalMessage(), "Invalid Password"); _operation.ClickAcceptModalButton(); } },
				{"LoginPassNotValid", () => { DoesContains(_operation.ModalMessage(), "Invalid Username or Password"); _operation.ClickAcceptModalButton(); }  },
				{"LoginUserNotValid", () => { DoesContains(_operation.ModalMessage(), "Invalid Username or Password"); _operation.ClickAcceptModalButton(); }  },
				{"LoginUnwanted", () => { DoesContains(_operation.ModalMessage(), "Invalid Username or Password"); _operation.ClickAcceptModalButton(); }  },
				{"LoginInactive", () => { DoesContains(_operation.ModalMessage(), "Invalid Username or Password"); _operation.ClickAcceptModalButton(); }  },
				{"LoginSuspended", () => { DoesContains(_operation.ModalMessage(), "Invalid Username or Password"); _operation.ClickAcceptModalButton(); }  },
				{"LoginSelfExcluded", () => { DoesContains(_operation.ModalMessage(), "Invalid Username or Password"); _operation.ClickAcceptModalButton(); }  },
				{"LoginTimeout", () => { DoesContains(_operation.ModalMessage(), "Invalid Username or Password"); _operation.ClickAcceptModalButton(); }  },
				{"LoginSuccess", () => { _operation.ClickQuickDepositCloseButton(); DoesEqual(_operation.IsLoginHeaderPresent()); _operation.ClickLogoutButton(); }  },
                #endregion Login

                #region Registration
                {"RegistrationInvalidUsername(Format)", () => { DoesContains(_operation.GetRegistrationUsernameWarningMessage(), "Invalid Username format.");  }  },
				{"RegistrationInvalidPassword(NotMatched)", () => { DoesContains(_operation.GetRegistrationConfirmPasswordWarningMessage(), "Passwords do not match.");  }  },
				{"RegistrationInvalidPassword(PasswordLength)", () => { DoesContains(_operation.GetRegistrationPasswordWarningMessage(), "Password length should");  }  },
				{"RegistrationInvalidEmail(NotValid)", () => { DoesContains(_operation.GetRegistrationEmailWarningMessage(), "Please enter a valid email address.");  }  },
				{"RegistrationInvalidMobileNumber(NotValid)", () => { DoesContains(_operation.GetRegistrationMobileNumberWarningMessage(), "You may only use numbers(0-9)"); }  },
				{"RegistrationInvalidPostalCode(NotValid)", () => { DoesContains(_operation.GetRegistrationPostalCodeWarningMessage(), "should be alphanumeric."); }  },
				{"RegistrationInvalidCity(NotValid)", () => { DoesContains(_operation.GetRegistrationCityWarningMessage(), "Please use letters, numbers and permitted special characters"); }  },
				{"RegistrationInvalidFirstName(NotValid)", () => { DoesContains(_operation.GetRegistrationFirstNameWarningMessage(), "Letters, spaces and special characters"); }  },
				{"RegistrationInvalidMiddleName(NotValid)", () => { DoesContains(_operation.GetRegistrationMiddleNameWarningMessage(), "Letters, spaces and special characters"); }  },
				{"RegistrationInvalidLastName(NotValid)", () => { DoesContains(_operation.GetRegistrationLastNameWarningMessage(), "Letters, spaces and special characters"); }  },
                #endregion Registration

                #region ForgotPassword
                {"ForgotUsernameIsRequired", () => { DoesContains(_operation.ModalMessage(), "Username"); _operation.ClickAcceptModalButton(); }  },
				{"ForgotEmailIsRequired", () => { DoesContains(_operation.ModalMessage(), "Email"); _operation.ClickAcceptModalButton(); }  },
				{"ForgotFieldValidation", () => { DoesContains(_operation.ModalMessage(), "required."); _operation.ClickAcceptModalButton(); }  },
				{"ForgotSuccess", () => { DoesContains(_operation.ModalMessage(), "New password"); _operation.ClickAcceptModalButton(); }  },
                #endregion ForgotPassword

                #region ChangePassword
                {"ChangePassFieldValidation", () => { DoesContains(_operation.ModalMessage(), "fields are populated."); _operation.ClickAcceptModalButton().ClickLogoutButton(); }  },
				{"ChangePassSuccess", () => { DoesContains(_operation.ModalMessage(), "changed successfully."); _operation.ClickAcceptModalButton().ClickLogoutButton(); }  },
                #endregion ChangePassword

                #region HeaderLink
                {"HeaderLinkSiteLogo", () => { DoesContains(_operation.GetTheCurrentUrl(), _operation.GetCurrentPageTitle()); }  },
				{"HeaderLinkForgot", () => { DoesContains(_operation.GetTheCurrentUrl(), "lostpassword"); }  },
				{"HeaderLinkAffiliates", () => { _operation.GoToTab("AceWorldGaming"); DoesContains(_operation.GetTheCurrentUrl(), "aceworldgaming"); _operation.GoToDefaultTab(); }  },
				{"HeaderLinkPromotions", () => { DoesContains(_operation.GetTheCurrentUrl(), "promotions"); }  },
				{"HeaderLinkSportsbook", () => { DoesContains(_operation.GetTheCurrentUrl(), "sportsbook"); }  },
				{"HeaderLinkCasino", () => { DoesContains(_operation.GetTheCurrentUrl(), "casino"); }  },
				{"HeaderLinkDeposit", () => { DoesContains(_operation.GetTheCurrentUrl(), "deposit"); _operation.ClickLogoutButton(); }  },
				{"HeaderLinkMyAccount", () => { DoesContains(_operation.GetTheCurrentUrl(), "account"); _operation.ClickLogoutButton(); }  },
                #endregion HeaderLink

                #region MyWallet
                {"MyWalletUrlVerification", () => { DoesContains(_operation.GetTheCurrentUrl(), "mywallet"); _operation.ClickLogoutButton(); }  },
				{"MyWalletBalances", () => { DoesEqual(_operation.GetMyWalletMainBalance(), _operation.GetMyWalletMainWalletBalance()); _operation.ClickLogoutButton(); }  },
                #endregion MyWallet

                #region MyBonuses
                {"MyBonusesUrlVerification", () => { DoesContains(_operation.GetTheCurrentUrl(), "mybonuses"); _operation.ClickLogoutButton(); }  },
				{"MyBonusesDetailsVerification", () => { DoesContains(page => !string.IsNullOrEmpty(page.GetMyBonusesPlayerFullName())
					&& !string.IsNullOrEmpty(page.GetMyBonusesBalances())
					&& !string.IsNullOrEmpty(page.GetMyBonusesBettingBalance())); _operation.ClickLogoutButton(); } },
                #endregion MyBonuses

                #region MyDetails
                {"MyDetailsUrlVerification", () => { DoesContains(_operation.GetTheCurrentUrl(), "mydetails");  _operation.ClickLogoutButton(); } },
				{"MyDetailsDetailsVerification", () => { DoesContains(page => !string.IsNullOrEmpty(page.GetMyDetailsFullName())
					&& !string.IsNullOrEmpty(page.GetMyDetailsLoginName())
					&& !string.IsNullOrEmpty(page.GetMyDetailsAddress())
					&& !string.IsNullOrEmpty(page.GetMyDetailsPostalCode())
					&& !string.IsNullOrEmpty(page.GetMyDetailsCity())
					&& !string.IsNullOrEmpty(page.GetMyDetailsCountry())
					&& !string.IsNullOrEmpty(page.GetMyDetailsMobileNumber())
					&& !string.IsNullOrEmpty(page.GetMyDetailsEmailAddress()));  _operation.ClickLogoutButton(); } },
                #endregion MyDetails

                #region BonusHistory
                {"BonusHistoryFieldValidation", () => { DoesContains(_operation.ModalMessage(), "fields are populated."); _operation.ClickAcceptModalButton().ClickLogoutButton(); }  },
				{"BonusHistoryTableResult", () => { DoesContains(data => data.BonusHistoryTableDataCount() > 0); _operation.ClickLogoutButton(); }  },
                #endregion BonusHistory

                #region TransactionHistory
                {"TransactionHistoryFieldValidation", () => { DoesContains(_operation.ModalMessage(), "fields are populated."); _operation.ClickAcceptModalButton().ClickLogoutButton(); }  },
				{"TransactionHistoryTableResult", () => { DoesContains(data => data.TransactionHistoryTableDataCount() > 0); _operation.ClickLogoutButton(); }  },
                #endregion TransactionHistory

                #region GameHistory
                {"GameHistoryFieldValidation", () => { DoesContains(_operation.ModalMessage(), "fields are populated."); _operation.ClickAcceptModalButton().ClickLogoutButton(); }  },
				{"GameHistoryTableResult", () => { DoesContains(data => data.GameHistoryTableDataCount() > 0 || data.ModalMessage().Contains("more than 1 month"));
					if (!string.IsNullOrEmpty(_operation.ModalMessage())) { _operation.ClickAcceptModalButton(); } _operation.ClickLogoutButton();
				}  },
                #endregion GameHistory

                #region ResponsibleGaming
                {"RGChangeRealityCheck", () => { DoesContains(_operation.ModalMessage(), "successfully updated."); _operation.ClickAcceptModalButton().ClickLogoutButton(); }  },
				{"RGDepositLimitFieldValidation", () => { DoesContains(_operation.ModalMessage(), "limit is required."); _operation.ClickAcceptModalButton().ClickLogoutButton(); }  },
				{"RGTimeOutSelfExcludeValidation", () => { DoesContains(_operation.ModalMessage(), "should be checked."); _operation.ClickAcceptModalButton().ClickLogoutButton(); }  },
                #endregion ResponsibleGaming

                #region FooterLink
                {"FooterLinkOpenAccount", () => DoesContains(_operation.GetTheCurrentUrl(), "register")},
				{"FooterLinkAboutUs", () => DoesContains(_operation.GetTheCurrentUrl(), "aboutus")},
				{"FooterLinkContactUs", () => DoesContains(_operation.GetTheCurrentUrl(), "contactus")},
				{"FooterLinkPromotions", () => DoesContains(_operation.GetTheCurrentUrl(), "promotions")},
				{"FooterLinkTermsAndConditions", () => DoesContains(_operation.GetTheCurrentUrl(), "terms")},
				{"FooterLinkRules", () => DoesContains(_operation.GetTheCurrentUrl(), "rules")},
				{"FooterLinkPrivacyPolicy", () => DoesContains(_operation.GetTheCurrentUrl(), "privacypolicy")},
				{"FooterLinkCashOut", () => DoesContains(_operation.GetTheCurrentUrl(), "cashout")},
				{"FooterLinkLostPassword", () => DoesContains(_operation.GetTheCurrentUrl(), "lostpassword")},
				{"FooterLinkTechnicalSupport", () => DoesContains(_operation.GetTheCurrentUrl(), "technicalsupport")},
				{"FooterLinkDepositAndWithdrawals", () => DoesContains(_operation.GetTheCurrentUrl(), "depositandwithdrawal")},
				{"FooterLinkResponsibleGaming", () => DoesContains(_operation.GetTheCurrentUrl(), "responsiblegambling")},
				{"FooterLinkRTP", () => DoesContains(_operation.GetTheCurrentUrl(), "rtp")},
				{"FooterLinkFAQ", () => DoesContains(_operation.GetTheCurrentUrl(), "faq")},
				{"FooterLinkGameCare", () => { _operation.GoToTab("GamCare - the UK's national organisation for gambling problem help | GamCare"); DoesContains(_operation.GetTheCurrentUrl(), "gamcare"); } },
				{"FooterLinkAgeRestriction", () => { DoesContains(_operation.ModalMessage(), "You must be 18 years of age to register"); _operation.ClickAcceptModalButton(); } },
				{"FooterLinkSafeAndSecure", () => { _operation.GoToNextTab(); DoesContains(_operation.GetTheCurrentUrl(), "safeandsecure"); } },
				{"FooterLinkIBAS", () => { _operation.GoToTab("IBAS Home"); DoesContains(_operation.GetTheCurrentUrl(), "ibas-uk"); } },
				{"FooterLinkIsleOfMan", () => { _operation.GoToTab("Isle of Man Government - Gambling and e-gaming"); DoesContains(_operation.GetTheCurrentUrl(), "gov.im"); } },
				{"FooterLinkGamblingCommission", () => { _operation.GoToTab("Account details"); DoesContains(_operation.GetTheCurrentUrl(), "gamblingcommission"); } },
				{"FooterLinkGambleAware", () => { _operation.GoToTab(""); DoesContains(_operation.GetTheCurrentUrl(), "gambleaware"); } },
				{"FooterLinkSiteLogo", () => DoesContains(_operation.GetTheCurrentUrl(), _operation.GetCurrentPageTitle())},
                #endregion FooterLink

                #region Deposit
                {"DepositSuccess", () => { DoesContains(_operation.GetTheCurrentUrl(), "done"); DoesContains(page => !string.IsNullOrEmpty(page.GetDepositNetellerReferenceNumber())); _operation.ClickLogoutButton(); } },
				{"DepositInvalidAccountOrEmail", () => { DoesContains(_operation.ModalMessage(), "accountId or email"); _operation.ClickAcceptModalButton().ClickLogoutButton(); } },
                #endregion Deposit

                #region DepositWithBonus
                {"DepositWithBonusSuccess", () => ScenarioContext.Current.Pending()},
				{"DepositWithBonusInvalidBonusCode", () => { DoesContains(_operation.ModalMessage(), "use this bonus name"); _operation.ClickAcceptModalButton().ClickLogoutButton(); } },
				{"DepositWithBonusTCAgreement", () => { DoesContains(_operation.ModalMessage(), "You must agree"); _operation.ClickAcceptModalButton().ClickLogoutButton(); } },
                #endregion DepositWithBonus

                #region Withdraw
                {"WithdrawSuccess", () => { DoesContains(_operation.ModalMessage(), "withdrawal request"); _operation.ClickAcceptModalButton().ClickLogoutButton(); } },
				{"WithdrawRequiredMonth", () => { DoesContains(_operation.ModalMessage(), "Expiry Month"); _operation.ClickAcceptModalButton().ClickLogoutButton(); } },
				{"WithdrawRequiredYear", () => { DoesContains(_operation.ModalMessage(), "Expiry Year"); _operation.ClickAcceptModalButton().ClickLogoutButton(); } },
				{"WithdrawInvalidCode", () => { DoesContains(_operation.ModalMessage(), "Secure code"); _operation.ClickAcceptModalButton().ClickLogoutButton(); } },
				{"WithdrawValidation", () => { DoesContains(_operation.ModalMessage(), "not yet deposited"); _operation.ClickAcceptModalButton().ClickLogoutButton(); } }
                #endregion Withdraw
                   
            };

			_dictionary[scenario]();
        }

        public void GetSharedStepAction(string feature, List<string> details)
        {
			_list = details.ToNormalStringList();

			_dictionary = new Dictionary<string, Action>
            {
                {"ForgotPassword", () =>
                    {
                        _operation.ProvideForgotPasswordLoginName(_list[0]).ProvideForgotPasswordEmailAddress(_list[1]);
                    }
                },
                {"ChangePassword", () =>
                    {
                        _operation.ProvideChangePasswordCurrent(_list[0]).ProvideChangePasswordNew(_list[1]).ProvideChangePasswordConfirm(_list[2]);
                    }
                },
                {"BonusHistory", () =>
                    {
                        _operation.SelectBonusHistoryProduct(_list[0]).SelectBonusHistoryStatus(_list[1]).ProvideBonusHistoryStartDate(_list[2])
                        .ProvideBonusHistoryEndDate(_list[3]).SelectBonusHistoryLimit(_list[4]);
                    }
                },
                {"TransactionHistory", () =>
                    {
                        _operation.SelectTransactionHistoryType(_list[0]).SelectTransactionHistoryLimit(_list[1]).ProvideTransactionHistoryStartDate(_list[2])
                        .ProvideTransationHistoryEndDate(_list[3]);
                    }
                },
                {"GameHistory", () =>
                    {
                        _operation.SelectGameHistoryProduct(_list[0]).ProvideGameHistoryGameStartDate(_list[1]).ProvideGameHistoryGameEndDate(_list[2])
                        .SelectGameHistoryTransactionLimit(_list[3]);
                    }
                },
                {"Deposit", () =>
                    {
                        _operation.ProvideDepositNetellerAmount(_list[0]).ProvideDepositNetellerAccountID(_list[1]).ProvideDepositNetellerSecureID(_list[2]);
                    }
                },
                {"Withdraw", () =>
                    {
                        _operation.ProvideWithdrawExpiryMonth(_list[0]).ProvideWithdrawExpiryYear(_list[1]).ProvideWithdrawSecurityCode(_list[2]);
                    }
                }

            };

			_dictionary[feature]();
        }

        #endregion Compiled Actions
    }
}
