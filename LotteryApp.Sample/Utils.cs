using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotteryApp.Sample
{
    public class Utils
    {
        /// <summary>
        /// 根据随机数范围获取一定数量的随机数
        /// </summary>
        /// <param name="minNum">随机数最小值</param>
        /// <param name="isIncludeMinNum">是否包含最小值</param>
        /// <param name="maxNum">随机数最大值</param>
        /// <param name="isIncludeMaxNum">是否包含最大值</param>
        /// <param name="resultCount">随机结果数量</param>
        /// <param name="rm">随机数对象</param>
        /// <param name="isSame">结果是否重复</param>
        /// <returns></returns>
        private static List<int> GetRandom(int minNum, bool isIncludeMinNum, int maxNum, bool isIncludeMaxNum, int resultCount, Random rm, bool isSame)
        {
            List<int> randomList = new List<int>();
            int nValue = 0;

            //是否包含最大最小值，默认包含最小值，不包含最大值
            if (!isIncludeMinNum) { minNum = minNum + 1; }
            if (isIncludeMaxNum) { maxNum = maxNum + 1; }

            if (isSame)
            {
                for (int i = 0; randomList.Count < resultCount; i++)
                {
                    nValue = rm.Next(minNum, maxNum);
                    randomList.Add(nValue);
                }
            }
            else
            {
                for (int i = 0; randomList.Count < resultCount; i++)
                {
                    nValue = rm.Next(minNum, maxNum);
                    //重复判断
                    if (!randomList.Contains(nValue))
                    {
                        randomList.Add(nValue);
                    }
                }
            }

            return randomList;
        }
    }
}
