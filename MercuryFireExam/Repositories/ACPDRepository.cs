using MercuryFireExam.Data;

namespace MercuryFireExam.Repositories
{
    /// <summary>
    /// ACPD儲存庫介面
    /// </summary>
    public interface IACPDRepository
    {
        /// <summary>
        /// 非同步新增
        /// </summary>
        /// <param name="data">資料</param>
        Task InsertAsync(ACPDData data);

        /// <summary>
        /// 非同步查詢
        /// </summary>
        /// <param name="sid">編號</param>
        /// <returns>ACPD資料</returns>
        Task<ACPDData> SelectAsync(long sid);

        /// <summary>
        /// 非同步更新
        /// </summary>
        /// <param name="data">資料</param>
        Task UpdateAsync(ACPDData data);

        /// <summary>
        /// 非同步刪除
        /// </summary>
        /// <param name="sid">編號</param>
        Task DeleteAsync(long sid);
    }

    /// <summary>
    /// ACPD儲存庫
    /// </summary>
    public class ACPDRepository : IACPDRepository
    {
        public async Task InsertAsync(ACPDData data)
        {
            //依照收到的ACPD資料，新增一筆進入DB
        }

        public async Task<ACPDData> SelectAsync(long sid)
        {
            //依照SID查詢出ACPD資料

            return new();
        }

        public async Task UpdateAsync(ACPDData data)
        {
            //依照收到的ACPD資料，更新DB中的資料
        }

        public async Task DeleteAsync(long sid)
        {
            //依照SID刪除DB中的資料

            /*
                https://github.com/mercuryfire/BackendExamHub/blob/main/TSQLScript/%E5%BE%8C%E7%AB%AF%E5%B7%A5%E7%A8%8B%E5%B8%AB_%E8%80%83%E9%A1%8C%E8%B3%87%E6%96%99%E8%A1%A8.pdf
                由於在.pdf中沒有看到類似isDeleted的DB欄位，故直接刪除
            */
        }
    }
}
