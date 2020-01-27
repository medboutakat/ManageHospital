namespace  ManageHospitalApi.Models
{
    public class MaterialModel : NameRemarkModel
    {
        public int Quantity { get; set; }
        public MaterialStatusModel MaterialStatusModel { get; set; }
        public MaterialCategoryModel MaterialCategoryModel { get; set; }
    }

}
