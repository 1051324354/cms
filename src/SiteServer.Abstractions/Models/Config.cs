using System;
using Datory;
using Datory.Annotations;

namespace SiteServer.Abstractions
{
    [DataTable("siteserver_Config")]
    public class Config : Entity
    {
        [DataColumn]
        public string DatabaseVersion { get; set; }

        [DataColumn]
        public DateTime UpdateDate { get; set; }

        public bool Initialized => Id > 0;

        public bool IsSeparatedApi { get; set; }

        public string SeparatedApiUrl { get; set; }

        public bool IsLogSite { get; set; } = true;

        public bool IsLogAdmin { get; set; } = true;

        public bool IsLogUser { get; set; } = true;

        public bool IsLogError { get; set; } = true;

        // �Ƿ���ʱ����ֵ
        public bool IsTimeThreshold { get; set; }

        public int TimeThreshold { get; set; } = 60;

        /****************����Ա����********************/

        public int AdminUserNameMinLength { get; set; }

        public int AdminPasswordMinLength { get; set; } = 6;

        public PasswordRestriction AdminPasswordRestriction { get; set; } = PasswordRestriction.LetterAndDigit;

        public bool IsAdminLockLogin { get; set; }

        public int AdminLockLoginCount { get; set; } = 3;

        public LockType AdminLockLoginType { get; set; } = LockType.Hours;

        public int AdminLockLoginHours { get; set; } = 3;

        public bool IsAdminEnforcePasswordChange { get; set; }

        public int AdminEnforcePasswordChangeDays { get; set; } = 90;

        public bool IsAdminEnforceLogout { get; set; }

        public int AdminEnforceLogoutMinutes { get; set; } = 960;

        /****************�û�����********************/

        public bool IsUserRegistrationAllowed { get; set; } = true;

        public string UserRegistrationAttributes { get; set; }

        public bool IsUserRegistrationGroup { get; set; }

        public bool IsUserRegistrationChecked { get; set; } = true;

        public bool IsUserUnRegistrationAllowed { get; set; } = true;

        public int UserPasswordMinLength { get; set; } = 6;

        public PasswordRestriction UserPasswordRestriction { get; set; } = PasswordRestriction.LetterAndDigit;

        public int UserRegistrationMinMinutes { get; set; } = 3;

        public bool IsUserLockLogin { get; set; }

        public int UserLockLoginCount { get; set; } = 3;

        public string UserLockLoginType { get; set; } = "Hours";

        public int UserLockLoginHours { get; set; } = 3;

        public string UserDefaultGroupAdminName { get; set; }

        /****************�����̨����********************/

        public string AdminTitle { get; set; } = "SiteServer CMS";

        public string AdminLogoUrl { get; set; }

        public string AdminWelcomeHtml { get; set; } = @"��ӭʹ�� SiteServer CMS �����̨";

        /****************�û���������********************/

        public bool IsHomeClosed { get; set; }

        public string HomeTitle { get; set; } = "�û�����";

        public bool IsHomeLogo { get; set; }

        public string HomeLogoUrl { get; set; }

        public string HomeDefaultAvatarUrl { get; set; }

        public bool IsHomeAgreement { get; set; }

        public string HomeAgreementHtml { get; set; } =
            @"�Ķ�������<a href=""/agreement.html"" target=""_blank"">���û�Э�顷</a>";

    }
}
