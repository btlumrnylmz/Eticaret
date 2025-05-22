using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eticaret.Core.Entities
{
    public class ProductImage : IEntity
    {
        public int Id { get; set; }
        [Display(Name = "Resim Adı"),StringLength(250)]
        public string? Name { get; set; }
        [Display(Name = "Resim Açıklama"),StringLength(250)]
        public string? Alt { get; set; }
        [Display(Name = "Ürün")]
        public int? ProductId { get; set; }
        public Product? Product { get; set; }
    }
}
