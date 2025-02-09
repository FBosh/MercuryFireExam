using MercuryFireExam.Bases;
using MercuryFireExam.DTO;
using MercuryFireExam.Services;
using Microsoft.AspNetCore.Mvc;

namespace MercuryFireExam.Controllers
{
    /// <summary>
    /// ACPD控制器
    /// </summary>
    public class ACPDController(IACPDService acpdService) : MercuryFireExamControllerBase
    {
        /// <summary>
        /// ACPD服務介面
        /// </summary>
        private readonly IACPDService _acpdService = acpdService;

        /// <summary>
        /// 非同步增加
        /// </summary>
        /// <param name="dto">資料傳輸物件</param>
        /// <returns>200成功 或 400失敗</returns>
        [HttpPost]
        public async Task<IActionResult> AddAsync(ACPDDTO dto)
        {
            var isValid = Check(dto);
            if (isValid == false) return BadRequest("檢查未通過！");

            await _acpdService.AddAsync(dto);

            return Ok();
        }

        /// <summary>
        /// 非同步取得
        /// </summary>
        /// <param name="sid">編號</param>
        /// <returns>ACPD資料傳輸物件 或 400失敗</returns>
        [HttpGet]
        public async Task<IActionResult> GetAsync(long sid)
        {
            //初步檢查SID，視公司定義
            if (sid <= 0) return BadRequest("無效的SID！");

            var result = await _acpdService.GetAsync(sid);

            return Ok(result);
        }

        /// <summary>
        /// 非同步設定
        /// </summary>
        /// <param name="dto">資料傳輸物件</param>
        /// <returns>200成功 或 400失敗</returns>
        [HttpPut]
        public async Task<IActionResult> SetAsync(ACPDDTO dto)
        {
            var isValid = Check(dto);
            if (isValid == false) return BadRequest("檢查未通過！");

            await _acpdService.SetAsync(dto);

            return Ok();
        }

        /// <summary>
        /// 非同步移除
        /// </summary>
        /// <param name="sid">編號</param>
        /// <returns>200成功 或 400失敗</returns>
        [HttpDelete]
        public async Task<IActionResult> RemoveAsync(long sid)
        {
            //初步檢查SID，視公司定義
            if (sid <= 0) return BadRequest("無效的SID！");

            await _acpdService.RemoveAsync(sid);

            return Ok();
        }

        /// <summary>
        /// 檢查
        /// </summary>
        /// <param name="dto">資料傳輸物件</param>
        /// <returns>是否成功</returns>
        private static bool Check(ACPDDTO dto)
        {
            //檢查DTO是否符合公司規定

            return true;
        }
    }
}
