using MercuryFireExam.DTO;
using MercuryFireExam.Repositories;

namespace MercuryFireExam.Services
{
    /// <summary>
    /// ACPD服務介面
    /// </summary>
    public interface IACPDService
    {
        /// <summary>
        /// 非同步增加
        /// </summary>
        /// <param name="dto">資料傳輸物件</param>
        Task AddAsync(ACPDDTO dto);

        /// <summary>
        /// 非同步取得
        /// </summary>
        /// <param name="sid">編號</param>
        /// <returns>ACPD資料傳輸物件</returns>
        Task<ACPDDTO> GetAsync(long sid);

        /// <summary>
        /// 非同步設定
        /// </summary>
        /// <param name="dto">資料傳輸物件</param>
        Task SetAsync(ACPDDTO dto);

        /// <summary>
        /// 非同步移除
        /// </summary>
        /// <param name="sid">編號</param>
        Task RemoveAsync(long sid);
    }

    /// <summary>
    /// ACPD服務
    /// </summary>
    /// <param name="acpdRepo">ACPD儲存庫介面</param>
    /// <param name="logger">紀錄器介面</param>
    public class ACPDService(
        IACPDRepository acpdRepo,
        ILogger<ACPDService> logger
        ) : IACPDService
    {
        /// <summary>
        /// ACPD儲存庫介面
        /// </summary>
        private readonly IACPDRepository _acpdRepo = acpdRepo;

        /// <summary>
        /// 紀錄器介面
        /// </summary>
        private readonly ILogger<ACPDService> _logger = logger;

        public async Task AddAsync(ACPDDTO dto)
        {
            try
            {
                //開啟DB連線、交易

                await _acpdRepo.InsertAsync(dto.ToData());

                //確認交易
            }
            catch (Exception e)
            {
                _logger.Warn($"{e}");

                throw;
            }
            finally
            {
                //關閉DB連線
            }
        }

        public async Task<ACPDDTO> GetAsync(long sid)
        {
            try
            {
                //開啟DB連線

                var data = await _acpdRepo.SelectAsync(sid);

                return data.ToDTO();
            }
            catch (Exception e)
            {
                _logger.Warn($"{e}");

                throw;
            }
            finally
            {
                //關閉DB連線
            }
        }

        public async Task SetAsync(ACPDDTO dto)
        {
            try
            {
                //開啟DB連線、交易

                await _acpdRepo.UpdateAsync(dto.ToData());

                //確認交易
            }
            catch (Exception e)
            {
                _logger.Warn($"{e}");

                throw;
            }
            finally
            {
                //關閉DB連線
            }
        }

        public async Task RemoveAsync(long sid)
        {
            try
            {
                //開啟DB連線、交易

                await _acpdRepo.DeleteAsync(sid);

                //確認交易
            }
            catch (Exception e)
            {
                _logger.Warn($"{e}");

                throw;
            }
            finally
            {
                //關閉DB連線
            }
        }
    }
}
