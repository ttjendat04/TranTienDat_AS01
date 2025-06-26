using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;

namespace TranTienDatWPF.ViewModels.Admin
{
    public class ReportViewModel
    {
        public ObservableCollection<MonthlyOrderReport> Reports { get; set; }

        public ReportViewModel(List<Order> orders)
        {
            var reportData = orders
                .GroupBy(o => o.OrderDate.Month)
                .Select(g => new MonthlyOrderReport
                {
                    Month = g.Key,
                    OrderCount = g.Count()
                })
                .OrderBy(r => r.Month)
                .ToList();

            Reports = new ObservableCollection<MonthlyOrderReport>(reportData);
        }
    }

    public class MonthlyOrderReport
    {
        public int Month { get; set; }
        public int OrderCount { get; set; }
    }
}

