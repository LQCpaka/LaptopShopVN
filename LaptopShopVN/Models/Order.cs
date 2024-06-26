using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel;

namespace LaptopShopVN.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập họ tên đầy đủ")]
        [Display(Name = "Họ Tên")]
        public string CustomerName { get; set; }
        [Required(ErrorMessage = "Vui lòng cung cấp địa chỉ giao hàng")]
        [Display(Name = "Địa Chỉ")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập số điện thoại liên hệ")]
        [Display(Name = "Số Điện Thoại")]
        public string Phone { get; set; }
        [Display(Name = "Tổng")]
        public double Total { set; get; }
        [Display(Name = "Trạng Thái")]
        public string State { set; get; }


    }
}
