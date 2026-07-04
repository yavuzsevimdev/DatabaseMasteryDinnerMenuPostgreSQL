namespace DatabaseMastery.DinnerMenuPostgreSQL.Dtos.CategoryDtos
{
    public class CreateCategoryDto
    {
        public string CategoryName { get; set; }
        public string ImageUrl { get; set; }
        public bool CategoryStatus { get; set; }
    }
}
