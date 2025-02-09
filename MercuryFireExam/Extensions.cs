using MercuryFireExam.Data;
using MercuryFireExam.DTO;
using Newtonsoft.Json;

namespace MercuryFireExam
{
    /// <summary>
    /// 擴充類別
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// 轉整數
        /// </summary>
        /// <returns>整數</returns>
        public static int ToInt(this object obj) => Convert.ToInt32(obj.ToString());

        /// <summary>
        /// 轉浮點數
        /// </summary>
        /// <returns>浮點數</returns>
        public static float ToFloat(this object obj) => Convert.ToSingle(obj.ToString());

        /// <summary>
        /// 轉長整數
        /// </summary>
        /// <returns>長整數</returns>
        public static long ToLong(this object obj) => Convert.ToInt64(obj.ToString());

        /// <summary>
        /// 轉小數
        /// </summary>
        /// <returns>小數</returns>
        public static decimal ToDecimal(this object obj) => Convert.ToDecimal(obj.ToString());

        /// <summary>
        /// 將開頭大寫後續小寫
        /// </summary>
        /// <returns>轉完後字串</returns>
        public static string Capitalize(this string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return string.Empty;
            }

            var firstLetter = str[0];
            var remainingLetters = str[1..];

            return firstLetter.ToString().ToUpper() + remainingLetters.ToLower();
        }

        /// <summary>
        /// 轉台灣時間
        /// </summary>
        /// <returns>台灣時區時間</returns>
        public static DateTimeOffset ToTW(this DateTimeOffset offset) => offset.ToOffset(TimeSpan.FromHours(8));

        /// <summary>
        /// 取得索引
        /// </summary>
        /// <typeparam name="T">泛型</typeparam>
        /// <param name="element">目標泛型內容</param>
        /// <returns>索引</returns>
        public static int IndexOf<T>(this IReadOnlyList<T> list, T element)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (Equals(list[i], element)) return i;
            }

            return -1;
        }

        /// <summary>
        /// 通知
        /// </summary>
        /// <param name="logger">紀錄器介面</param>
        /// <param name="txt">文字</param>
        public static void Inform(this ILogger logger, string txt) => logger.LogInformation("{txt}", txt);

        /// <summary>
        /// 警告
        /// </summary>
        /// <param name="logger">紀錄器介面</param>
        /// <param name="txt">文字</param>
        public static void Warn(this ILogger logger, string txt) => logger.LogWarning("警告：{txt}", txt);

        /// <summary>
        /// 轉資料
        /// </summary>
        /// <param name="dto">資料傳輸物件</param>
        /// <returns>ACPD資料</returns>
        public static ACPDData ToData(this ACPDDTO dto)
        {
            var serializedString = JsonConvert.SerializeObject(dto);

            return JsonConvert.DeserializeObject<ACPDData>(serializedString);
        }

        /// <summary>
        /// 轉資料傳輸物件
        /// </summary>
        /// <param name="data">資料</param>
        /// <returns>ACPD資料傳輸物件</returns>
        public static ACPDDTO ToDTO(this ACPDData data)
        {
            var serializedString = JsonConvert.SerializeObject(data);

            return JsonConvert.DeserializeObject<ACPDDTO>(serializedString);
        }
    }
}
