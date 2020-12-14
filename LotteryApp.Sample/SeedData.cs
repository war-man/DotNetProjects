using System.Collections.Generic;
using System.Linq;
using Bogus;

namespace LotteryApp.Sample
{
    /// <summary>
    /// 种子数据制造类
    /// </summary>
    public class SeedData
    {
        public static HashSet<EmployeeEntity> Data()
        {
            // 获取数据
            var employees = CreateSeedData();
            // 将数据打散成无序集合
            var hs = new HashSet<EmployeeEntity>();
            foreach (var item in employees)
            {
                hs.Add(item);
            }
            return hs;
        }

        /// <summary>
        /// 制造种子数据
        /// </summary>
        /// <returns></returns>
        private static List<EmployeeEntity> CreateSeedData()
        {
            var employees = new List<EmployeeEntity>();
            for (int i = 1; i <= 300; i++)
            {
                var employee = new Faker<EmployeeEntity>()
                    .RuleFor(p => p.No, o => o.Random.Int(1, 10000).ToString())
                    .RuleFor(p => p.Name, o => o.Internet.UserName())
                    .Generate();
                employees.Add(employee);
            }
            return employees;
        }
    }
}
