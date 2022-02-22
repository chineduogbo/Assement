namespace COUREAssessment.ModelLayer.Model
{
    public class CountryDetail
    {
        public int Id { get; set; }
        public string @operator { get; set; }
        public string operatorCode { get; set; }
        public int CountryId { get; set; }
        public virtual Country Country { get; set; }
    }

}
