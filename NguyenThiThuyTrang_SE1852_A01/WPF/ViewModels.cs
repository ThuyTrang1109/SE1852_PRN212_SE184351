namespace Presentation
{
    // ViewModel cho danh sách đơn hàng
    public class OrderView
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; }
        public string EmployeeName { get; set; }
        public DateTime OrderDate { get; set; }
    }

    // ViewModel cho chi tiết đơn hàng
    public class OrderDetailView
    {
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public float Discount { get; set; }
    }

    // ViewModel cho báo cáo/thống kê đơn hàng
    public class ReportOrderView
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; }
        public string EmployeeName { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
