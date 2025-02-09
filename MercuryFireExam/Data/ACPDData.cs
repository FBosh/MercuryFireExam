using MercuryFireExam.Enums;

namespace MercuryFireExam.Data
{
    /// <summary>
    /// ACPD資料
    /// </summary>
    public record ACPDData
    {
        /// <summary>
        /// 編號
        /// </summary>
        public long Sid { get; init; }

        /// <summary>
        /// 中文名稱
        /// </summary>
        public string ChineseName { get; init; }

        /// <summary>
        /// 英文名稱
        /// </summary>
        public string EnglishName { get; init; }

        /// <summary>
        /// 簡稱
        /// </summary>
        public string ShortName { get; init; }

        /// <summary>
        /// 信箱
        /// </summary>
        public string Email { get; init; }

        /// <summary>
        /// 狀態
        /// </summary>
        public ACPDStatus Status { get; init; }

        /// <summary>
        /// 是否已停用
        /// </summary>
        public bool IsStopped { get; init; }

        /// <summary>
        /// 停用原因
        /// </summary>
        public string StopMemo { get; init; }

        /// <summary>
        /// 登入帳號
        /// </summary>
        public string LogInID { get; init; }

        /// <summary>
        /// 登入密碼
        /// </summary>
        public string LogInPassword { get; init; }

        /// <summary>
        /// 備註
        /// </summary>
        public string Memo { get; init; }

        /// <summary>
        /// 創建日期時間
        /// </summary>
        public DateTime CreateDateTime { get; init; }

        /// <summary>
        /// 創建者代碼
        /// </summary>
        public string CreatorID { get; init; }

        /// <summary>
        /// 修改日期時間
        /// </summary>
        public DateTime UpdateDateTime { get; init; }

        /// <summary>
        /// 修改者代碼
        /// </summary>
        public string UpdaterID { get; init; }
    }
}
